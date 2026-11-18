using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GP_car.Business;
using GP_car.Models;

namespace GP_car.Views
{
    public partial class FormVeiculos : Form
    {
        private readonly VeiculoService _service;
        private List<Veiculo> _todosVeiculos;

        public FormVeiculos()
        {
            InitializeComponent();
            _service = new VeiculoService();
            _todosVeiculos = new List<Veiculo>();
        }

        private void FormVeiculos_Load(object sender, EventArgs e)
        {
            cbFiltroStatus.Items.Clear();
            cbFiltroStatus.Items.AddRange(new object[] { "Todos", "Disponivel", "Alugado", "Manutencao" });
            cbFiltroStatus.SelectedIndex = 0;

            ConfigurarGrade();
            CarregarDados();
        }

        private void ConfigurarGrade()
        {
            dgvVeiculos.AutoGenerateColumns = false;
            dgvVeiculos.Columns.Clear();

            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdVeiculo", HeaderText = "ID", Width = 45 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa", Width = 95 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca", Width = 110 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo", Width = 130 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria", Width = 95 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Ano", HeaderText = "Ano", Width = 65 });
            dgvVeiculos.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cor", HeaderText = "Cor", Width = 80 });

            var colStatus = new DataGridViewTextBoxColumn
            {
                Name = "colStatus",
                DataPropertyName = "Status",
                HeaderText = "Status Atual",
                Width = 110
            };
            dgvVeiculos.Columns.Add(colStatus);
        }

        public void CarregarDados()
        {
            try
            {
                _todosVeiculos = _service.ObterTodos();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível carregar os veículos: {ex.Message}\n\nVerifique se o MySQL está rodando e a base 'gp_car_db' foi criada.", "Aviso de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AplicarFiltros()
        {
            if (_todosVeiculos == null) return;

            string termo = txtPesquisa.Text.Trim().ToLower();
            string statusSelecionado = cbFiltroStatus.SelectedItem?.ToString() ?? "Todos";

            var lista = _todosVeiculos.Where(v =>
                (string.IsNullOrEmpty(termo) ||
                 v.Placa.ToLower().Contains(termo) ||
                 v.Modelo.ToLower().Contains(termo) ||
                 v.Marca.ToLower().Contains(termo)) &&
                (statusSelecionado == "Todos" || v.Status.Equals(statusSelecionado, StringComparison.OrdinalIgnoreCase))
            ).ToList();

            dgvVeiculos.DataSource = lista;
        }

        private void dgvVeiculos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVeiculos.Columns[e.ColumnIndex].Name == "colStatus" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (status == "Disponivel")
                {
                    e.CellStyle.BackColor = Color.FromArgb(212, 239, 223);
                    e.CellStyle.ForeColor = Color.FromArgb(20, 90, 50);
                    e.CellStyle.Font = new Font(dgvVeiculos.Font, FontStyle.Bold);
                }
                else if (status == "Alugado")
                {
                    e.CellStyle.BackColor = Color.FromArgb(250, 219, 216);
                    e.CellStyle.ForeColor = Color.FromArgb(120, 40, 31);
                    e.CellStyle.Font = new Font(dgvVeiculos.Font, FontStyle.Bold);
                }
                else if (status == "Manutencao")
                {
                    e.CellStyle.BackColor = Color.FromArgb(254, 249, 231);
                    e.CellStyle.ForeColor = Color.FromArgb(125, 102, 8);
                    e.CellStyle.Font = new Font(dgvVeiculos.Font, FontStyle.Bold);
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        private Veiculo? ObterVeiculoSelecionado()
        {
            if (dgvVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um veículo na tabela primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return dgvVeiculos.SelectedRows[0].DataBoundItem as Veiculo;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            using var form = new FormCadastroVeiculo();
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var veiculo = ObterVeiculoSelecionado();
            if (veiculo == null) return;

            using var form = new FormCadastroVeiculo(veiculo);
            if (form.ShowDialog() == DialogResult.OK)
            {
                CarregarDados();
            }
        }

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            var veiculo = ObterVeiculoSelecionado();
            if (veiculo == null) return;

            try
            {
                _service.AlterarStatus(veiculo.IdVeiculo, "Manutencao");
                CarregarDados();
                MessageBox.Show($"Veículo {veiculo.Modelo} ({veiculo.Placa}) alterado para MANUTENÇÃO.", "Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDisponibilizar_Click(object sender, EventArgs e)
        {
            var veiculo = ObterVeiculoSelecionado();
            if (veiculo == null) return;

            try
            {
                _service.AlterarStatus(veiculo.IdVeiculo, "Disponivel");
                CarregarDados();
                MessageBox.Show($"Veículo {veiculo.Modelo} ({veiculo.Placa}) alterado para DISPONÍVEL.", "Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var veiculo = ObterVeiculoSelecionado();
            if (veiculo == null) return;

            var confirm = MessageBox.Show($"Deseja realmente excluir o veículo {veiculo.Modelo} ({veiculo.Placa})?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _service.Excluir(veiculo.IdVeiculo);
                    CarregarDados();
                    MessageBox.Show("Veículo excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
