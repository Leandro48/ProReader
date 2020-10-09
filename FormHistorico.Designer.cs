namespace ProReader
{
    partial class FormHistorico
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.ListarHistorico = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(794, 329);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(630, 76);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsuario.TabIndex = 6;
            this.textBoxUsuario.Visible = false;
            // 
            // ListarHistorico
            // 
            this.ListarHistorico.AutoSize = true;
            this.ListarHistorico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ListarHistorico.Depth = 0;
            this.ListarHistorico.Icon = null;
            this.ListarHistorico.Location = new System.Drawing.Point(407, 67);
            this.ListarHistorico.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListarHistorico.Name = "ListarHistorico";
            this.ListarHistorico.Primary = true;
            this.ListarHistorico.Size = new System.Drawing.Size(67, 36);
            this.ListarHistorico.TabIndex = 8;
            this.ListarHistorico.Text = "Listar";
            this.ListarHistorico.UseVisualStyleBackColor = true;
            this.ListarHistorico.Click += new System.EventHandler(this.ListarHistorico_Click);
            // 
            // FormHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 448);
            this.Controls.Add(this.ListarHistorico);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHistorico";
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.FormHistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxUsuario;
        public MaterialSkin.Controls.MaterialRaisedButton ListarHistorico;
    }
}