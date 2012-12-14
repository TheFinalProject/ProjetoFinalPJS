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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Rafael ", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Felipe", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Linkin Park",
            "10/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iron Maiden",
            "10/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nirvana",
            "25/10/2012",
            "30/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Beatles",
            "30/10/2012"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.timer_Relogio = new System.Windows.Forms.Timer(this.components);
            this.label_login = new System.Windows.Forms.Label();
            this.listView_Devolulcoes = new System.Windows.Forms.ListView();
            this.Devoluções = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Ferramentas = new System.Windows.Forms.Label();
            this.textBox_Mubox = new System.Windows.Forms.TextBox();
            this.button_Consultas = new System.Windows.Forms.Button();
            this.panel_Relogio = new System.Windows.Forms.Panel();
            this.label_Hora = new System.Windows.Forms.Label();
            this.label_DiaDaSemana = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.panel_Configuraçoes = new System.Windows.Forms.Panel();
            this.pictureBox_Sair = new System.Windows.Forms.PictureBox();
            this.pictureBox_ferramentas = new System.Windows.Forms.PictureBox();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.button_Emprestimos = new System.Windows.Forms.Button();
            this.button_Musicas = new System.Windows.Forms.Button();
            this.button_MediaPlayer = new System.Windows.Forms.Button();
            this.button_Amigos = new System.Windows.Forms.Button();
            this.button_Agenda = new System.Windows.Forms.Button();
            this.button_Mubox = new System.Windows.Forms.Button();
            this.label_Sair = new System.Windows.Forms.Label();
            this.panel_Relogio.SuspendLayout();
            this.panel_Configuraçoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ferramentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Relogio
            // 
            this.timer_Relogio.Enabled = true;
            this.timer_Relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_login
            // 
            this.label_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(98, 181);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(129, 13);
            this.label_login.TabIndex = 21;
            this.label_login.Text = "Consigurações de usuário";
            this.label_login.Visible = false;
            // 
            // listView_Devolulcoes
            // 
            this.listView_Devolulcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Devolulcoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Devoluções,
            this.Emprestimo});
            listViewGroup1.Header = "Rafael ";
            listViewGroup1.Name = "Rafael";
            listViewGroup1.Tag = "";
            listViewGroup2.Header = "Felipe";
            listViewGroup2.Name = "Felipe";
            this.listView_Devolulcoes.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup2;
            this.listView_Devolulcoes.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView_Devolulcoes.Location = new System.Drawing.Point(337, 409);
            this.listView_Devolulcoes.Name = "listView_Devolulcoes";
            this.listView_Devolulcoes.Size = new System.Drawing.Size(318, 175);
            this.listView_Devolulcoes.TabIndex = 30;
            this.listView_Devolulcoes.UseCompatibleStateImageBehavior = false;
            this.listView_Devolulcoes.View = System.Windows.Forms.View.Details;
            this.listView_Devolulcoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.listView_Devolulcoes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.listView_Devolulcoes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // Devoluções
            // 
            this.Devoluções.Text = "Devoluções";
            this.Devoluções.Width = 209;
            // 
            // Emprestimo
            // 
            this.Emprestimo.Text = "Emprestimo";
            this.Emprestimo.Width = 98;
            // 
            // label_Ferramentas
            // 
            this.label_Ferramentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Ferramentas.AutoSize = true;
            this.label_Ferramentas.BackColor = System.Drawing.Color.Transparent;
            this.label_Ferramentas.ForeColor = System.Drawing.Color.White;
            this.label_Ferramentas.Location = new System.Drawing.Point(98, 249);
            this.label_Ferramentas.Name = "label_Ferramentas";
            this.label_Ferramentas.Size = new System.Drawing.Size(108, 13);
            this.label_Ferramentas.TabIndex = 31;
            this.label_Ferramentas.Text = "Configurações Gerais";
            this.label_Ferramentas.Visible = false;
            // 
            // textBox_Mubox
            // 
            this.textBox_Mubox.Location = new System.Drawing.Point(138, 49);
            this.textBox_Mubox.Multiline = true;
            this.textBox_Mubox.Name = "textBox_Mubox";
            this.textBox_Mubox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Mubox.Size = new System.Drawing.Size(320, 175);
            this.textBox_Mubox.TabIndex = 33;
            this.textBox_Mubox.Text = resources.GetString("textBox_Mubox.Text");
            this.textBox_Mubox.Visible = false;
            this.textBox_Mubox.DoubleClick += new System.EventHandler(this.textBox_Mubox_DoubleClick);
            // 
            // button_Consultas
            // 
            this.button_Consultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Consultas.BackColor = System.Drawing.Color.Transparent;
            this.button_Consultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Consultas.BackgroundImage")));
            this.button_Consultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Consultas.FlatAppearance.BorderSize = 0;
            this.button_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultas.ForeColor = System.Drawing.Color.Transparent;
            this.button_Consultas.Location = new System.Drawing.Point(658, 228);
            this.button_Consultas.Name = "button_Consultas";
            this.button_Consultas.Size = new System.Drawing.Size(318, 175);
            this.button_Consultas.TabIndex = 13;
            this.button_Consultas.UseVisualStyleBackColor = false;
            this.button_Consultas.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Consultas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Consultas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Consultas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // panel_Relogio
            // 
            this.panel_Relogio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Relogio.BackgroundImage = global::AcervoMusical.Properties.Resources.data;
            this.panel_Relogio.Controls.Add(this.label_Hora);
            this.panel_Relogio.Controls.Add(this.label_DiaDaSemana);
            this.panel_Relogio.Controls.Add(this.label_Data);
            this.panel_Relogio.Location = new System.Drawing.Point(730, 458);
            this.panel_Relogio.Name = "panel_Relogio";
            this.panel_Relogio.Size = new System.Drawing.Size(245, 121);
            this.panel_Relogio.TabIndex = 14;
            this.panel_Relogio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.panel_Relogio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.panel_Relogio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // label_Hora
            // 
            this.label_Hora.AutoSize = true;
            this.label_Hora.BackColor = System.Drawing.Color.Transparent;
            this.label_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hora.ForeColor = System.Drawing.Color.White;
            this.label_Hora.Location = new System.Drawing.Point(6, 71);
            this.label_Hora.Name = "label_Hora";
            this.label_Hora.Size = new System.Drawing.Size(29, 31);
            this.label_Hora.TabIndex = 12;
            this.label_Hora.Text = "d";
            // 
            // label_DiaDaSemana
            // 
            this.label_DiaDaSemana.AutoSize = true;
            this.label_DiaDaSemana.BackColor = System.Drawing.Color.Transparent;
            this.label_DiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaDaSemana.ForeColor = System.Drawing.Color.White;
            this.label_DiaDaSemana.Location = new System.Drawing.Point(6, 40);
            this.label_DiaDaSemana.Name = "label_DiaDaSemana";
            this.label_DiaDaSemana.Size = new System.Drawing.Size(29, 31);
            this.label_DiaDaSemana.TabIndex = 11;
            this.label_DiaDaSemana.Text = "d";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.BackColor = System.Drawing.Color.Transparent;
            this.label_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Data.ForeColor = System.Drawing.Color.White;
            this.label_Data.Location = new System.Drawing.Point(6, 9);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(29, 31);
            this.label_Data.TabIndex = 10;
            this.label_Data.Text = "d";
            // 
            // panel_Configuraçoes
            // 
            this.panel_Configuraçoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Configuraçoes.BackColor = System.Drawing.Color.Transparent;
            this.panel_Configuraçoes.BackgroundImage = global::AcervoMusical.Properties.Resources.data;
            this.panel_Configuraçoes.Controls.Add(this.pictureBox_Sair);
            this.panel_Configuraçoes.Controls.Add(this.pictureBox_ferramentas);
            this.panel_Configuraçoes.Controls.Add(this.pictureBox_Login);
            this.panel_Configuraçoes.Location = new System.Drawing.Point(55, 134);
            this.panel_Configuraçoes.Name = "panel_Configuraçoes";
            this.panel_Configuraçoes.Size = new System.Drawing.Size(43, 311);
            this.panel_Configuraçoes.TabIndex = 27;
            this.panel_Configuraçoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.panel_Configuraçoes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.panel_Configuraçoes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // pictureBox_Sair
            // 
            this.pictureBox_Sair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Sair.BackgroundImage = global::AcervoMusical.Properties.Resources.messagebox_critical;
            this.pictureBox_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Sair.Location = new System.Drawing.Point(4, 172);
            this.pictureBox_Sair.Name = "pictureBox_Sair";
            this.pictureBox_Sair.Size = new System.Drawing.Size(33, 33);
            this.pictureBox_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Sair.TabIndex = 2;
            this.pictureBox_Sair.TabStop = false;
            this.pictureBox_Sair.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_Sair.MouseLeave += new System.EventHandler(this.Esconder_texto);
            this.pictureBox_Sair.MouseHover += new System.EventHandler(this.Mostrar_texto);
            // 
            // pictureBox_ferramentas
            // 
            this.pictureBox_ferramentas.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ferramentas.BackgroundImage = global::AcervoMusical.Properties.Resources.Ferramentas;
            this.pictureBox_ferramentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ferramentas.Location = new System.Drawing.Point(6, 102);
            this.pictureBox_ferramentas.Name = "pictureBox_ferramentas";
            this.pictureBox_ferramentas.Size = new System.Drawing.Size(33, 33);
            this.pictureBox_ferramentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ferramentas.TabIndex = 1;
            this.pictureBox_ferramentas.TabStop = false;
            this.pictureBox_ferramentas.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.pictureBox_ferramentas.MouseLeave += new System.EventHandler(this.Esconder_texto);
            this.pictureBox_ferramentas.MouseHover += new System.EventHandler(this.Mostrar_texto);
            // 
            // pictureBox_Login
            // 
            this.pictureBox_Login.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Login.BackgroundImage = global::AcervoMusical.Properties.Resources.login;
            this.pictureBox_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Login.Location = new System.Drawing.Point(5, 27);
            this.pictureBox_Login.Name = "pictureBox_Login";
            this.pictureBox_Login.Size = new System.Drawing.Size(33, 33);
            this.pictureBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Login.TabIndex = 0;
            this.pictureBox_Login.TabStop = false;
            this.pictureBox_Login.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.pictureBox_Login.MouseLeave += new System.EventHandler(this.Esconder_texto);
            this.pictureBox_Login.MouseHover += new System.EventHandler(this.Mostrar_texto);
            // 
            // button_Emprestimos
            // 
            this.button_Emprestimos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Emprestimos.BackColor = System.Drawing.Color.Transparent;
            this.button_Emprestimos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Emprestimos.BackgroundImage")));
            this.button_Emprestimos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Emprestimos.FlatAppearance.BorderSize = 0;
            this.button_Emprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Emprestimos.ForeColor = System.Drawing.Color.Transparent;
            this.button_Emprestimos.Location = new System.Drawing.Point(462, 50);
            this.button_Emprestimos.Name = "button_Emprestimos";
            this.button_Emprestimos.Size = new System.Drawing.Size(194, 175);
            this.button_Emprestimos.TabIndex = 29;
            this.button_Emprestimos.UseVisualStyleBackColor = false;
            this.button_Emprestimos.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Emprestimos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Emprestimos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Emprestimos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_Musicas
            // 
            this.button_Musicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Musicas.BackColor = System.Drawing.Color.Transparent;
            this.button_Musicas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Musicas.BackgroundImage")));
            this.button_Musicas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Musicas.FlatAppearance.BorderSize = 0;
            this.button_Musicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Musicas.ForeColor = System.Drawing.Color.Transparent;
            this.button_Musicas.Location = new System.Drawing.Point(660, 50);
            this.button_Musicas.Name = "button_Musicas";
            this.button_Musicas.Size = new System.Drawing.Size(315, 173);
            this.button_Musicas.TabIndex = 26;
            this.button_Musicas.UseVisualStyleBackColor = false;
            this.button_Musicas.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Musicas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Musicas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Musicas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_MediaPlayer
            // 
            this.button_MediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MediaPlayer.BackColor = System.Drawing.Color.Transparent;
            this.button_MediaPlayer.BackgroundImage = global::AcervoMusical.Properties.Resources.mediaplayer;
            this.button_MediaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_MediaPlayer.FlatAppearance.BorderSize = 0;
            this.button_MediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MediaPlayer.ForeColor = System.Drawing.Color.Transparent;
            this.button_MediaPlayer.Location = new System.Drawing.Point(138, 230);
            this.button_MediaPlayer.Name = "button_MediaPlayer";
            this.button_MediaPlayer.Size = new System.Drawing.Size(195, 175);
            this.button_MediaPlayer.TabIndex = 25;
            this.button_MediaPlayer.UseVisualStyleBackColor = false;
            this.button_MediaPlayer.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_MediaPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_MediaPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_MediaPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_Amigos
            // 
            this.button_Amigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Amigos.BackColor = System.Drawing.Color.Transparent;
            this.button_Amigos.BackgroundImage = global::AcervoMusical.Properties.Resources.amigos1;
            this.button_Amigos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Amigos.FlatAppearance.BorderSize = 0;
            this.button_Amigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Amigos.ForeColor = System.Drawing.Color.Transparent;
            this.button_Amigos.Location = new System.Drawing.Point(337, 228);
            this.button_Amigos.Name = "button_Amigos";
            this.button_Amigos.Size = new System.Drawing.Size(318, 175);
            this.button_Amigos.TabIndex = 24;
            this.button_Amigos.UseVisualStyleBackColor = false;
            this.button_Amigos.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Amigos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Amigos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Amigos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_Agenda
            // 
            this.button_Agenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Agenda.BackColor = System.Drawing.Color.Transparent;
            this.button_Agenda.BackgroundImage = global::AcervoMusical.Properties.Resources.agenda;
            this.button_Agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Agenda.FlatAppearance.BorderSize = 0;
            this.button_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Agenda.ForeColor = System.Drawing.Color.Transparent;
            this.button_Agenda.Location = new System.Drawing.Point(138, 409);
            this.button_Agenda.Name = "button_Agenda";
            this.button_Agenda.Size = new System.Drawing.Size(195, 175);
            this.button_Agenda.TabIndex = 23;
            this.button_Agenda.UseVisualStyleBackColor = false;
            this.button_Agenda.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Agenda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Agenda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Agenda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // button_Mubox
            // 
            this.button_Mubox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Mubox.BackColor = System.Drawing.Color.Transparent;
            this.button_Mubox.BackgroundImage = global::AcervoMusical.Properties.Resources.mubox;
            this.button_Mubox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Mubox.FlatAppearance.BorderSize = 0;
            this.button_Mubox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mubox.ForeColor = System.Drawing.Color.Transparent;
            this.button_Mubox.Location = new System.Drawing.Point(138, 49);
            this.button_Mubox.Name = "button_Mubox";
            this.button_Mubox.Size = new System.Drawing.Size(320, 175);
            this.button_Mubox.TabIndex = 22;
            this.button_Mubox.UseVisualStyleBackColor = false;
            this.button_Mubox.Click += new System.EventHandler(this.Abrir_Fomulario);
            this.button_Mubox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_MouseDown);
            this.button_Mubox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            this.button_Mubox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_MouseUp);
            // 
            // label_Sair
            // 
            this.label_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Sair.AutoSize = true;
            this.label_Sair.BackColor = System.Drawing.Color.Transparent;
            this.label_Sair.ForeColor = System.Drawing.Color.White;
            this.label_Sair.Location = new System.Drawing.Point(98, 317);
            this.label_Sair.Name = "label_Sair";
            this.label_Sair.Size = new System.Drawing.Size(25, 13);
            this.label_Sair.TabIndex = 34;
            this.label_Sair.Text = "Sair";
            this.label_Sair.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 632);
            this.Controls.Add(this.label_Sair);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_Mubox);
            this.Controls.Add(this.label_Ferramentas);
            this.Controls.Add(this.button_Consultas);
            this.Controls.Add(this.panel_Relogio);
            this.Controls.Add(this.listView_Devolulcoes);
            this.Controls.Add(this.panel_Configuraçoes);
            this.Controls.Add(this.button_Emprestimos);
            this.Controls.Add(this.button_Musicas);
            this.Controls.Add(this.button_MediaPlayer);
            this.Controls.Add(this.button_Amigos);
            this.Controls.Add(this.button_Agenda);
            this.Controls.Add(this.button_Mubox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mubox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel_Relogio.ResumeLayout(false);
            this.panel_Relogio.PerformLayout();
            this.panel_Configuraçoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Sair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ferramentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_Relogio;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.ListView listView_Devolulcoes;
        private System.Windows.Forms.ColumnHeader Devoluções;
        private System.Windows.Forms.ColumnHeader Emprestimo;
        private System.Windows.Forms.Panel panel_Configuraçoes;
        private System.Windows.Forms.Button button_Emprestimos;
        private System.Windows.Forms.Button button_Consultas;
        private System.Windows.Forms.Button button_Musicas;
        private System.Windows.Forms.Panel panel_Relogio;
        private System.Windows.Forms.Button button_MediaPlayer;
        private System.Windows.Forms.Button button_Amigos;
        private System.Windows.Forms.Button button_Agenda;
        private System.Windows.Forms.Button button_Mubox;
        private System.Windows.Forms.PictureBox pictureBox_ferramentas;
        private System.Windows.Forms.Label label_Ferramentas;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.TextBox textBox_Mubox;
        private System.Windows.Forms.PictureBox pictureBox_Sair;
        private System.Windows.Forms.Label label_Hora;
        private System.Windows.Forms.Label label_DiaDaSemana;
        private System.Windows.Forms.Label label_Sair;


    }
}