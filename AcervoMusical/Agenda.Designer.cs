namespace AcervoMusical
{
    partial class Agenda
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
            this.listView_AgendaAmigos = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_BuscarAmigo = new System.Windows.Forms.Button();
            this.label_NomePesqAmigo = new System.Windows.Forms.Label();
            this.textBox_PesquisaAmigo = new System.Windows.Forms.TextBox();
            this.button_LimparPesqAmigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_AgendaAmigos
            // 
            this.listView_AgendaAmigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Telefone,
            this.Email});
            this.listView_AgendaAmigos.GridLines = true;
            this.listView_AgendaAmigos.Location = new System.Drawing.Point(12, 56);
            this.listView_AgendaAmigos.Name = "listView_AgendaAmigos";
            this.listView_AgendaAmigos.Size = new System.Drawing.Size(509, 423);
            this.listView_AgendaAmigos.TabIndex = 0;
            this.listView_AgendaAmigos.UseCompatibleStateImageBehavior = false;
            this.listView_AgendaAmigos.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 123;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 78;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 136;
            // 
            // button_BuscarAmigo
            // 
            this.button_BuscarAmigo.Location = new System.Drawing.Point(365, 27);
            this.button_BuscarAmigo.Name = "button_BuscarAmigo";
            this.button_BuscarAmigo.Size = new System.Drawing.Size(75, 23);
            this.button_BuscarAmigo.TabIndex = 2;
            this.button_BuscarAmigo.Text = "Buscar";
            this.button_BuscarAmigo.UseVisualStyleBackColor = true;
            this.button_BuscarAmigo.Click += new System.EventHandler(this.button_BuscarAmigo_Click);
            // 
            // label_NomePesqAmigo
            // 
            this.label_NomePesqAmigo.AutoSize = true;
            this.label_NomePesqAmigo.Location = new System.Drawing.Point(11, 13);
            this.label_NomePesqAmigo.Name = "label_NomePesqAmigo";
            this.label_NomePesqAmigo.Size = new System.Drawing.Size(38, 13);
            this.label_NomePesqAmigo.TabIndex = 3;
            this.label_NomePesqAmigo.Text = "Nome:";
            // 
            // textBox_PesquisaAmigo
            // 
            this.textBox_PesquisaAmigo.Location = new System.Drawing.Point(11, 30);
            this.textBox_PesquisaAmigo.Name = "textBox_PesquisaAmigo";
            this.textBox_PesquisaAmigo.Size = new System.Drawing.Size(330, 20);
            this.textBox_PesquisaAmigo.TabIndex = 4;
            // 
            // button_LimparPesqAmigo
            // 
            this.button_LimparPesqAmigo.Location = new System.Drawing.Point(446, 27);
            this.button_LimparPesqAmigo.Name = "button_LimparPesqAmigo";
            this.button_LimparPesqAmigo.Size = new System.Drawing.Size(75, 23);
            this.button_LimparPesqAmigo.TabIndex = 5;
            this.button_LimparPesqAmigo.Text = "Limpar";
            this.button_LimparPesqAmigo.UseVisualStyleBackColor = true;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 491);
            this.Controls.Add(this.button_LimparPesqAmigo);
            this.Controls.Add(this.textBox_PesquisaAmigo);
            this.Controls.Add(this.label_NomePesqAmigo);
            this.Controls.Add(this.button_BuscarAmigo);
            this.Controls.Add(this.listView_AgendaAmigos);
            this.MaximizeBox = false;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_AgendaAmigos;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button button_BuscarAmigo;
        private System.Windows.Forms.Label label_NomePesqAmigo;
        private System.Windows.Forms.TextBox textBox_PesquisaAmigo;
        private System.Windows.Forms.Button button_LimparPesqAmigo;
    }
}