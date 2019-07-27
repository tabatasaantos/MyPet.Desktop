namespace MyPet.UI
{
    partial class frmFiltroAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIdAnimal = new System.Windows.Forms.TextBox();
            this.txtDescricaoAnimal = new System.Windows.Forms.TextBox();
            this.lblDescricaoAnimal = new System.Windows.Forms.Label();
            this.lblIDAnimal = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.txtTipoAnimal = new System.Windows.Forms.TextBox();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdAnimal
            // 
            this.txtIdAnimal.AcceptsReturn = true;
            this.txtIdAnimal.Location = new System.Drawing.Point(18, 39);
            this.txtIdAnimal.Name = "txtIdAnimal";
            this.txtIdAnimal.Size = new System.Drawing.Size(53, 20);
            this.txtIdAnimal.TabIndex = 34;
            // 
            // txtDescricaoAnimal
            // 
            this.txtDescricaoAnimal.Location = new System.Drawing.Point(86, 79);
            this.txtDescricaoAnimal.Name = "txtDescricaoAnimal";
            this.txtDescricaoAnimal.Size = new System.Drawing.Size(363, 20);
            this.txtDescricaoAnimal.TabIndex = 33;
            // 
            // lblDescricaoAnimal
            // 
            this.lblDescricaoAnimal.AutoSize = true;
            this.lblDescricaoAnimal.Location = new System.Drawing.Point(83, 63);
            this.lblDescricaoAnimal.Name = "lblDescricaoAnimal";
            this.lblDescricaoAnimal.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoAnimal.TabIndex = 32;
            this.lblDescricaoAnimal.Text = "Descrição";
            // 
            // lblIDAnimal
            // 
            this.lblIDAnimal.AutoSize = true;
            this.lblIDAnimal.Location = new System.Drawing.Point(15, 23);
            this.lblIDAnimal.Name = "lblIDAnimal";
            this.lblIDAnimal.Size = new System.Drawing.Size(52, 13);
            this.lblIDAnimal.TabIndex = 35;
            this.lblIDAnimal.Text = "ID Animal";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::MyPet.UI.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(525, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 40);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::MyPet.UI.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(479, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblTipoAnimal);
            this.grpFiltro.Controls.Add(this.lblNomeAnimal);
            this.grpFiltro.Controls.Add(this.txtTipoAnimal);
            this.grpFiltro.Controls.Add(this.txtNomeAnimal);
            this.grpFiltro.Controls.Add(this.txtDescricaoAnimal);
            this.grpFiltro.Controls.Add(this.txtIdAnimal);
            this.grpFiltro.Controls.Add(this.btnBuscar);
            this.grpFiltro.Controls.Add(this.lblIDAnimal);
            this.grpFiltro.Controls.Add(this.btnVoltar);
            this.grpFiltro.Controls.Add(this.lblDescricaoAnimal);
            this.grpFiltro.Location = new System.Drawing.Point(0, 1);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(650, 118);
            this.grpFiltro.TabIndex = 36;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtros";
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Location = new System.Drawing.Point(15, 63);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(28, 13);
            this.lblTipoAnimal.TabIndex = 40;
            this.lblTipoAnimal.Text = "Tipo";
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(83, 23);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAnimal.TabIndex = 39;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // txtTipoAnimal
            // 
            this.txtTipoAnimal.Location = new System.Drawing.Point(18, 79);
            this.txtTipoAnimal.Name = "txtTipoAnimal";
            this.txtTipoAnimal.Size = new System.Drawing.Size(53, 20);
            this.txtTipoAnimal.TabIndex = 37;
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(86, 39);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(363, 20);
            this.txtNomeAnimal.TabIndex = 36;
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AllowUserToAddRows = false;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Caracteristicas});
            this.dgvAnimal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAnimal.Location = new System.Drawing.Point(0, 176);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimal.Size = new System.Drawing.Size(650, 203);
            this.dgvAnimal.TabIndex = 37;
            this.dgvAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimal_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Width = 43;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 15;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 80;
            // 
            // Caracteristicas
            // 
            this.Caracteristicas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Caracteristicas.DataPropertyName = "Caracteristicas";
            this.Caracteristicas.HeaderText = "Características";
            this.Caracteristicas.MinimumWidth = 50;
            this.Caracteristicas.Name = "Caracteristicas";
            this.Caracteristicas.Width = 103;
            // 
            // frmFiltroAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 379);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.grpFiltro);
            this.Name = "frmFiltroAnimal";
            this.Text = "frmFiltroAnimal";
            this.Load += new System.EventHandler(this.frmFiltroAnimal_Load);
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDescricaoAnimal;
        private System.Windows.Forms.Label lblIDAnimal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
        public System.Windows.Forms.TextBox txtIdAnimal;
        public System.Windows.Forms.TextBox txtDescricaoAnimal;
        public System.Windows.Forms.TextBox txtTipoAnimal;
        public System.Windows.Forms.TextBox txtNomeAnimal;
    }
}