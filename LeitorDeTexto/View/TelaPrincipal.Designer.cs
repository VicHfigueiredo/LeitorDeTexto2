
namespace LeitorDeTexto.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btnLer = new System.Windows.Forms.Button();
            this.ltbLeitor = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLer
            // 
            this.btnLer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLer.Location = new System.Drawing.Point(152, 74);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(509, 28);
            this.btnLer.TabIndex = 0;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // ltbLeitor
            // 
            this.ltbLeitor.FormattingEnabled = true;
            this.ltbLeitor.ItemHeight = 15;
            this.ltbLeitor.Location = new System.Drawing.Point(41, 137);
            this.ltbLeitor.Name = "ltbLeitor";
            this.ltbLeitor.Size = new System.Drawing.Size(712, 274);
            this.ltbLeitor.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(195, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(437, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Leitor de texto com informações delimitadas";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(808, 468);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ltbLeitor);
            this.Controls.Add(this.btnLer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = " Leitor de Texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.ListBox ltbLeitor;
        private System.Windows.Forms.Label lblTitulo;
    }
}