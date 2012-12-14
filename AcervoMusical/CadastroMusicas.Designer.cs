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
            System.Windows.Forms.ListViewGroup listViewGroup26 = new System.Windows.Forms.ListViewGroup("Vinil", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup27 = new System.Windows.Forms.ListViewGroup("K7", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup28 = new System.Windows.Forms.ListViewGroup("CD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup29 = new System.Windows.Forms.ListViewGroup("DVD", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup30 = new System.Windows.Forms.ListViewGroup("Digital", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.button_Remover = new System.Windows.Forms.Button();
            this.textBox_BuscaMusica = new System.Windows.Forms.TextBox();
            this.label_AvisoAdicionar = new System.Windows.Forms.Label();
            this.comboBox_Classificacao = new System.Windows.Forms.ComboBox();
            this.panel_CadastroMusicas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Origem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel_CadastroMusicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Musicas
            // 
            this.textBox_Musicas.Location = new System.Drawing.Point(308, 96);
            this.textBox_Musicas.Name = "textBox_Musicas";
            this.textBox_Musicas.Size = new System.Drawing.Size(607, 20);
            this.textBox_Musicas.TabIndex = 1;
            this.textBox_Musicas.Visible = false;
            this.textBox_Musicas.Enter += new System.EventHandler(this.textBox_Musicas_Enter);
            // 
            // listView_Cadastro_Musicas
            // 
            this.listView_Cadastro_Musicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Musica,
            this.Album,
            this.Autor,
            this.Interprete,
            this.Classificacao,
            this.Observacao,
            this.Origem,
            this.DataCompra,
            this.DataAlbum});
            this.listView_Cadastro_Musicas.FullRowSelect = true;
            this.listView_Cadastro_Musicas.GridLines = true;
            listViewGroup26.Header = "Vinil";
            listViewGroup26.Name = "Vinil";
            listViewGroup27.Header = "K7";
            listViewGroup27.Name = "K7";
            listViewGroup28.Header = "CD";
            listViewGroup28.Name = "CD";
            listViewGroup29.Header = "DVD";
            listViewGroup29.Name = "DVD";
            listViewGroup30.Header = "Digital";
            listViewGroup30.Name = "Digital";
            this.listView_Cadastro_Musicas.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup26,
            listViewGroup27,
            listViewGroup28,
            listViewGroup29,
            listViewGroup30});
            this.listView_Cadastro_Musicas.Location = new System.Drawing.Point(9, 365);
            this.listView_Cadastro_Musicas.Name = "listView_Cadastro_Musicas";
            this.listView_Cadastro_Musicas.Size = new System.Drawing.Size(910, 259);
            this.listView_Cadastro_Musicas.TabIndex = 14;
            this.listView_Cadastro_Musicas.UseCompatibleStateImageBehavior = false;
            this.listView_Cadastro_Musicas.View = System.Windows.Forms.View.Details;
            this.listView_Cadastro_Musicas.Click += new System.EventHandler(this.listView_Cadastro_Musicas_Click_1);
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
            this.Autor.Width = 101;
            // 
            // Interprete
            // 
            this.Interprete.Text = "Interprete";
            this.Interprete.Width = 87;
            // 
            // Classificacao
            // 
            this.Classificacao.Text = "Classificação";
            this.Classificacao.Width = 79;
            // 
            // Observacao
            // 
            this.Observacao.Text = "Observação";
            this.Observacao.Width = 133;
            // 
            // dateTimePicker_DataCampra
            // 
            this.dateTimePicker_DataCampra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataCampra.Location = new System.Drawing.Point(707, 174);
            this.dateTimePicker_DataCampra.Name = "dateTimePicker_DataCampra";
            this.dateTimePicker_DataCampra.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker_DataCampra.TabIndex = 7;
            // 
            // dateTimePicker_DataAlbum
            // 
            this.dateTimePicker_DataAlbum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DataAlbum.Location = new System.Drawing.Point(563, 174);
            this.dateTimePicker_DataAlbum.Name = "dateTimePicker_DataAlbum";
            this.dateTimePicker_DataAlbum.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_DataAlbum.TabIndex = 6;
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
            this.comboBox_Midia.Location = new System.Drawing.Point(10, 96);
            this.comboBox_Midia.Name = "comboBox_Midia";
            this.comboBox_Midia.Size = new System.Drawing.Size(292, 21);
            this.comboBox_Midia.TabIndex = 0;
            this.comboBox_Midia.SelectedIndexChanged += new System.EventHandler(this.comboBox_Midia_SelectedIndexChanged);
            this.comboBox_Midia.Enter += new System.EventHandler(this.comboBox_Midia_Enter);
            // 
            // textBox_Album
            // 
            this.textBox_Album.Location = new System.Drawing.Point(603, 135);
            this.textBox_Album.Name = "textBox_Album";
            this.textBox_Album.Size = new System.Drawing.Size(315, 20);
            this.textBox_Album.TabIndex = 2;
            // 
            // textBox_Interprete
            // 
            this.textBox_Interprete.Location = new System.Drawing.Point(327, 135);
            this.textBox_Interprete.Name = "textBox_Interprete";
            this.textBox_Interprete.Size = new System.Drawing.Size(270, 20);
            this.textBox_Interprete.TabIndex = 5;
            this.textBox_Interprete.Enter += new System.EventHandler(this.textBox_Interprete_Enter);
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(678, 262);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.button_Adicionar.TabIndex = 10;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_Origem
            // 
            this.textBox_Origem.Location = new System.Drawing.Point(9, 174);
            this.textBox_Origem.Name = "textBox_Origem";
            this.textBox_Origem.Size = new System.Drawing.Size(548, 20);
            this.textBox_Origem.TabIndex = 3;
            // 
            // textBox_Observacao
            // 
            this.textBox_Observacao.Location = new System.Drawing.Point(9, 216);
            this.textBox_Observacao.MaxLength = 200;
            this.textBox_Observacao.Multiline = true;
            this.textBox_Observacao.Name = "textBox_Observacao";
            this.textBox_Observacao.Size = new System.Drawing.Size(906, 40);
            this.textBox_Observacao.TabIndex = 9;
            // 
            // textBox_Autor
            // 
            this.textBox_Autor.Location = new System.Drawing.Point(10, 135);
            this.textBox_Autor.Name = "textBox_Autor";
            this.textBox_Autor.Size = new System.Drawing.Size(311, 20);
            this.textBox_Autor.TabIndex = 4;
            this.textBox_Autor.Enter += new System.EventHandler(this.textBox_Autor_Enter);
            // 
            // label_Musica
            // 
            this.label_Musica.AutoSize = true;
            this.label_Musica.Location = new System.Drawing.Point(305, 79);
            this.label_Musica.Name = "label_Musica";
            this.label_Musica.Size = new System.Drawing.Size(45, 13);
            this.label_Musica.TabIndex = 60;
            this.label_Musica.Text = "*Música";
            this.label_Musica.Visible = false;
            // 
            // label_Observação
            // 
            this.label_Observação.AutoSize = true;
            this.label_Observação.Location = new System.Drawing.Point(7, 200);
            this.label_Observação.Name = "label_Observação";
            this.label_Observação.Size = new System.Drawing.Size(70, 13);
            this.label_Observação.TabIndex = 59;
            this.label_Observação.Text = "Observações";
            // 
            // label_Midia
            // 
            this.label_Midia.AutoSize = true;
            this.label_Midia.Location = new System.Drawing.Point(7, 79);
            this.label_Midia.Name = "label_Midia";
            this.label_Midia.Size = new System.Drawing.Size(77, 13);
            this.label_Midia.TabIndex = 58;
            this.label_Midia.Text = "*Tipo de Mídia";
            // 
            // label_Data_Album
            // 
            this.label_Data_Album.AutoSize = true;
            this.label_Data_Album.Location = new System.Drawing.Point(563, 158);
            this.label_Data_Album.Name = "label_Data_Album";
            this.label_Data_Album.Size = new System.Drawing.Size(77, 13);
            this.label_Data_Album.TabIndex = 57;
            this.label_Data_Album.Text = "Data do Álbum";
            // 
            // label_Data_Compra
            // 
            this.label_Data_Compra.AutoSize = true;
            this.label_Data_Compra.Location = new System.Drawing.Point(704, 158);
            this.label_Data_Compra.Name = "label_Data_Compra";
            this.label_Data_Compra.Size = new System.Drawing.Size(84, 13);
            this.label_Data_Compra.TabIndex = 56;
            this.label_Data_Compra.Text = "Data da Compra";
            // 
            // label_Classificacao
            // 
            this.label_Classificacao.AutoSize = true;
            this.label_Classificacao.Location = new System.Drawing.Point(837, 158);
            this.label_Classificacao.Name = "label_Classificacao";
            this.label_Classificacao.Size = new System.Drawing.Size(69, 13);
            this.label_Classificacao.TabIndex = 55;
            this.label_Classificacao.Text = "Classificação";
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Location = new System.Drawing.Point(7, 119);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(36, 13);
            this.label_Autor.TabIndex = 54;
            this.label_Autor.Text = "*Autor";
            // 
            // label_Album
            // 
            this.label_Album.AutoSize = true;
            this.label_Album.Location = new System.Drawing.Point(604, 119);
            this.label_Album.Name = "label_Album";
            this.label_Album.Size = new System.Drawing.Size(36, 13);
            this.label_Album.TabIndex = 3;
            this.label_Album.Text = "Álbum";
            // 
            // label_Interprete
            // 
            this.label_Interprete.AutoSize = true;
            this.label_Interprete.Location = new System.Drawing.Point(324, 119);
            this.label_Interprete.Name = "label_Interprete";
            this.label_Interprete.Size = new System.Drawing.Size(56, 13);
            this.label_Interprete.TabIndex = 52;
            this.label_Interprete.Text = "*Intérprete";
            // 
            // label_Origem_Compra
            // 
            this.label_Origem_Compra.AutoSize = true;
            this.label_Origem_Compra.Location = new System.Drawing.Point(7, 158);
            this.label_Origem_Compra.Name = "label_Origem_Compra";
            this.label_Origem_Compra.Size = new System.Drawing.Size(94, 13);
            this.label_Origem_Compra.TabIndex = 51;
            this.label_Origem_Compra.Text = "Origem da Compra";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(759, 262);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 11;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_BuscaMusica);
            this.groupBox1.Location = new System.Drawing.Point(9, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 64);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // button_Remover
            // 
            this.button_Remover.Enabled = false;
            this.button_Remover.Location = new System.Drawing.Point(840, 262);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(75, 23);
            this.button_Remover.TabIndex = 13;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // textBox_BuscaMusica
            // 
            this.textBox_BuscaMusica.Location = new System.Drawing.Point(6, 19);
            this.textBox_BuscaMusica.Name = "textBox_BuscaMusica";
            this.textBox_BuscaMusica.Size = new System.Drawing.Size(894, 20);
            this.textBox_BuscaMusica.TabIndex = 12;
            this.textBox_BuscaMusica.TextChanged += new System.EventHandler(this.textBox_BuscaMusica_TextChanged);
            // 
            // label_AvisoAdicionar
            // 
            this.label_AvisoAdicionar.AutoSize = true;
            this.label_AvisoAdicionar.ForeColor = System.Drawing.Color.Red;
            this.label_AvisoAdicionar.Location = new System.Drawing.Point(491, 267);
            this.label_AvisoAdicionar.Name = "label_AvisoAdicionar";
            this.label_AvisoAdicionar.Size = new System.Drawing.Size(35, 13);
            this.label_AvisoAdicionar.TabIndex = 79;
            this.label_AvisoAdicionar.Text = "label1";
            this.label_AvisoAdicionar.Visible = false;
            // 
            // comboBox_Classificacao
            // 
            this.comboBox_Classificacao.FormattingEnabled = true;
            this.comboBox_Classificacao.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_Classificacao.Location = new System.Drawing.Point(840, 174);
            this.comboBox_Classificacao.Name = "comboBox_Classificacao";
            this.comboBox_Classificacao.Size = new System.Drawing.Size(75, 21);
            this.comboBox_Classificacao.TabIndex = 8;
            // 
            // panel_CadastroMusicas
            // 
            this.panel_CadastroMusicas.Controls.Add(this.label1);
            this.panel_CadastroMusicas.Controls.Add(this.pictureBox1);
            this.panel_CadastroMusicas.Location = new System.Drawing.Point(1, 0);
            this.panel_CadastroMusicas.Name = "panel_CadastroMusicas";
            this.panel_CadastroMusicas.Size = new System.Drawing.Size(922, 63);
            this.panel_CadastroMusicas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(701, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO MÚSICAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcervoMusical.Properties.Resources.Musica;
            this.pictureBox1.Location = new System.Drawing.Point(8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Origem
            // 
            this.Origem.Text = "Origem da Compra";
            this.Origem.Width = 110;
            // 
            // DataCompra
            // 
            this.DataCompra.Text = "Data da Compra";
            this.DataCompra.Width = 95;
            // 
            // DataAlbum
            // 
            this.DataAlbum.Text = "Data do Album";
            this.DataAlbum.Width = 100;
            // 
            // CadastroMusicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 636);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.panel_CadastroMusicas);
            this.Controls.Add(this.comboBox_Classificacao);
            this.Controls.Add(this.label_AvisoAdicionar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 778);
            this.Name = "CadastroMusicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Músicas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroMusicas_FormClosing);
            this.Load += new System.EventHandler(this.CadastroMusicas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_CadastroMusicas.ResumeLayout(false);
            this.panel_CadastroMusicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.TextBox textBox_BuscaMusica;
        private System.Windows.Forms.Label label_AvisoAdicionar;
        private System.Windows.Forms.ComboBox comboBox_Classificacao;
        private System.Windows.Forms.Panel panel_CadastroMusicas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Origem;
        private System.Windows.Forms.ColumnHeader DataCompra;
        private System.Windows.Forms.ColumnHeader DataAlbum;



    }
}