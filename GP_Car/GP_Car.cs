using System;
using System.Drawing;
using System.Windows.Forms;
using GP_car.Data;
using GP_car.Views;

namespace GP_car
{
    public partial class GP_Car : Form
    {
        private Form? _formAtivo = null;

        public GP_Car()
        {
            InitializeComponent();
            try
            {
                if (System.IO.File.Exists("app.ico"))
                {
                    this.Icon = new Icon("app.ico");
                }
            }
            catch { }
        }

        private void GP_Car_Load(object sender, EventArgs e)
        {
            // Abre por padrão a tela de Veículos e Status
            AbrirFormNoPainel(new FormVeiculos());
        }

        private void AbrirFormNoPainel(Form formFilho)
        {
            if (_formAtivo != null)
            {
                _formAtivo.Close();
                _formAtivo.Dispose();
            }

            _formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Clear();
            pnlConteudo.Controls.Add(formFilho);
            pnlConteudo.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
        }

        private void btnMenuVeiculos_Click(object sender, EventArgs e)
        {
            btnMenuVeiculos.BackColor = Color.FromArgb(52, 73, 94);
            btnMenuClientes.BackColor = Color.FromArgb(44, 62, 80);
            lblStatusRodape.Text = "Módulo selecionado: Gerenciamento de Frota e Status de Veículos.";
            AbrirFormNoPainel(new FormVeiculos());
        }

        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            btnMenuClientes.BackColor = Color.FromArgb(52, 73, 94);
            btnMenuVeiculos.BackColor = Color.FromArgb(44, 62, 80);
            lblStatusRodape.Text = "Módulo selecionado: Cadastro e Gestão de Clientes.";
            AbrirFormNoPainel(new FormClientes());
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            if (Conexao.TestarConexao(out string erro))
            {
                MessageBox.Show("Conexão com o banco MySQL estabelecida com sucesso!", "Status Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatusRodape.Text = "MySQL Conectado com sucesso (gp_car_db).";
            }
            else
            {
                MessageBox.Show($"Falha ao conectar no MySQL:\n{erro}\n\nVerifique a string em Data/Conexao.cs (usuário e senha do MySQL local).", "Falha de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblStatusRodape.Text = "Erro ao conectar ao MySQL.";
            }
        }
    }
}
