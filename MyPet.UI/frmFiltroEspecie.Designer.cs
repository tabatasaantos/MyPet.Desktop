namespace MyPet.UI
{
    partial class frmFiltroEspecie
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
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.txtIDEspecie = new System.Windows.Forms.TextBox();
            this.txtDescricaoEspecie = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblDescricaoEspecie = new System.Windows.Forms.Label();
            this.lblIDEspecie = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTipos
            // 
            this.dgvTipos.AllowUserToAddRows = false;
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Caracteristicas});
            this.dgvTipos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTipos.Location = new System.Drawing.Point(0, 137);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipos.Size = new System.Drawing.Size(650, 242);
            this.dgvTipos.TabIndex = 24;
            this.dgvTipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipos_CellContentClick);
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
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.txtIDEspecie);
            this.grpFiltro.Controls.Add(this.txtDescricaoEspecie);
            this.grpFiltro.Controls.Add(this.btnVoltar);
            this.grpFiltro.Controls.Add(this.lblDescricaoEspecie);
            this.grpFiltro.Controls.Add(this.lblIDEspecie);
            this.grpFiltro.Controls.Add(this.btnBuscar);
            this.grpFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFiltro.Location = new System.Drawing.Point(0, 0);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(650, 77);
            this.grpFiltro.TabIndex = 25;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtros";
            // 
            // txtIDEspecie
            // 
            this.txtIDEspecie.AcceptsReturn = true;
            this.txtIDEspecie.Location = new System.Drawing.Point(9, 44);
            this.txtIDEspecie.Name = "txtIDEspecie";
            this.txtIDEspecie.Size = new System.Drawing.Size(205, 20);
            this.txtIDEspecie.TabIndex = 28;
 
            // 
            // txtDescricaoEspecie
            // 
            this.txtDescricaoEspecie.Location = new System.Drawing.Point(245, 44);
            this.txtDescricaoEspecie.Name = "txtDescricaoEspecie";
            this.txtDescricaoEspecie.Size = new System.Drawing.Size(204, 20);
            this.txtDescricaoEspecie.TabIndex = 27;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::MyPet.UI.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(516, 28);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(40, 40);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDescricaoEspecie
            // 
            this.lblDescricaoEspecie.AutoSize = true;
            this.lblDescricaoEspecie.Location = new System.Drawing.Point(242, 28);
            this.lblDescricaoEspecie.Name = "lblDescricaoEspecie";
            this.lblDescricaoEspecie.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoEspecie.TabIndex = 26;
            this.lblDescricaoEspecie.Text = "Descrição";
            // 
            // lblIDEspecie
            // 
            this.lblIDEspecie.AutoSize = true;
            this.lblIDEspecie.Location = new System.Drawing.Point(6, 28);
            this.lblIDEspecie.Name = "lblIDEspecie";
            this.lblIDEspecie.Size = new System.Drawing.Size(59, 13);
            this.lblIDEspecie.TabIndex = 29;
            this.lblIDEspecie.Text = "ID Espécie";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::MyPet.UI.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(470, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmFiltroEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 379);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.dgvTipos);
            this.Name = "frmFiltroEspecie";
            this.Text = "frmFiltroEspecie";
            this.Load += new System.EventHandler(this.frmFiltroEspecie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.TextBox txtIDEspecie;
        private System.Windows.Forms.TextBox txtDescricaoEspecie;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblDescricaoEspecie;
        private System.Windows.Forms.Label lblIDEspecie;
        private System.Windows.Forms.Button btnBuscar;
    }
}