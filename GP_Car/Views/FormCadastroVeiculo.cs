using System;
using System.Windows.Forms;
using GP_car.Business;
using GP_car.Models;

namespace GP_car.Views
{
    public partial class FormCadastroVeiculo : Form
    {
        private readonly VeiculoService _service;
        private Veiculo _veiculo;

        public FormCadastroVeiculo(Veiculo? veiculoParaEditar = null)
        {
            InitializeComponent();
            _service = new VeiculoService();

            cbCategoria.Items.AddRange(new object[] { "Hatch", "Sedan", "SUV", "Picape", "Utilitário", "Esportivo" });
            cbCategoria.SelectedIndex = 0;

            cbStatus.Items.AddRange(new object[] { "Disponivel", "Alugado", "Manutencao" });
            cbStatus.SelectedIndex = 0;

            if (veiculoParaEditar != null)
            {
                _veiculo = veiculoParaEditar;
                lblTitulo.Text = "Editar Veículo";
                txtPlaca.Text = _veiculo.Placa;
                txtPlaca.ReadOnly = true; // Placa é chave de identificação
                txtMarca.Text = _veiculo.Marca;
                txtModelo.Text = _veiculo.Modelo;
                cbCategoria.SelectedItem = _veiculo.Categoria;
                numAno.Value = _veiculo.Ano >= numAno.Minimum && _veiculo.Ano <= numAno.Maximum ? _veiculo.Ano : DateTime.Now.Year;
                txtCor.Text = _veiculo.Cor;
                cbStatus.SelectedItem = _veiculo.Status;
            }
            else
            {
                _veiculo = new Veiculo();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _veiculo.Placa = txtPlaca.Text.Trim();
                _veiculo.Marca = txtMarca.Text.Trim();
                _veiculo.Modelo = txtModelo.Text.Trim();
                _veiculo.Categoria = cbCategoria.SelectedItem?.ToString() ?? "Hatch";
                _veiculo.Ano = (int)numAno.Value;
                _veiculo.Cor = txtCor.Text.Trim();
                _veiculo.Status = cbStatus.SelectedItem?.ToString() ?? "Disponivel";

                _service.Salvar(_veiculo);

                MessageBox.Show("Veículo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
