namespace GP_car.Views
{
    partial class FormCadastroCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCnh = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "Cadastro de Cliente";

            // lblNome & txtNome
            this.lblNome.Text = "Nome Completo:";
            this.lblNome.Location = new System.Drawing.Point(20, 55);
            this.lblNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(20, 75);
            this.txtNome.Size = new System.Drawing.Size(340, 25);

            // lblCnh & txtCnh
            this.lblCnh.Text = "Número da CNH:";
            this.lblCnh.Location = new System.Drawing.Point(20, 115);
            this.lblCnh.AutoSize = true;
            this.txtCnh.Location = new System.Drawing.Point(20, 135);
            this.txtCnh.Size = new System.Drawing.Size(160, 25);

            // lblTelefone & txtTelefone
            this.lblTelefone.Text = "Telefone / Celular:";
            this.lblTelefone.Location = new System.Drawing.Point(195, 115);
            this.lblTelefone.AutoSize = true;
            this.txtTelefone.Location = new System.Drawing.Point(195, 135);
            this.txtTelefone.Size = new System.Drawing.Size(165, 25);

            // lblEndereco & txtEndereco
            this.lblEndereco.Text = "Endereço Completo:";
            this.lblEndereco.Location = new System.Drawing.Point(20, 175);
            this.lblEndereco.AutoSize = true;
            this.txtEndereco.Location = new System.Drawing.Point(20, 195);
            this.txtEndereco.Size = new System.Drawing.Size(340, 25);

            // btnSalvar
            this.btnSalvar.Text = "Salvar Cliente";
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(150, 245);
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(280, 245);
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FormCadastroCliente
            this.ClientSize = new System.Drawing.Size(384, 305);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dados do Cliente";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCnh);
            this.Controls.Add(this.txtCnh);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCnh;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
