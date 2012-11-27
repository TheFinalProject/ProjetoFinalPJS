namespace AcervoMusical
{
    partial class Smtp
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "UOL",
            "smtp.uol.com.br"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hotmail",
            "smtp.live.com"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Gmail",
            "smtp.gmail.com"}, -1);
            this.listView_smtp = new System.Windows.Forms.ListView();
            this.Servidor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerSMTP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_smtp
            // 
            this.listView_smtp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Servidor,
            this.ServerSMTP});
            this.listView_smtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_smtp.GridLines = true;
            this.listView_smtp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listView_smtp.Location = new System.Drawing.Point(0, 0);
            this.listView_smtp.Name = "listView_smtp";
            this.listView_smtp.Size = new System.Drawing.Size(460, 485);
            this.listView_smtp.TabIndex = 1;
            this.listView_smtp.UseCompatibleStateImageBehavior = false;
            this.listView_smtp.View = System.Windows.Forms.View.Details;
            this.listView_smtp.SelectedIndexChanged += new System.EventHandler(this.listView_smtp_SelectedIndexChanged);
            this.listView_smtp.DoubleClick += new System.EventHandler(this.listView_smtp_DoubleClick);
            // 
            // Servidor
            // 
            this.Servidor.Text = "Servidor";
            this.Servidor.Width = 220;
            // 
            // ServerSMTP
            // 
            this.ServerSMTP.Text = "SMTP";
            this.ServerSMTP.Width = 233;
            // 
            // Smtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 485);
            this.Controls.Add(this.listView_smtp);
            this.Name = "Smtp";
            this.Text = "Smtp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_smtp;
        private System.Windows.Forms.ColumnHeader Servidor;
        private System.Windows.Forms.ColumnHeader ServerSMTP;
    }
}