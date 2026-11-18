namespace GP_car.Views
{
    partial class FormCadastroVeiculo
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Text = "Cadastro de Veículo";

            // lblPlaca & txtPlaca
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.Location = new System.Drawing.Point(20, 55);
            this.lblPlaca.AutoSize = true;
            this.txtPlaca.Location = new System.Drawing.Point(20, 75);
            this.txtPlaca.Size = new System.Drawing.Size(150, 25);

            // lblMarca & txtMarca
            this.lblMarca.Text = "Marca (Fabricante):";
            this.lblMarca.Location = new System.Drawing.Point(190, 55);
            this.lblMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(190, 75);
            this.txtMarca.Size = new System.Drawing.Size(170, 25);

            // lblModelo & txtModelo
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.Location = new System.Drawing.Point(20, 115);
            this.lblModelo.AutoSize = true;
            this.txtModelo.Location = new System.Drawing.Point(20, 135);
            this.txtModelo.Size = new System.Drawing.Size(150, 25);

            // lblCategoria & cbCategoria
            this.lblCategoria.Text = "Categoria:";
            this.lblCategoria.Location = new System.Drawing.Point(190, 115);
            this.lblCategoria.AutoSize = true;
            this.cbCategoria.Location = new System.Drawing.Point(190, 135);
            this.cbCategoria.Size = new System.Drawing.Size(170, 25);
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblAno & numAno
            this.lblAno.Text = "Ano de Fabricação:";
            this.lblAno.Location = new System.Drawing.Point(20, 175);
            this.lblAno.AutoSize = true;
            this.numAno.Location = new System.Drawing.Point(20, 195);
            this.numAno.Size = new System.Drawing.Size(150, 25);
            this.numAno.Minimum = 1970;
            this.numAno.Maximum = 2030;
            this.numAno.Value = 2024;

            // lblCor & txtCor
            this.lblCor.Text = "Cor:";
            this.lblCor.Location = new System.Drawing.Point(190, 175);
            this.lblCor.AutoSize = true;
            this.txtCor.Location = new System.Drawing.Point(190, 195);
            this.txtCor.Size = new System.Drawing.Size(170, 25);

            // lblStatus & cbStatus
            this.lblStatus.Text = "Status Inicial:";
            this.lblStatus.Location = new System.Drawing.Point(20, 235);
            this.lblStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(20, 255);
            this.cbStatus.Size = new System.Drawing.Size(340, 25);
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnSalvar
            this.btnSalvar.Text = "Salvar Veículo";
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(150, 310);
            this.btnSalvar.Size = new System.Drawing.Size(120, 35);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // btnCancelar
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(280, 310);
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FormCadastroVeiculo
            this.ClientSize = new System.Drawing.Size(384, 365);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dados do Veículo";
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
