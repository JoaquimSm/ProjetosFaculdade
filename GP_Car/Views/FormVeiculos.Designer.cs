namespace GP_car.Views
{
    partial class FormVeiculos
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
            this.lblFiltroStatus = new System.Windows.Forms.Label();
            this.cbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnManutencao = new System.Windows.Forms.Button();
            this.btnDisponibilizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.pnlTopo.SuspendLayout();
            this.pnlAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
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
            this.lblTitulo.Text = "Controle de Frota e Status dos Veículos";

            // pnlAcoes
            this.pnlAcoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcoes.Height = 65;
            this.pnlAcoes.Controls.Add(this.lblPesquisa);
            this.pnlAcoes.Controls.Add(this.txtPesquisa);
            this.pnlAcoes.Controls.Add(this.lblFiltroStatus);
            this.pnlAcoes.Controls.Add(this.cbFiltroStatus);
            this.pnlAcoes.Controls.Add(this.btnNovo);
            this.pnlAcoes.Controls.Add(this.btnEditar);
            this.pnlAcoes.Controls.Add(this.btnManutencao);
            this.pnlAcoes.Controls.Add(this.btnDisponibilizar);
            this.pnlAcoes.Controls.Add(this.btnExcluir);

            // lblPesquisa & txtPesquisa
            this.lblPesquisa.Text = "Buscar Placa/Modelo:";
            this.lblPesquisa.Location = new System.Drawing.Point(15, 10);
            this.lblPesquisa.AutoSize = true;
            this.txtPesquisa.Location = new System.Drawing.Point(15, 30);
            this.txtPesquisa.Width = 140;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);

            // lblFiltroStatus & cbFiltroStatus
            this.lblFiltroStatus.Text = "Status:";
            this.lblFiltroStatus.Location = new System.Drawing.Point(165, 10);
            this.lblFiltroStatus.AutoSize = true;
            this.cbFiltroStatus.Location = new System.Drawing.Point(165, 30);
            this.cbFiltroStatus.Width = 110;
            this.cbFiltroStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroStatus.SelectedIndexChanged += new System.EventHandler(this.cbFiltroStatus_SelectedIndexChanged);

            // btnNovo
            this.btnNovo.Text = "+ Novo";
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(285, 27);
            this.btnNovo.Size = new System.Drawing.Size(75, 28);
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);

            // btnEditar
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(365, 27);
            this.btnEditar.Size = new System.Drawing.Size(75, 28);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnManutencao
            this.btnManutencao.Text = "🔧 Manutenção";
            this.btnManutencao.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnManutencao.ForeColor = System.Drawing.Color.White;
            this.btnManutencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManutencao.Location = new System.Drawing.Point(445, 27);
            this.btnManutencao.Size = new System.Drawing.Size(105, 28);
            this.btnManutencao.Click += new System.EventHandler(this.btnManutencao_Click);

            // btnDisponibilizar
            this.btnDisponibilizar.Text = "✔ Disponibilizar";
            this.btnDisponibilizar.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnDisponibilizar.ForeColor = System.Drawing.Color.White;
            this.btnDisponibilizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilizar.Location = new System.Drawing.Point(555, 27);
            this.btnDisponibilizar.Size = new System.Drawing.Size(110, 28);
            this.btnDisponibilizar.Click += new System.EventHandler(this.btnDisponibilizar_Click);

            // btnExcluir
            this.btnExcluir.Text = "🗑 Excluir";
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(670, 27);
            this.btnExcluir.Size = new System.Drawing.Size(80, 28);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            // dgvVeiculos
            this.dgvVeiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.MultiSelect = false;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVeiculos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVeiculos_CellFormatting);

            // FormVeiculos
            this.ClientSize = new System.Drawing.Size(860, 480);
            this.Controls.Add(this.dgvVeiculos);
            this.Controls.Add(this.pnlAcoes);
            this.Controls.Add(this.pnlTopo);
            this.Text = "Veículos";
            this.Load += new System.EventHandler(this.FormVeiculos_Load);
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlAcoes.ResumeLayout(false);
            this.pnlAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlAcoes;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblFiltroStatus;
        private System.Windows.Forms.ComboBox cbFiltroStatus;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnManutencao;
        private System.Windows.Forms.Button btnDisponibilizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvVeiculos;
    }
}
