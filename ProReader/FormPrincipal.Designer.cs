namespace ProReader
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileCarregaArquivo = new System.Windows.Forms.OpenFileDialog();
            this.lblSaudacao = new MaterialSkin.Controls.MaterialLabel();
            this.lblUser = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.processarWeb = new MaterialSkin.Controls.MaterialRaisedButton();
            this.carregaArquivo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.carregaArquivoWeb = new MaterialSkin.Controls.MaterialRaisedButton();
            this.processarLocal = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listarSalvos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileCarregaArquivo
            // 
            this.openFileCarregaArquivo.FileName = "openFileCarregaArquivo";
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Depth = 0;
            this.lblSaudacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaudacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaudacao.Location = new System.Drawing.Point(630, 78);
            this.lblSaudacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(38, 19);
            this.lblSaudacao.TabIndex = 0;
            this.lblSaudacao.Text = "Olá, ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Depth = 0;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(668, 78);
            this.lblUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 19);
            this.lblUser.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(7, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(886, 402);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // processarWeb
            // 
            this.processarWeb.AutoSize = true;
            this.processarWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processarWeb.Depth = 0;
            this.processarWeb.Icon = null;
            this.processarWeb.Location = new System.Drawing.Point(806, 536);
            this.processarWeb.MouseState = MaterialSkin.MouseState.HOVER;
            this.processarWeb.Name = "processarWeb";
            this.processarWeb.Primary = true;
            this.processarWeb.Size = new System.Drawing.Size(99, 36);
            this.processarWeb.TabIndex = 5;
            this.processarWeb.Text = "Processar";
            this.processarWeb.UseVisualStyleBackColor = true;
            this.processarWeb.Visible = false;
            this.processarWeb.Click += new System.EventHandler(this.processarWeb_Click);
            // 
            // carregaArquivo
            // 
            this.carregaArquivo.AutoSize = true;
            this.carregaArquivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carregaArquivo.Depth = 0;
            this.carregaArquivo.Icon = null;
            this.carregaArquivo.Location = new System.Drawing.Point(403, 536);
            this.carregaArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.carregaArquivo.Name = "carregaArquivo";
            this.carregaArquivo.Primary = true;
            this.carregaArquivo.Size = new System.Drawing.Size(153, 36);
            this.carregaArquivo.TabIndex = 0;
            this.carregaArquivo.Text = "Carregar arquivo";
            this.carregaArquivo.UseVisualStyleBackColor = true;
            this.carregaArquivo.Click += new System.EventHandler(this.carregaArquivo_Click);
            // 
            // carregaArquivoWeb
            // 
            this.carregaArquivoWeb.AutoSize = true;
            this.carregaArquivoWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carregaArquivoWeb.Depth = 0;
            this.carregaArquivoWeb.Icon = null;
            this.carregaArquivoWeb.Location = new System.Drawing.Point(577, 536);
            this.carregaArquivoWeb.MouseState = MaterialSkin.MouseState.HOVER;
            this.carregaArquivoWeb.Name = "carregaArquivoWeb";
            this.carregaArquivoWeb.Primary = true;
            this.carregaArquivoWeb.Size = new System.Drawing.Size(206, 36);
            this.carregaArquivoWeb.TabIndex = 3;
            this.carregaArquivoWeb.Text = "Carregar arquivo da web";
            this.carregaArquivoWeb.UseVisualStyleBackColor = true;
            this.carregaArquivoWeb.Click += new System.EventHandler(this.carregaArquivoWeb_Click);
            // 
            // processarLocal
            // 
            this.processarLocal.AutoSize = true;
            this.processarLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processarLocal.Depth = 0;
            this.processarLocal.Icon = null;
            this.processarLocal.Location = new System.Drawing.Point(806, 536);
            this.processarLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.processarLocal.Name = "processarLocal";
            this.processarLocal.Primary = true;
            this.processarLocal.Size = new System.Drawing.Size(99, 36);
            this.processarLocal.TabIndex = 4;
            this.processarLocal.Text = "Processar";
            this.processarLocal.UseVisualStyleBackColor = true;
            this.processarLocal.Visible = false;
            this.processarLocal.Click += new System.EventHandler(this.processarLocal_Click);
            // 
            // listarSalvos
            // 
            this.listarSalvos.AutoSize = true;
            this.listarSalvos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.listarSalvos.Depth = 0;
            this.listarSalvos.Icon = null;
            this.listarSalvos.Location = new System.Drawing.Point(253, 536);
            this.listarSalvos.MouseState = MaterialSkin.MouseState.HOVER;
            this.listarSalvos.Name = "listarSalvos";
            this.listarSalvos.Primary = true;
            this.listarSalvos.Size = new System.Drawing.Size(127, 36);
            this.listarSalvos.TabIndex = 6;
            this.listarSalvos.Text = "Textos salvos";
            this.listarSalvos.UseVisualStyleBackColor = true;
            this.listarSalvos.Click += new System.EventHandler(this.listarSalvos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 584);
            this.Controls.Add(this.listarSalvos);
            this.Controls.Add(this.processarWeb);
            this.Controls.Add(this.processarLocal);
            this.Controls.Add(this.carregaArquivoWeb);
            this.Controls.Add(this.carregaArquivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSaudacao);
            this.Name = "FormPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileCarregaArquivo;
        private MaterialSkin.Controls.MaterialLabel lblSaudacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton carregaArquivo;
        private MaterialSkin.Controls.MaterialRaisedButton carregaArquivoWeb;
        private MaterialSkin.Controls.MaterialRaisedButton processarLocal;
        private MaterialSkin.Controls.MaterialRaisedButton processarWeb;
        public MaterialSkin.Controls.MaterialLabel lblUser;
        public System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialRaisedButton listarSalvos;
    }
}

