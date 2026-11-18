using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GP_car.Business;
using GP_car.Models;

namespace GP_car.Views
{
    public partial class FormClientes : Form
    {
        private readonly ClienteService _service;
        private List<Cliente> _todosClientes;

        public FormClientes()
        {
            InitializeComponent();
            _service = new ClienteService();
            _todosClientes = new List<Cliente>();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrade();
            CarregarDados();
        }

        private void ConfigurarGrade()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Columns.Clear();

            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdCliente", HeaderText = "ID", Width = 50 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome Completo", Width = 200 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cnh", HeaderText = "CNH", Width = 110 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone", Width = 120 });
            dgvClientes.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço", Width = 250 });
        }

        public void CarregarDados()
        {
            try
            {
                _todosClientes = _service.ObterTodos();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível carregar os clientes: {ex.Message}\n\nVerifique se o MySQL está rodando e a base 'gp_car_db' foi criada.", "Aviso de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AplicarFiltros()
        {
            if (_todosClientes == null) return;

            string termo = txtPesquisa.Text.Trim().ToLower();

            var lista = _todosClientes.Where(c =>
                string.IsNullOrEmpty(termo) ||
                c.Nome.ToLower().Contains(termo) ||
                c.Cnh.ToLower().Contains(termo)
            ).ToList();

            dgvClientes.DataSource = lista;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e) => AplicarFiltros();

        private Cliente? ObterClienteSelecionado()
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente na tabela primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return dgvClientes.SelectedRows[0].DataBoundItem as Cliente;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using var form = new FormCadastroCliente();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = ObterClienteSelecionado();
            if (cliente == null) return;

            using var form = new FormCadastroCliente(cliente);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var cliente = ObterClienteSelecionado();
            if (cliente == null) return;

            var confirm = MessageBox.Show($"Deseja realmente excluir o cliente {cliente.Nome}?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _service.Excluir(cliente.IdCliente);
                    CarregarDados();
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
