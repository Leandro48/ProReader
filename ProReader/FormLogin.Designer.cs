namespace ProReader
{
    partial class FormLogin
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
            this.txtboxLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblSenha = new MaterialSkin.Controls.MaterialLabel();
            this.btnAcessar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Depth = 0;
            this.txtboxLogin.Hint = "";
            this.txtboxLogin.Location = new System.Drawing.Point(169, 122);
            this.txtboxLogin.MaxLength = 32767;
            this.txtboxLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.PasswordChar = '\0';
            this.txtboxLogin.SelectedText = "";
            this.txtboxLogin.SelectionLength = 0;
            this.txtboxLogin.SelectionStart = 0;
            this.txtboxLogin.Size = new System.Drawing.Size(130, 23);
            this.txtboxLogin.TabIndex = 0;
            this.txtboxLogin.TabStop = false;
            this.txtboxLogin.UseSystemPasswordChar = false;
            // 
            // txtboxSenha
            // 
            this.txtboxSenha.Depth = 0;
            this.txtboxSenha.Hint = "";
            this.txtboxSenha.Location = new System.Drawing.Point(169, 164);
            this.txtboxSenha.MaxLength = 32767;
            this.txtboxSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxSenha.Name = "txtboxSenha";
            this.txtboxSenha.PasswordChar = '*';
            this.txtboxSenha.SelectedText = "";
            this.txtboxSenha.SelectionLength = 0;
            this.txtboxSenha.SelectionStart = 0;
            this.txtboxSenha.Size = new System.Drawing.Size(130, 23);
            this.txtboxSenha.TabIndex = 1;
            this.txtboxSenha.TabStop = false;
            this.txtboxSenha.UseSystemPasswordChar = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Depth = 0;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(79, 122);
            this.lblLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 19);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Depth = 0;
            this.lblSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(75, 164);
            this.lblSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // btnAcessar
            // 
            this.btnAcessar.AutoSize = true;
            this.btnAcessar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcessar.Depth = 0;
            this.btnAcessar.Icon = null;
            this.btnAcessar.Location = new System.Drawing.Point(145, 222);
            this.btnAcessar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Primary = true;
            this.btnAcessar.Size = new System.Drawing.Size(81, 36);
            this.btnAcessar.TabIndex = 4;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtboxSenha);
            this.Controls.Add(this.txtboxLogin);
            this.Name = "FormLogin";
            this.Text = "Pro Reader";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Enter += new System.EventHandler(this.btnAcessar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxSenha;
        private MaterialSkin.Controls.MaterialLabel lblLogin;
        private MaterialSkin.Controls.MaterialLabel lblSenha;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcessar;
    }
}