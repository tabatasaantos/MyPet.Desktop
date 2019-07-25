namespace MyPet.UI
{
    partial class frmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.lblNomeAnimal = new System.Windows.Forms.Label();
            this.lblTipoAnimal = new System.Windows.Forms.Label();
            this.txtIdadeAnimal = new System.Windows.Forms.TextBox();
            this.lblIdadeAnimal = new System.Windows.Forms.Label();
            this.txtCorAnimal = new System.Windows.Forms.TextBox();
            this.lblCorAnimal = new System.Windows.Forms.Label();
            this.lblTamanhoAnimal = new System.Windows.Forms.Label();
            this.lblPesoAnimal = new System.Windows.Forms.Label();
            this.lblRacaAnimal = new System.Windows.Forms.Label();
            this.txtTamanhoAnimal = new System.Windows.Forms.TextBox();
            this.txtPesoAnimal = new System.Windows.Forms.TextBox();
            this.txtRacaAnimal = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDAnimal = new System.Windows.Forms.TextBox();
            this.lblIDAnimal = new System.Windows.Forms.Label();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(49, 80);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(204, 20);
            this.txtNomeAnimal.TabIndex = 2;
            // 
            // lblNomeAnimal
            // 
            this.lblNomeAnimal.AutoSize = true;
            this.lblNomeAnimal.Location = new System.Drawing.Point(46, 64);
            this.lblNomeAnimal.Name = "lblNomeAnimal";
            this.lblNomeAnimal.Size = new System.Drawing.Size(35, 13);
            this.lblNomeAnimal.TabIndex = 1;
            this.lblNomeAnimal.Text = "Nome";
            // 
            // lblTipoAnimal
            // 
            this.lblTipoAnimal.AutoSize = true;
            this.lblTipoAnimal.Location = new System.Drawing.Point(45, 103);
            this.lblTipoAnimal.Name = "lblTipoAnimal";
            this.lblTipoAnimal.Size = new System.Drawing.Size(28, 13);
            this.lblTipoAnimal.TabIndex = 3;
            this.lblTipoAnimal.Text = "Tipo";
            // 
            // txtIdadeAnimal
            // 
            this.txtIdadeAnimal.Location = new System.Drawing.Point(48, 167);
            this.txtIdadeAnimal.Name = "txtIdadeAnimal";
            this.txtIdadeAnimal.Size = new System.Drawing.Size(53, 20);
            this.txtIdadeAnimal.TabIndex = 4;
            // 
            // lblIdadeAnimal
            // 
            this.lblIdadeAnimal.AutoSize = true;
            this.lblIdadeAnimal.Location = new System.Drawing.Point(47, 151);
            this.lblIdadeAnimal.Name = "lblIdadeAnimal";
            this.lblIdadeAnimal.Size = new System.Drawing.Size(34, 13);
            this.lblIdadeAnimal.TabIndex = 5;
            this.lblIdadeAnimal.Text = "Idade";
            // 
            // txtCorAnimal
            // 
            this.txtCorAnimal.Location = new System.Drawing.Point(109, 167);
            this.txtCorAnimal.Name = "txtCorAnimal";
            this.txtCorAnimal.Size = new System.Drawing.Size(144, 20);
            this.txtCorAnimal.TabIndex = 5;
            // 
            // lblCorAnimal
            // 
            this.lblCorAnimal.AutoSize = true;
            this.lblCorAnimal.Location = new System.Drawing.Point(106, 151);
            this.lblCorAnimal.Name = "lblCorAnimal";
            this.lblCorAnimal.Size = new System.Drawing.Size(23, 13);
            this.lblCorAnimal.TabIndex = 7;
            this.lblCorAnimal.Text = "Cor";
            // 
            // lblTamanhoAnimal
            // 
            this.lblTamanhoAnimal.AutoSize = true;
            this.lblTamanhoAnimal.Location = new System.Drawing.Point(259, 151);
            this.lblTamanhoAnimal.Name = "lblTamanhoAnimal";
            this.lblTamanhoAnimal.Size = new System.Drawing.Size(52, 13);
            this.lblTamanhoAnimal.TabIndex = 8;
            this.lblTamanhoAnimal.Text = "Tamanho";
            // 
            // lblPesoAnimal
            // 
            this.lblPesoAnimal.AutoSize = true;
            this.lblPesoAnimal.Location = new System.Drawing.Point(45, 190);
            this.lblPesoAnimal.Name = "lblPesoAnimal";
            this.lblPesoAnimal.Size = new System.Drawing.Size(31, 13);
            this.lblPesoAnimal.TabIndex = 9;
            this.lblPesoAnimal.Text = "Peso";
            // 
            // lblRacaAnimal
            // 
            this.lblRacaAnimal.AutoSize = true;
            this.lblRacaAnimal.Location = new System.Drawing.Point(106, 190);
            this.lblRacaAnimal.Name = "lblRacaAnimal";
            this.lblRacaAnimal.Size = new System.Drawing.Size(33, 13);
            this.lblRacaAnimal.TabIndex = 10;
            this.lblRacaAnimal.Text = "Raça";
            // 
            // txtTamanhoAnimal
            // 
            this.txtTamanhoAnimal.Location = new System.Drawing.Point(262, 167);
            this.txtTamanhoAnimal.Name = "txtTamanhoAnimal";
            this.txtTamanhoAnimal.Size = new System.Drawing.Size(93, 20);
            this.txtTamanhoAnimal.TabIndex = 6;
            // 
            // txtPesoAnimal
            // 
            this.txtPesoAnimal.Location = new System.Drawing.Point(48, 206);
            this.txtPesoAnimal.Name = "txtPesoAnimal";
            this.txtPesoAnimal.Size = new System.Drawing.Size(53, 20);
            this.txtPesoAnimal.TabIndex = 7;
            // 
            // txtRacaAnimal
            // 
            this.txtRacaAnimal.Location = new System.Drawing.Point(109, 206);
            this.txtRacaAnimal.Name = "txtRacaAnimal";
            this.txtRacaAnimal.Size = new System.Drawing.Size(246, 20);
            this.txtRacaAnimal.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(361, 38);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(40, 40);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::MyPet.UI.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(407, 38);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::MyPet.UI.Properties.Resources.delete;
            this.btnExcluir.Location = new System.Drawing.Point(499, 38);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MyPet.UI.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(545, 38);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 100);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtIDAnimal
            // 
            this.txtIDAnimal.AcceptsReturn = true;
            this.txtIDAnimal.Enabled = false;
            this.txtIDAnimal.Location = new System.Drawing.Point(48, 41);
            this.txtIDAnimal.Name = "txtIDAnimal";
            this.txtIDAnimal.Size = new System.Drawing.Size(205, 20);
            this.txtIDAnimal.TabIndex = 1;
            // 
            // lblIDAnimal
            // 
            this.lblIDAnimal.AutoSize = true;
            this.lblIDAnimal.Location = new System.Drawing.Point(47, 25);
            this.lblIDAnimal.Name = "lblIDAnimal";
            this.lblIDAnimal.Size = new System.Drawing.Size(52, 13);
            this.lblIDAnimal.TabIndex = 17;
            this.lblIDAnimal.Text = "ID Animal";
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.lblDescricao);
            this.grpAnimal.Controls.Add(this.txtDescricao);
            this.grpAnimal.Controls.Add(this.txtTipo);
            this.grpAnimal.Controls.Add(this.btnAtualizar);
            this.grpAnimal.Controls.Add(this.lblIDAnimal);
            this.grpAnimal.Controls.Add(this.txtIDAnimal);
            this.grpAnimal.Controls.Add(this.pictureBox1);
            this.grpAnimal.Controls.Add(this.btnCancelar);
            this.grpAnimal.Controls.Add(this.btnExcluir);
            this.grpAnimal.Controls.Add(this.btnSalvar);
            this.grpAnimal.Controls.Add(this.btnIncluir);
            this.grpAnimal.Controls.Add(this.txtRacaAnimal);
            this.grpAnimal.Controls.Add(this.txtPesoAnimal);
            this.grpAnimal.Controls.Add(this.txtTamanhoAnimal);
            this.grpAnimal.Controls.Add(this.lblRacaAnimal);
            this.grpAnimal.Controls.Add(this.lblPesoAnimal);
            this.grpAnimal.Controls.Add(this.lblTamanhoAnimal);
            this.grpAnimal.Controls.Add(this.lblCorAnimal);
            this.grpAnimal.Controls.Add(this.txtCorAnimal);
            this.grpAnimal.Controls.Add(this.lblIdadeAnimal);
            this.grpAnimal.Controls.Add(this.txtIdadeAnimal);
            this.grpAnimal.Controls.Add(this.lblTipoAnimal);
            this.grpAnimal.Controls.Add(this.lblNomeAnimal);
            this.grpAnimal.Controls.Add(this.txtNomeAnimal);
            this.grpAnimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAnimal.Location = new System.Drawing.Point(0, 0);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(646, 241);
            this.grpAnimal.TabIndex = 0;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "Cadastro Animal";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(453, 38);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(40, 40);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnimal.Location = new System.Drawing.Point(0, 241);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.Size = new System.Drawing.Size(646, 293);
            this.dgvAnimal.TabIndex = 20;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(50, 120);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(53, 20);
            this.txtTipo.TabIndex = 18;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtTipo_TextChanged);
            this.txtTipo.Validated += new System.EventHandler(this.txtTipo_Validated);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(109, 120);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(144, 20);
            this.txtDescricao.TabIndex = 19;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(106, 104);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 20;
            this.lblDescricao.Text = "Descrição";
             // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.grpAnimal);
            this.Name = "frmAnimal";
            this.Text = "frmAnimal";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAnimal;
        private System.Windows.Forms.Label lblNomeAnimal;
        private System.Windows.Forms.Label lblTipoAnimal;
        private System.Windows.Forms.TextBox txtIdadeAnimal;
        private System.Windows.Forms.Label lblIdadeAnimal;
        private System.Windows.Forms.TextBox txtCorAnimal;
        private System.Windows.Forms.Label lblCorAnimal;
        private System.Windows.Forms.Label lblTamanhoAnimal;
        private System.Windows.Forms.Label lblPesoAnimal;
        private System.Windows.Forms.Label lblRacaAnimal;
        private System.Windows.Forms.TextBox txtTamanhoAnimal;
        private System.Windows.Forms.TextBox txtPesoAnimal;
        private System.Windows.Forms.TextBox txtRacaAnimal;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIDAnimal;
        private System.Windows.Forms.Label lblIDAnimal;
        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtTipo;
    }
}