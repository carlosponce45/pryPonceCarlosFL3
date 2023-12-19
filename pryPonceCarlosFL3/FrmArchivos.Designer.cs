namespace pryPonceCarlosFL3
{
    partial class FrmArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArchivos));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeViewArchivos = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 149);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // treeViewArchivos
            // 
            this.treeViewArchivos.Location = new System.Drawing.Point(26, 12);
            this.treeViewArchivos.Name = "treeViewArchivos";
            this.treeViewArchivos.Size = new System.Drawing.Size(434, 168);
            this.treeViewArchivos.TabIndex = 2;
            this.treeViewArchivos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewArchivos_AfterSelect);
            // 
            // FrmArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 358);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeViewArchivos);
            this.Name = "FrmArchivos";
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.FrmArchivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TreeView treeViewArchivos;
    }
}