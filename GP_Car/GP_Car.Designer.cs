namespace GP_car
{
    partial class GP_Car
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubLogo = new System.Windows.Forms.Label();
            this.btnMenuVeiculos = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnTestarConexao = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusRodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // pnlMenuLateral
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.pnlMenuLateral.Controls.Add(this.btnTestarConexao);
            this.pnlMenuLateral.Controls.Add(this.btnMenuClientes);
            this.pnlMenuLateral.Controls.Add(this.btnMenuVeiculos);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Width = 200;

            // pnlLogo
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(34, 49, 63);
            this.pnlLogo.Controls.Add(this.lblSubLogo);
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Height = 80;

            // lblLogo
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 15);
            this.lblLogo.Text = "GP CAR";

            // lblSubLogo
            this.lblSubLogo.AutoSize = true;
            this.lblSubLogo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubLogo.ForeColor = System.Drawing.Color.Silver;
            this.lblSubLogo.Location = new System.Drawing.Point(22, 45);
            this.lblSubLogo.Text = "Locadora de Veículos";

            // btnMenuVeiculos
            this.btnMenuVeiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuVeiculos.Height = 50;
            this.btnMenuVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuVeiculos.FlatAppearance.BorderSize = 0;
            this.btnMenuVeiculos.ForeColor = System.Drawing.Color.White;
            this.btnMenuVeiculos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuVeiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuVeiculos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuVeiculos.Text = "🚗  Veículos e Status";
            this.btnMenuVeiculos.Click += new System.EventHandler(this.btnMenuVeiculos_Click);

            // btnMenuClientes
            this.btnMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuClientes.Height = 50;
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.ForeColor = System.Drawing.Color.White;
            this.btnMenuClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnMenuClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMenuClientes.Text = "👤  Clientes";
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);

            // btnTestarConexao
            this.btnTestarConexao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTestarConexao.Height = 45;
            this.btnTestarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestarConexao.FlatAppearance.BorderSize = 0;
            this.btnTestarConexao.ForeColor = System.Drawing.Color.DarkGray;
            this.btnTestarConexao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTestarConexao.Text = "🔌 Testar MySQL";
            this.btnTestarConexao.Click += new System.EventHandler(this.btnTestarConexao_Click);

            // pnlConteudo
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.BackColor = System.Drawing.Color.White;

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.lblStatusRodape });
            this.statusStrip1.Location = new System.Drawing.Point(200, 538);
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);

            // lblStatusRodape
            this.lblStatusRodape.Text = "Sistema GP CAR inicializado com sucesso.";

            // GP_Car (Form Mestre)
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlMenuLateral);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP CAR - Sistema de Gerenciamento e Locação de Veículos";
            this.Load += new System.EventHandler(this.GP_Car_Load);

            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubLogo;
        private System.Windows.Forms.Button btnMenuVeiculos;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnTestarConexao;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusRodape;
    }
}
