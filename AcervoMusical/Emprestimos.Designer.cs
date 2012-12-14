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
            this.comboBox_TipoMidia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_Emprestimos = new System.Windows.Forms.ListView();
            this.NomeAmigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoMidia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataEmprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_emprestimo = new System.Windows.Forms.DateTimePicker();
            this.label_DataEmprestimo = new System.Windows.Forms.Label();
            this.textBox_PesquisarEmprestimo = new System.Windows.Forms.TextBox();
            this.label_Emprestados = new System.Windows.Forms.Label();
            this.button_ConsultarAmigos = new System.Windows.Forms.Button();
            this.button_ConsultarAlbum = new System.Windows.Forms.Button();
            this.button_Emprestar = new System.Windows.Forms.Button();
            this.panel_Emprestimos = new System.Windows.Forms.Panel();
            this.button_Devolver = new System.Windows.Forms.Button();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.label_TipoMidia = new System.Windows.Forms.Label();
            this.label_NomeAmigo = new System.Windows.Forms.Label();
            this.comboBox_NomeAlbum = new System.Windows.Forms.ComboBox();
            this.label_Album = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_Emprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_NomeAmigos
            // 
            this.comboBox_NomeAmigos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_NomeAmigos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_NomeAmigos.FormattingEnabled = true;
            this.comboBox_NomeAmigos.Location = new System.Drawing.Point(322, 129);
            this.comboBox_NomeAmigos.Name = "comboBox_NomeAmigos";
            this.comboBox_NomeAmigos.Size = new System.Drawing.Size(201, 21);
            this.comboBox_NomeAmigos.TabIndex = 3;
            this.comboBox_NomeAmigos.SelectedIndexChanged += new System.EventHandler(this.comboBox_NomeAmigos_SelectedIndexChanged);
            // 
            // comboBox_TipoMidia
            // 
            this.comboBox_TipoMidia.AutoCompleteCustomSource.AddRange(new string[] {
            "K7",
            "CD",
            "DVD",
            "Vinil"});
            this.comboBox_TipoMidia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_TipoMidia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_TipoMidia.Items.AddRange(new object[] {
            "K7",
            "CD",
            "DVD",
            "Vinil"});
            this.comboBox_TipoMidia.Location = new System.Drawing.Point(12, 131);
            this.comboBox_TipoMidia.Name = "comboBox_TipoMidia";
            this.comboBox_TipoMidia.Size = new System.Drawing.Size(201, 21);
            this.comboBox_TipoMidia.TabIndex = 1;
            this.comboBox_TipoMidia.SelectedIndexChanged += new System.EventHandler(this.comboBox_TipoMidia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emprestar Para :";
            // 
            // listView_Emprestimos
            // 
            this.listView_Emprestimos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomeAmigo,
            this.TipoMidia,
            this.NomeAlbum,
            this.DataEmprestimo});
            this.listView_Emprestimos.FullRowSelect = true;
            this.listView_Emprestimos.GridLines = true;
            this.listView_Emprestimos.Location = new System.Drawing.Point(9, 264);
            this.listView_Emprestimos.Name = "listView_Emprestimos";
            this.listView_Emprestimos.Size = new System.Drawing.Size(781, 339);
            this.listView_Emprestimos.TabIndex = 5;
            this.listView_Emprestimos.UseCompatibleStateImageBehavior = false;
            this.listView_Emprestimos.View = System.Windows.Forms.View.Details;
            this.listView_Emprestimos.Click += new System.EventHandler(this.listView_Emprestimos_Click);
            // 
            // NomeAmigo
            // 
            this.NomeAmigo.Text = "Nome do Amigo";
            this.NomeAmigo.Width = 249;
            // 
            // TipoMidia
            // 
            this.TipoMidia.Text = "Tipo de Midia";
            this.TipoMidia.Width = 192;
            // 
            // NomeAlbum
            // 
            this.NomeAlbum.Text = "Nome do Album";
            this.NomeAlbum.Width = 144;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.Text = "Data de Emprestimo";
            this.DataEmprestimo.Width = 191;
            // 
            // dateTimePicker_emprestimo
            // 
            this.dateTimePicker_emprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_emprestimo.Location = new System.Drawing.Point(678, 131);
            this.dateTimePicker_emprestimo.Name = "dateTimePicker_emprestimo";
            this.dateTimePicker_emprestimo.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_emprestimo.TabIndex = 4;
            // 
            // label_DataEmprestimo
            // 
            this.label_DataEmprestimo.AutoSize = true;
            this.label_DataEmprestimo.Location = new System.Drawing.Point(544, 134);
            this.label_DataEmprestimo.Name = "label_DataEmprestimo";
            this.label_DataEmprestimo.Size = new System.Drawing.Size(123, 13);
            this.label_DataEmprestimo.TabIndex = 7;
            this.label_DataEmprestimo.Text = "Emprestado na data de :";
            // 
            // textBox_PesquisarEmprestimo
            // 
            this.textBox_PesquisarEmprestimo.ForeColor = System.Drawing.Color.Silver;
            this.textBox_PesquisarEmprestimo.Location = new System.Drawing.Point(592, 238);
            this.textBox_PesquisarEmprestimo.Name = "textBox_PesquisarEmprestimo";
            this.textBox_PesquisarEmprestimo.Size = new System.Drawing.Size(198, 20);
            this.textBox_PesquisarEmprestimo.TabIndex = 12;
            this.textBox_PesquisarEmprestimo.Text = "Pesquisar";
            this.textBox_PesquisarEmprestimo.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox_PesquisarEmprestimo.TextChanged += new System.EventHandler(this.textBox_PesquisarEmprestimo_TextChanged);
            // 
            // label_Emprestados
            // 
            this.label_Emprestados.AutoSize = true;
            this.label_Emprestados.ForeColor = System.Drawing.Color.Red;
            this.label_Emprestados.Location = new System.Drawing.Point(9, 238);
            this.label_Emprestados.Name = "label_Emprestados";
            this.label_Emprestados.Size = new System.Drawing.Size(67, 13);
            this.label_Emprestados.TabIndex = 11;
            this.label_Emprestados.Text = "Nome Album";
            this.label_Emprestados.Visible = false;
            // 
            // button_ConsultarAmigos
            // 
            this.button_ConsultarAmigos.Location = new System.Drawing.Point(448, 233);
            this.button_ConsultarAmigos.Name = "button_ConsultarAmigos";
            this.button_ConsultarAmigos.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarAmigos.TabIndex = 10;
            this.button_ConsultarAmigos.Text = "Consultar";
            this.button_ConsultarAmigos.UseVisualStyleBackColor = true;
            this.button_ConsultarAmigos.Click += new System.EventHandler(this.button_ConsultarAmigos_Click);
            // 
            // button_ConsultarAlbum
            // 
            this.button_ConsultarAlbum.Location = new System.Drawing.Point(138, 201);
            this.button_ConsultarAlbum.Name = "button_ConsultarAlbum";
            this.button_ConsultarAlbum.Size = new System.Drawing.Size(75, 23);
            this.button_ConsultarAlbum.TabIndex = 9;
            this.button_ConsultarAlbum.Text = "Consultar";
            this.button_ConsultarAlbum.UseVisualStyleBackColor = true;
            this.button_ConsultarAlbum.Click += new System.EventHandler(this.button_ConsultarAlbum_Click);
            // 
            // button_Emprestar
            // 
            this.button_Emprestar.Location = new System.Drawing.Point(716, 168);
            this.button_Emprestar.Name = "button_Emprestar";
            this.button_Emprestar.Size = new System.Drawing.Size(75, 23);
            this.button_Emprestar.TabIndex = 5;
            this.button_Emprestar.Text = "Emprestar";
            this.button_Emprestar.UseVisualStyleBackColor = true;
            this.button_Emprestar.Click += new System.EventHandler(this.button_Emprestar_Click);
            // 
            // panel_Emprestimos
            // 
            this.panel_Emprestimos.Controls.Add(this.label1);
            this.panel_Emprestimos.Controls.Add(this.pictureBox1);
            this.panel_Emprestimos.Location = new System.Drawing.Point(1, 1);
            this.panel_Emprestimos.Name = "panel_Emprestimos";
            this.panel_Emprestimos.Size = new System.Drawing.Size(800, 60);
            this.panel_Emprestimos.TabIndex = 9;
            // 
            // button_Devolver
            // 
            this.button_Devolver.Enabled = false;
            this.button_Devolver.Location = new System.Drawing.Point(716, 197);
            this.button_Devolver.Name = "button_Devolver";
            this.button_Devolver.Size = new System.Drawing.Size(75, 23);
            this.button_Devolver.TabIndex = 13;
            this.button_Devolver.Text = "Devolver";
            this.button_Devolver.UseVisualStyleBackColor = true;
            this.button_Devolver.Click += new System.EventHandler(this.button_Devolver_Click);
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Enabled = false;
            this.textBox_Tel.Location = new System.Drawing.Point(322, 170);
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(201, 20);
            this.textBox_Tel.TabIndex = 15;
            // 
            // label_TipoMidia
            // 
            this.label_TipoMidia.AutoSize = true;
            this.label_TipoMidia.Location = new System.Drawing.Point(9, 112);
            this.label_TipoMidia.Name = "label_TipoMidia";
            this.label_TipoMidia.Size = new System.Drawing.Size(71, 13);
            this.label_TipoMidia.TabIndex = 3;
            this.label_TipoMidia.Text = "Tipo de Midia";
            // 
            // label_NomeAmigo
            // 
            this.label_NomeAmigo.AutoSize = true;
            this.label_NomeAmigo.Location = new System.Drawing.Point(322, 113);
            this.label_NomeAmigo.Name = "label_NomeAmigo";
            this.label_NomeAmigo.Size = new System.Drawing.Size(67, 13);
            this.label_NomeAmigo.TabIndex = 1;
            this.label_NomeAmigo.Text = "Nome Amigo";
            // 
            // comboBox_NomeAlbum
            // 
            this.comboBox_NomeAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_NomeAlbum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_NomeAlbum.FormattingEnabled = true;
            this.comboBox_NomeAlbum.Location = new System.Drawing.Point(12, 173);
            this.comboBox_NomeAlbum.Name = "comboBox_NomeAlbum";
            this.comboBox_NomeAlbum.Size = new System.Drawing.Size(201, 21);
            this.comboBox_NomeAlbum.TabIndex = 2;
            this.comboBox_NomeAlbum.Text = "Selecione um tipo de Midia";
            this.comboBox_NomeAlbum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_Album
            // 
            this.label_Album.AutoSize = true;
            this.label_Album.Location = new System.Drawing.Point(9, 155);
            this.label_Album.Name = "label_Album";
            this.label_Album.Size = new System.Drawing.Size(36, 13);
            this.label_Album.TabIndex = 18;
            this.label_Album.Text = "Album";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Enabled = false;
            this.textBox_Email.Location = new System.Drawing.Point(322, 211);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(201, 20);
            this.textBox_Email.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcervoMusical.Properties.Resources.Setas;
            this.pictureBox1.Location = new System.Drawing.Point(11, -20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(538, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "EMPRESTIMOS E DEVOLUCOES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Telefone";
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 615);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Album);
            this.Controls.Add(this.comboBox_NomeAlbum);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.button_Devolver);
            this.Controls.Add(this.textBox_PesquisarEmprestimo);
            this.Controls.Add(this.panel_Emprestimos);
            this.Controls.Add(this.comboBox_NomeAmigos);
            this.Controls.Add(this.label_Emprestados);
            this.Controls.Add(this.dateTimePicker_emprestimo);
            this.Controls.Add(this.comboBox_TipoMidia);
            this.Controls.Add(this.label_DataEmprestimo);
            this.Controls.Add(this.button_ConsultarAmigos);
            this.Controls.Add(this.button_Emprestar);
            this.Controls.Add(this.label_TipoMidia);
            this.Controls.Add(this.label_NomeAmigo);
            this.Controls.Add(this.listView_Emprestimos);
            this.Controls.Add(this.button_ConsultarAlbum);
            this.Controls.Add(this.label2);
            this.Name = "Emprestimos";
            this.Load += new System.EventHandler(this.Emprestimos_Load);
            this.panel_Emprestimos.ResumeLayout(false);
            this.panel_Emprestimos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_NomeAmigos;
        private System.Windows.Forms.ComboBox comboBox_TipoMidia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_Emprestimos;
        private System.Windows.Forms.DateTimePicker dateTimePicker_emprestimo;
        private System.Windows.Forms.Label label_DataEmprestimo;
        private System.Windows.Forms.ColumnHeader NomeAmigo;
        private System.Windows.Forms.ColumnHeader TipoMidia;
        private System.Windows.Forms.Button button_Emprestar;
        private System.Windows.Forms.Button button_ConsultarAmigos;
        private System.Windows.Forms.Button button_ConsultarAlbum;
        private System.Windows.Forms.ColumnHeader NomeAlbum;
        private System.Windows.Forms.TextBox textBox_PesquisarEmprestimo;
        private System.Windows.Forms.Label label_Emprestados;
        private System.Windows.Forms.Panel panel_Emprestimos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Devolver;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Label label_TipoMidia;
        private System.Windows.Forms.Label label_NomeAmigo;
        private System.Windows.Forms.ComboBox comboBox_NomeAlbum;
        private System.Windows.Forms.ColumnHeader DataEmprestimo;
        private System.Windows.Forms.Label label_Album;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}