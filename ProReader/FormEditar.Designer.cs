namespace ProReader
{
    partial class FormEditar
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
            this.richTextBoxLocal = new System.Windows.Forms.RichTextBox();
            this.salvarTextoWeb = new MaterialSkin.Controls.MaterialRaisedButton();
            this.richTextBoxWeb = new System.Windows.Forms.RichTextBox();
            this.salvarTextoLocal = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBoxCaminho = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxLocal
            // 
            this.richTextBoxLocal.Location = new System.Drawing.Point(12, 90);
            this.richTextBoxLocal.Name = "richTextBoxLocal";
            this.richTextBoxLocal.Size = new System.Drawing.Size(776, 388);
            this.richTextBoxLocal.TabIndex = 1;
            this.richTextBoxLocal.Text = "";
            this.richTextBoxLocal.Visible = false;
            // 
            // salvarTextoWeb
            // 
            this.salvarTextoWeb.AutoSize = true;
            this.salvarTextoWeb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.salvarTextoWeb.Depth = 0;
            this.salvarTextoWeb.Icon = null;
            this.salvarTextoWeb.Location = new System.Drawing.Point(670, 484);
            this.salvarTextoWeb.MouseState = MaterialSkin.MouseState.HOVER;
            this.salvarTextoWeb.Name = "salvarTextoWeb";
            this.salvarTextoWeb.Primary = true;
            this.salvarTextoWeb.Size = new System.Drawing.Size(118, 36);
            this.salvarTextoWeb.TabIndex = 2;
            this.salvarTextoWeb.Text = "Salvar texto";
            this.salvarTextoWeb.UseVisualStyleBackColor = true;
            this.salvarTextoWeb.Visible = false;
            this.salvarTextoWeb.Click += new System.EventHandler(this.salvarTextoWeb_Click);
            // 
            // richTextBoxWeb
            // 
            this.richTextBoxWeb.Location = new System.Drawing.Point(12, 90);
            this.richTextBoxWeb.Name = "richTextBoxWeb";
            this.richTextBoxWeb.Size = new System.Drawing.Size(776, 388);
            this.richTextBoxWeb.TabIndex = 3;
            this.richTextBoxWeb.Text = "";
            this.richTextBoxWeb.Visible = false;
            // 
            // salvarTextoLocal
            // 
            this.salvarTextoLocal.AutoSize = true;
            this.salvarTextoLocal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.salvarTextoLocal.Depth = 0;
            this.salvarTextoLocal.Icon = null;
            this.salvarTextoLocal.Location = new System.Drawing.Point(670, 484);
            this.salvarTextoLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.salvarTextoLocal.Name = "salvarTextoLocal";
            this.salvarTextoLocal.Primary = true;
            this.salvarTextoLocal.Size = new System.Drawing.Size(118, 36);
            this.salvarTextoLocal.TabIndex = 4;
            this.salvarTextoLocal.Text = "Salvar texto";
            this.salvarTextoLocal.UseVisualStyleBackColor = true;
            this.salvarTextoLocal.Visible = false;
            this.salvarTextoLocal.Click += new System.EventHandler(this.salvarTextoLocal_Click);
            // 
            // textBoxCaminho
            // 
            this.textBoxCaminho.Location = new System.Drawing.Point(232, 485);
            this.textBoxCaminho.Name = "textBoxCaminho";
            this.textBoxCaminho.Size = new System.Drawing.Size(100, 20);
            this.textBoxCaminho.TabIndex = 5;
            this.textBoxCaminho.Visible = false;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(338, 485);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 6;
            this.textBoxUsuario.Visible = false;
            // 
            // FormEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxCaminho);
            this.Controls.Add(this.salvarTextoLocal);
            this.Controls.Add(this.richTextBoxWeb);
            this.Controls.Add(this.salvarTextoWeb);
            this.Controls.Add(this.richTextBoxLocal);
            this.Name = "FormEditar";
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.FormEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxLocal;
        public System.Windows.Forms.RichTextBox richTextBoxWeb;
        public MaterialSkin.Controls.MaterialRaisedButton salvarTextoLocal;
        public MaterialSkin.Controls.MaterialRaisedButton salvarTextoWeb;
        public System.Windows.Forms.TextBox textBoxCaminho;
        public System.Windows.Forms.TextBox textBoxUsuario;
    }
}