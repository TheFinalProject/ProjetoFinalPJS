namespace AcervoMusical
{
    partial class CadastroMusicas
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
            this.textBox_Musicas = new System.Windows.Forms.TextBox();
            this.listView_Cadastro_Musicas = new System.Windows.Forms.ListView();
            this.Musica = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Interprete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Classificacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Observacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_DataCampra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DataAlbum = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Midia = new System.Windows.Forms.ComboBox();
            this.textBox_Album = new System.Windows.Forms.TextBox();
            this.textBox_Interprete = new System.Windows.Forms.TextBox();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.textBox_Origem = new System.Windows.Forms.TextBox();
            this.textBox_Classificação = new System.Windows.Forms.TextBox();
            this.textBox_Observacao = new System.Windows.Forms.TextBox();
            this.textBox_Autor = new System.Windows.Forms.TextBox();
            this.label_Musica = new System.Windows.Forms.Label();
            this.label_Observação = new System.Windows.Forms.Label();
            this.label_Midia = new System.Windows.Forms.Label();
            this.label_Data_Album = new System.Windows.Forms.Label();
            this.label_Data_Compra = new System.Windows.Forms.Label();
            this.label_Classificacao = new System.Windows.Forms.Label();
            this.label_Autor = new System.Windows.Forms.Label();
            this.label_Album = new System.Windows.Forms.Label();
            this.label_Interprete = new System.Windows.Forms.Label();
            this.label_Origem_Compra = new System.Windows.Forms.Label();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Editar = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Musicas
            // 
            this.textBox_Musicas.Location = new System.Drawing.Point(139, 26);
            this.textBox_Musicas.Name = "textBox_Musicas";
            this.textBox_Musicas.Size = new System.Drawing.Size(518, 20);
            this.textBox_Musicas.TabIndex = 74;
            this.textBox_Musicas.Visible = false;
            // 
            // listView_Cadastro_Musicas
            // 
            this.listView_Cadastro_Musicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Musica,
            this.Album,
            this.Autor,
            this.Interprete,
            this.Classificacao,
            this.Observacao});
            listViewGroup1.Header = "Vinil";
            listViewGroup1.Name = "Vinil";
            listViewGroup2.Header = "K7";
            listViewGroup2.Name = "K7";
            listViewGroup3.Header = "CD";
            listViewGroup3.Name = "CD";
            listViewGroup4.Header = "DVD";
            listViewGroup4.Name = "DVD";
            listViewGroup5.Header = "Digital";
            listViewGroup5.Name = "Digital";
            this.listView_Cadastro_Musicas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            this.listView_Cadastro_Musicas.Location = new System.Drawing.Point(12, 344);
            this.listView_Cadastro_Musicas.Name = "listView_Cadastro_Musicas";
            this.listView_Cadastro_Musicas.Size = new System.Drawing.Size(645, 206);
            this.listView_Cadastro_Musicas.TabIndex = 72;
            this.listView_Cadastro_Musicas.UseCompatibleStateImageBehavior = false;
            this.listView_Cadastro_Musicas.View = System.Windows.Forms.View.Details;
            // 
            // Musica
            // 
            this.Musica.Text = "Música";
            this.Musica.Width = 121;
            // 
            // Album
            // 
            this.Album.Text = "Álbum";
            this.Album.Width = 83;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 87;
            // 
            // Interprete
            // 
            this.Interprete.Text = "Interprete";
            this.Interprete.Width = 87;
            // 
            // Classificacao
            // 
            this.Classificacao.Text = "Classificação";
            this.Classificacao.Width = 91;
            // 
            // Observacao
            // 
            this.Observacao.Text = "Observação";
            this.Observacao.Width = 170;
            // 
            // dateTimePicker_DataCampra
            // 
            this.dateTimePicker_DataCampra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataCampra.Location = new System.Drawing.Point(12, 143);
            this.dateTimePicker_DataCampra.Name = "dateTimePicker_DataCampra";
            this.dateTimePicker_DataCampra.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_DataCampra.TabIndex = 71;
            // 
            // dateTimePicker_DataAlbum
            // 
            this.dateTimePicker_DataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataAlbum.Location = new System.Drawing.Point(557, 104);
            this.dateTimePicker_DataAlbum.Name = "dateTimePicker_DataAlbum";
            this.dateTimePicker_DataAlbum.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_DataAlbum.TabIndex = 70;
            // 
            // comboBox_Midia
            // 
            this.comboBox_Midia.FormattingEnabled = true;
            this.comboBox_Midia.Items.AddRange(new object[] {
            "Vinil",
            "K7",
            "CD",
            "DVD",
            "Digital"});
            this.comboBox_Midia.Location = new System.Drawing.Point(12, 25);
            this.comboBox_Midia.Name = "comboBox_Midia";
            this.comboBox_Midia.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Midia.TabIndex = 69;
            this.comboBox_Midia.SelectedIndexChanged += new System.EventHandler(this.comboBox_Midia_SelectedIndexChanged);
            // 
            // textBox_Album
            // 
            this.textBox_Album.Location = new System.Drawing.Point(12, 65);
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(645, 20);
            this.textBox_Album.TabIndex = 68;
            // 
            // textBox_Interprete
            // 
            this.textBox_Interprete.Location = new System.Drawing.Point(283, 104);
            this.textBox_Interprete.Name = "textBox_Interprete";
            this.textBox_Interprete.Size = new System.Drawing.Size(268, 20);
            this.textBox_Interprete.TabIndex = 67;
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(501, 228);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_Adicionar.TabIndex = 73;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_Origem
            // 
            this.textBox_Origem.Location = new System.Drawing.Point(118, 143);
            this.textBox_Origem.Name = "textBox_Origem";
            this.textBox_Origem.Size = new System.Drawing.Size(327, 20);
            this.textBox_Origem.TabIndex = 66;
            // 
            // textBox_Classificação
            // 
            this.textBox_Classificação.Location = new System.Drawing.Point(451, 143);
            this.textBox_Classificação.Name = "textBox_Classificação";
            this.textBox_Classificação.Size = new System.Drawing.Size(100, 20);
            this.textBox_Classificação.TabIndex = 65;
            // 
            // textBox_Observacao
            // 
            this.textBox_Observacao.Location = new System.Drawing.Point(12, 182);
            this.textBox_Observacao.MaxLength = 200;
            this.textBox_Observacao.Multiline = true;
            this.textBox_Observacao.Name = "textBox_Observacao";
            this.textBox_Observacao.Size = new System.Drawing.Size(645, 40);
            this.textBox_Observacao.TabIndex = 64;
            // 
            // textBox_Autor
            // 
            this.textBox_Autor.Location = new System.Drawing.Point(12, 104);
            this.textBox_Autor.Name = "textBox_Autor";
            this.textBox_Autor.Size = new System.Drawing.Size(265, 20);
            this.textBox_Autor.TabIndex = 63;
            // 
            // label_Musica
            // 
            this.label_Musica.AutoSize = true;
            this.label_Musica.Location = new System.Drawing.Point(136, 9);
            this.label_Musica.Name = "label_Musica";
            this.label_Musica.Size = new System.Drawing.Size(41, 13);
            this.label_Musica.TabIndex = 60;
            this.label_Musica.Text = "Música";
            this.label_Musica.Visible = false;
            // 
            // label_Observação
            // 
            this.label_Observação.AutoSize = true;
            this.label_Observação.Location = new System.Drawing.Point(13, 166);
            this.label_Observação.Name = "label_Observação";
            this.label_Observação.Size = new System.Drawing.Size(70, 13);
            this.label_Observação.TabIndex = 59;
            this.label_Observação.Text = "Observações";
            // 
            // label_Midia
            // 
            this.label_Midia.AutoSize = true;
            this.label_Midia.Location = new System.Drawing.Point(9, 9);
            this.label_Midia.Name = "label_Midia";
            this.label_Midia.Size = new System.Drawing.Size(73, 13);
            this.label_Midia.TabIndex = 58;
            this.label_Midia.Text = "Tipo de Mídia";
            // 
            // label_Data_Album
            // 
            this.label_Data_Album.AutoSize = true;
            this.label_Data_Album.Location = new System.Drawing.Point(554, 88);
            this.label_Data_Album.Name = "label_Data_Album";
            this.label_Data_Album.Size = new System.Drawing.Size(77, 13);
            this.label_Data_Album.TabIndex = 57;
            this.label_Data_Album.Text = "Data do Album";
            // 
            // label_Data_Compra
            // 
            this.label_Data_Compra.AutoSize = true;
            this.label_Data_Compra.Location = new System.Drawing.Point(9, 127);
            this.label_Data_Compra.Name = "label_Data_Compra";
            this.label_Data_Compra.Size = new System.Drawing.Size(84, 13);
            this.label_Data_Compra.TabIndex = 56;
            this.label_Data_Compra.Text = "Data da Compra";
            // 
            // label_Classificacao
            // 
            this.label_Classificacao.AutoSize = true;
            this.label_Classificacao.Location = new System.Drawing.Point(448, 127);
            this.label_Classificacao.Name = "label_Classificacao";
            this.label_Classificacao.Size = new System.Drawing.Size(69, 13);
            this.label_Classificacao.TabIndex = 55;
            this.label_Classificacao.Text = "Classificação";
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Location = new System.Drawing.Point(9, 88);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(32, 13);
            this.label_Autor.TabIndex = 54;
            this.label_Autor.Text = "Autor";
            // 
            // label_Album
            // 
            this.label_Album.AutoSize = true;
            this.label_Album.Location = new System.Drawing.Point(13, 49);
            this.label_Album.Name = "label_Album";
            this.label_Album.Size = new System.Drawing.Size(36, 13);
            this.label_Album.TabIndex = 53;
            this.label_Album.Text = "Album";
            // 
            // label_Interprete
            // 
            this.label_Interprete.AutoSize = true;
            this.label_Interprete.Location = new System.Drawing.Point(280, 88);
            this.label_Interprete.Name = "label_Interprete";
            this.label_Interprete.Size = new System.Drawing.Size(52, 13);
            this.label_Interprete.TabIndex = 52;
            this.label_Interprete.Text = "Interprete";
            // 
            // label_Origem_Compra
            // 
            this.label_Origem_Compra.AutoSize = true;
            this.label_Origem_Compra.Location = new System.Drawing.Point(118, 127);
            this.label_Origem_Compra.Name = "label_Origem_Compra";
            this.label_Origem_Compra.Size = new System.Drawing.Size(94, 13);
            this.label_Origem_Compra.TabIndex = 51;
            this.label_Origem_Compra.Text = "Origem da Compra";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(582, 228);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 75;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Editar);
            this.groupBox1.Controls.Add(this.button_Remover);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 49);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remover / Editar";
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(561, 17);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(75, 23);
            this.button_Editar.TabIndex = 78;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(480, 17);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(75, 23);
            this.button_Remover.TabIndex = 77;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 20);
            this.textBox1.TabIndex = 77;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CadastroMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.textBox_Musicas);
            this.Controls.Add(this.listView_Cadastro_Musicas);
            this.Controls.Add(this.dateTimePicker_DataCampra);
            this.Controls.Add(this.dateTimePicker_DataAlbum);
            this.Controls.Add(this.comboBox_Midia);
            this.Controls.Add(this.textBox_Album);
            this.Controls.Add(this.textBox_Interprete);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.textBox_Origem);
            this.Controls.Add(this.textBox_Classificação);
            this.Controls.Add(this.textBox_Observacao);
            this.Controls.Add(this.textBox_Autor);
            this.Controls.Add(this.label_Musica);
            this.Controls.Add(this.label_Observação);
            this.Controls.Add(this.label_Midia);
            this.Controls.Add(this.label_Data_Album);
            this.Controls.Add(this.label_Data_Compra);
            this.Controls.Add(this.label_Classificacao);
            this.Controls.Add(this.label_Autor);
            this.Controls.Add(this.label_Album);
            this.Controls.Add(this.label_Interprete);
            this.Controls.Add(this.label_Origem_Compra);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "CadastroMusicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Músicas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroMusicas_FormClosing);
            this.Load += new System.EventHandler(this.CadastroMusicas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Musicas;
        private System.Windows.Forms.ListView listView_Cadastro_Musicas;
        private System.Windows.Forms.ColumnHeader Musica;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Interprete;
        private System.Windows.Forms.ColumnHeader Classificacao;
        private System.Windows.Forms.ColumnHeader Observacao;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataCampra;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DataAlbum;
        private System.Windows.Forms.ComboBox comboBox_Midia;
        private System.Windows.Forms.TextBox textBox_Album;
        private System.Windows.Forms.TextBox textBox_Interprete;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.TextBox textBox_Origem;
        private System.Windows.Forms.TextBox textBox_Classificação;
        private System.Windows.Forms.TextBox textBox_Observacao;
        private System.Windows.Forms.TextBox textBox_Autor;
        private System.Windows.Forms.Label label_Musica;
        private System.Windows.Forms.Label label_Observação;
        private System.Windows.Forms.Label label_Midia;
        private System.Windows.Forms.Label label_Data_Album;
        private System.Windows.Forms.Label label_Data_Compra;
        private System.Windows.Forms.Label label_Classificacao;
        private System.Windows.Forms.Label label_Autor;
        private System.Windows.Forms.Label label_Album;
        private System.Windows.Forms.Label label_Interprete;
        private System.Windows.Forms.Label label_Origem_Compra;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.TextBox textBox1;



    }
}