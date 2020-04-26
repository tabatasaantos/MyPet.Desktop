namespace MyPet.UI
{
    partial class frmColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaboradores));
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.grpColaborador = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.mskTelefoneColaborador = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoColaborador = new System.Windows.Forms.TextBox();
            this.lblIDColaborador = new System.Windows.Forms.Label();
            this.txtIDColaborador = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtEmailColaborador = new System.Windows.Forms.TextBox();
            this.lblEmailColaborador = new System.Windows.Forms.Label();
            this.lblTelefoneColaborador = new System.Windows.Forms.Label();
            this.lblEnderecoColaborador = new System.Windows.Forms.Label();
            this.lblNomeColaborador = new System.Windows.Forms.Label();
            this.txtNomeColaborador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.grpColaborador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColaboradores.Location = new System.Drawing.Point(0, 241);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.Size = new System.Drawing.Size(646, 293);
            this.dgvColaboradores.TabIndex = 21;
            // 
            // grpColaborador
            // 
            this.grpColaborador.Controls.Add(this.btnAtualizar);
            this.grpColaborador.Controls.Add(this.mskTelefoneColaborador);
            this.grpColaborador.Controls.Add(this.txtEnderecoColaborador);
            this.grpColaborador.Controls.Add(this.lblIDColaborador);
            this.grpColaborador.Controls.Add(this.txtIDColaborador);
            this.grpColaborador.Controls.Add(this.btnCancelar);
            this.grpColaborador.Controls.Add(this.btnExcluir);
            this.grpColaborador.Controls.Add(this.btnSalvar);
            this.grpColaborador.Controls.Add(this.btnIncluir);
            this.grpColaborador.Controls.Add(this.txtEmailColaborador);
            this.grpColaborador.Controls.Add(this.lblEmailColaborador);
            this.grpColaborador.Controls.Add(this.lblTelefoneColaborador);
            this.grpColaborador.Controls.Add(this.lblEnderecoColaborador);
            this.grpColaborador.Controls.Add(this.lblNomeColaborador);
            this.grpColaborador.Controls.Add(this.txtNomeColaborador);
            this.grpColaborador.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpColaborador.Location = new System.Drawing.Point(0, 0);
            this.grpColaborador.Name = "grpColaborador";
            this.grpColaborador.Size = new System.Drawing.Size(646, 241);
            this.grpColaborador.TabIndex = 20;
            this.grpColaborador.TabStop = false;
            this.grpColaborador.Text = "Cadastro Colaborador";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(402, 41);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(40, 40);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // mskTelefoneColaborador
            // 
            this.mskTelefoneColaborador.Location = new System.Drawing.Point(49, 167);
            this.mskTelefoneColaborador.Mask = "(00) 000000000";
            this.mskTelefoneColaborador.Name = "mskTelefoneColaborador";
            this.mskTelefoneColaborador.Size = new System.Drawing.Size(204, 20);
            this.mskTelefoneColaborador.TabIndex = 4;
            // 
            // txtEnderecoColaborador
            // 
            this.txtEnderecoColaborador.Location = new System.Drawing.Point(48, 119);
            this.txtEnderecoColaborador.Name = "txtEnderecoColaborador";
            this.txtEnderecoColaborador.Size = new System.Drawing.Size(205, 20);
            this.txtEnderecoColaborador.TabIndex = 3;
            // 
            // lblIDColaborador
            // 
            this.lblIDColaborador.AutoSize = true;
            this.lblIDColaborador.Location = new System.Drawing.Point(45, 25);
            this.lblIDColaborador.Name = "lblIDColaborador";
            this.lblIDColaborador.Size = new System.Drawing.Size(78, 13);
            this.lblIDColaborador.TabIndex = 17;
            this.lblIDColaborador.Text = "ID Colaborador";
            // 
            // txtIDColaborador
            // 
            this.txtIDColaborador.AcceptsReturn = true;
            this.txtIDColaborador.Enabled = false;
            this.txtIDColaborador.Location = new System.Drawing.Point(48, 41);
            this.txtIDColaborador.Name = "txtIDColaborador";
            this.txtIDColaborador.Size = new System.Drawing.Size(205, 20);
            this.txtIDColaborador.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MyPet.UI.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(494, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::MyPet.UI.Properties.Resources.delete;
            this.btnExcluir.Location = new System.Drawing.Point(448, 41);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MyPet.UI.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(356, 41);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(40, 40);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(310, 41);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(40, 40);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtEmailColaborador
            // 
            this.txtEmailColaborador.Location = new System.Drawing.Point(48, 206);
            this.txtEmailColaborador.Name = "txtEmailColaborador";
            this.txtEmailColaborador.Size = new System.Drawing.Size(205, 20);
            this.txtEmailColaborador.TabIndex = 5;
            // 
            // lblEmailColaborador
            // 
            this.lblEmailColaborador.AutoSize = true;
            this.lblEmailColaborador.Location = new System.Drawing.Point(46, 190);
            this.lblEmailColaborador.Name = "lblEmailColaborador";
            this.lblEmailColaborador.Size = new System.Drawing.Size(35, 13);
            this.lblEmailColaborador.TabIndex = 9;
            this.lblEmailColaborador.Text = "E-mail";
            // 
            // lblTelefoneColaborador
            // 
            this.lblTelefoneColaborador.AutoSize = true;
            this.lblTelefoneColaborador.Location = new System.Drawing.Point(45, 151);
            this.lblTelefoneColaborador.Name = "lblTelefoneColaborador";
            this.lblTelefoneColaborador.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneColaborador.TabIndex = 5;
            this.lblTelefoneColaborador.Text = "Telefone";
            // 
            // lblEnderecoColaborador
            // 
            this.lblEnderecoColaborador.AutoSize = true;
            this.lblEnderecoColaborador.Location = new System.Drawing.Point(45, 103);
            this.lblEnderecoColaborador.Name = "lblEnderecoColaborador";
            this.lblEnderecoColaborador.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecoColaborador.TabIndex = 3;
            this.lblEnderecoColaborador.Text = "Endereço";
            // 
            // lblNomeColaborador
            // 
            this.lblNomeColaborador.AutoSize = true;
            this.lblNomeColaborador.Location = new System.Drawing.Point(46, 64);
            this.lblNomeColaborador.Name = "lblNomeColaborador";
            this.lblNomeColaborador.Size = new System.Drawing.Size(35, 13);
            this.lblNomeColaborador.TabIndex = 1;
            this.lblNomeColaborador.Text = "Nome";
            // 
            // txtNomeColaborador
            // 
            this.txtNomeColaborador.Location = new System.Drawing.Point(49, 80);
            this.txtNomeColaborador.Name = "txtNomeColaborador";
            this.txtNomeColaborador.Size = new System.Drawing.Size(204, 20);
            this.txtNomeColaborador.TabIndex = 2;
            // 
            // frmColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 534);
            this.Controls.Add(this.dgvColaboradores);
            this.Controls.Add(this.grpColaborador);
            this.Name = "frmColaboradores";
            this.Text = "frmColaboradores";
            this.Load += new System.EventHandler(this.frmColaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.grpColaborador.ResumeLayout(false);
            this.grpColaborador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.GroupBox grpColaborador;
        private System.Windows.Forms.Label lblIDColaborador;
        private System.Windows.Forms.TextBox txtIDColaborador;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtEmailColaborador;
        private System.Windows.Forms.Label lblEmailColaborador;
        private System.Windows.Forms.Label lblTelefoneColaborador;
        private System.Windows.Forms.Label lblEnderecoColaborador;
        private System.Windows.Forms.Label lblNomeColaborador;
        private System.Windows.Forms.TextBox txtNomeColaborador;
        private System.Windows.Forms.TextBox txtEnderecoColaborador;
        private System.Windows.Forms.MaskedTextBox mskTelefoneColaborador;
        private System.Windows.Forms.Button btnAtualizar;
    }
}