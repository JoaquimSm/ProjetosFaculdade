using System;
using System.Windows.Forms;
using GP_car.Business;
using GP_car.Models;

namespace GP_car.Views
{
    public partial class FormCadastroCliente : Form
    {
        private readonly ClienteService _service;
        private Cliente _cliente;

        public FormCadastroCliente(Cliente? clienteParaEditar = null)
        {
            InitializeComponent();
            _service = new ClienteService();

            if (clienteParaEditar != null)
            {
                _cliente = clienteParaEditar;
                lblTitulo.Text = "Editar Cliente";
                txtNome.Text = _cliente.Nome;
                txtCnh.Text = _cliente.Cnh;
                txtTelefone.Text = _cliente.Telefone;
                txtEndereco.Text = _cliente.Endereco;
            }
            else
            {
                _cliente = new Cliente();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _cliente.Nome = txtNome.Text.Trim();
                _cliente.Cnh = txtCnh.Text.Trim();
                _cliente.Telefone = txtTelefone.Text.Trim();
                _cliente.Endereco = txtEndereco.Text.Trim();

                _service.Salvar(_cliente);

                MessageBox.Show("Cliente salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
