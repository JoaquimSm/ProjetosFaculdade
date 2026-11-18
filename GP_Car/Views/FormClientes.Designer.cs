namespace GP_car.Views
{
    partial class FormClientes
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
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlAcoes = new System.Windows.Forms.Panel();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.pnlTopo.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            // pnlTopo
            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 45;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblTitulo.Text = "Cadastro e Gestão de Clientes";

            // pnlAcoes
            this.pnlAcoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcoes.Height = 65;
            this.pnlAcoes.Controls.Add(this.lblPesquisa);
            this.pnlAcoes.Controls.Add(this.txtPesquisa);
            this.pnlAcoes.Controls.Add(this.btnNovo);
            this.pnlAcoes.Controls.Add(this.btnEditar);
            this.pnlAcoes.Controls.Add(this.btnExcluir);

            // lblPesquisa & txtPesquisa
            this.lblPesquisa.Text = "Buscar por Nome ou CNH:";
            this.lblPesquisa.Location = new System.Drawing.Point(15, 10);
            this.lblPesquisa.AutoSize = true;
            this.txtPesquisa.Location = new System.Drawing.Point(15, 30);
            this.txtPesquisa.Width = 250;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            // btnNovo
            this.btnNovo.Text = "+ Novo Cliente";
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(285, 27);
            this.btnNovo.Size = new System.Drawing.Size(110, 28);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);

            // btnEditar
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(405, 27);
            this.btnEditar.Size = new System.Drawing.Size(80, 28);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnExcluir
            this.btnExcluir.Text = "🗑 Excluir";
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(495, 27);
            this.btnExcluir.Size = new System.Drawing.Size(80, 28);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            // dgvClientes
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;

            // FormClientes
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnlAcoes);
            this.Controls.Add(this.pnlTopo);
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlAcoes.ResumeLayout(false);
            this.pnlAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcoes;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}
