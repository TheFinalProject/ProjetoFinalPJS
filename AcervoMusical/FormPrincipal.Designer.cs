namespace AcervoMusical
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Musicas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Amigos = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Musicas,
            this.toolStripButton_Amigos,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 71);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Musicas
            // 
            this.toolStripButton_Musicas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Musicas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Musicas.Image")));
            this.toolStripButton_Musicas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Musicas.Name = "toolStripButton_Musicas";
            this.toolStripButton_Musicas.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton_Musicas.Text = "Música";
            this.toolStripButton_Musicas.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton_Amigos
            // 
            this.toolStripButton_Amigos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Amigos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Amigos.Image")));
            this.toolStripButton_Amigos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Amigos.Name = "toolStripButton_Amigos";
            this.toolStripButton_Amigos.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton_Amigos.Text = "Amigos";
            this.toolStripButton_Amigos.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 68);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 746);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Musicas;
        private System.Windows.Forms.ToolStripButton toolStripButton_Amigos;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}