namespace AcervoMusical
{
    partial class Emprestimos
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
            this.comboBox_NomeAmigos = new System.Windows.Forms.ComboBox();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_NomeMusicas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NomeAmigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeAblum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataEmprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_emprestimo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Emprestar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_ConsultarAlbum = new System.Windows.Forms.Button();
            this.button_ConsultarAmigos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_NomeAmigos
            // 
            this.comboBox_NomeAmigos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_NomeAmigos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_NomeAmigos.FormattingEnabled = true;
            this.comboBox_NomeAmigos.Location = new System.Drawing.Point(10, 51);
            this.comboBox_NomeAmigos.Name = "comboBox_NomeAmigos";
            this.comboBox_NomeAmigos.Size = new System.Drawing.Size(201, 21);
            this.comboBox_NomeAmigos.TabIndex = 0;
            this.comboBox_NomeAmigos.SelectedIndexChanged += new System.EventHandler(this.comboBox_NomeAmigos_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(10, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(67, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome Amigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Album";
            // 
            // comboBox_NomeMusicas
            // 
            this.comboBox_NomeMusicas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_NomeMusicas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_NomeMusicas.FormattingEnabled = true;
            this.comboBox_NomeMusicas.Location = new System.Drawing.Point(295, 51);
            this.comboBox_NomeMusicas.Name = "comboBox_NomeMusicas";
            this.comboBox_NomeMusicas.Size = new System.Drawing.Size(298, 21);
            this.comboBox_NomeMusicas.TabIndex = 2;
            this.comboBox_NomeMusicas.SelectedIndexChanged += new System.EventHandler(this.comboBox_NomeMusicas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emprestar";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeAmigo,
            this.NomeAblum,
            this.DataEmprestimo});
            this.listView1.Location = new System.Drawing.Point(7, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(781, 316);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NomeAmigo
            // 
            this.NomeAmigo.Text = "Nome Amigo";
            this.NomeAmigo.Width = 275;
            // 
            // NomeAblum
            // 
            this.NomeAblum.Text = "Nome Album";
            this.NomeAblum.Width = 304;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.Text = "Data Emprestimo";
            this.DataEmprestimo.Width = 175;
            // 
            // dateTimePicker_emprestimo
            // 
            this.dateTimePicker_emprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_emprestimo.Location = new System.Drawing.Point(673, 51);
            this.dateTimePicker_emprestimo.Name = "dateTimePicker_emprestimo";
            this.dateTimePicker_emprestimo.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_emprestimo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de emprestimo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 485);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_ConsultarAmigos);
            this.tabPage1.Controls.Add(this.button_ConsultarAlbum);
            this.tabPage1.Controls.Add(this.button_Emprestar);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox_NomeMusicas);
            this.tabPage1.Controls.Add(this.dateTimePicker_emprestimo);
            this.tabPage1.Controls.Add(this.comboBox_NomeAmigos);
            this.tabPage1.Controls.Add(this.Nome);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emprestimos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Emprestar
            // 
            this.button_Emprestar.Location = new System.Drawing.Point(713, 93);
            this.button_Emprestar.Name = "button_Emprestar";
            this.button_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.button_Emprestar.TabIndex = 8;
            this.button_Emprestar.Text = "Emprestar";
            this.button_Emprestar.UseVisualStyleBackColor = true;
            this.button_Emprestar.Click += new System.EventHandler(this.button_Emprestar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devoluções";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_ConsultarAlbum
            // 
            this.button_ConsultarAlbum.Location = new System.Drawing.Point(295, 78);
            this.button_ConsultarAlbum.Name = "button_ConsultarAlbum";
            this.button_ConsultarAlbum.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarAlbum.TabIndex = 9;
            this.button_ConsultarAlbum.Text = "Consultar";
            this.button_ConsultarAlbum.UseVisualStyleBackColor = true;
            this.button_ConsultarAlbum.Click += new System.EventHandler(this.button_ConsultarAlbum_Click);
            // 
            // button_ConsultarAmigos
            // 
            this.button_ConsultarAmigos.Location = new System.Drawing.Point(9, 78);
            this.button_ConsultarAmigos.Name = "button_ConsultarAmigos";
            this.button_ConsultarAmigos.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarAmigos.TabIndex = 10;
            this.button_ConsultarAmigos.Text = "Consultar";
            this.button_ConsultarAmigos.UseVisualStyleBackColor = true;
            this.button_ConsultarAmigos.Click += new System.EventHandler(this.button_ConsultarAmigos_Click);
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "Emprestimos";
            this.Load += new System.EventHandler(this.Emprestimos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_NomeAmigos;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_NomeMusicas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_emprestimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ColumnHeader NomeAmigo;
        private System.Windows.Forms.ColumnHeader NomeAblum;
        private System.Windows.Forms.ColumnHeader DataEmprestimo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Emprestar;
        private System.Windows.Forms.Button button_ConsultarAmigos;
        private System.Windows.Forms.Button button_ConsultarAlbum;
    }
}