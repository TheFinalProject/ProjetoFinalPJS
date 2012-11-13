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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Rafael ", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Felipe", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Linkin Park",
            "10/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Iron Maiden",
            "10/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nirvana",
            "25/10/2012",
            "30/10/2012"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Beatles",
            "30/10/2012"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_relogio = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Devoluções = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Emprestimo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_DiaSemana = new System.Windows.Forms.Label();
            this.label_Data = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelRelogio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelSemana = new System.Windows.Forms.Label();
            this.button_MediaPlayer = new System.Windows.Forms.Button();
            this.button_Agenda = new System.Windows.Forms.Button();
            this.button_Mubox = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Login = new System.Windows.Forms.PictureBox();
            this.button_Emprestimos = new System.Windows.Forms.Button();
            this.button_Musicas = new System.Windows.Forms.Button();
            this.button_Amigos = new System.Windows.Forms.Button();
            this.button_Consultas = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label_relogio
            // 
            this.label_relogio.AutoSize = true;
            this.label_relogio.BackColor = System.Drawing.Color.Transparent;
            this.label_relogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_relogio.ForeColor = System.Drawing.Color.White;
            this.label_relogio.Location = new System.Drawing.Point(142, 88);
            this.label_relogio.Name = "label_relogio";
            this.label_relogio.Size = new System.Drawing.Size(21, 29);
            this.label_relogio.TabIndex = 8;
            this.label_relogio.Text = "r";
            // 
            // label_login
            // 
            this.label_login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(98, 181);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(37, 13);
            this.label_login.TabIndex = 21;
            this.label_login.Text = "Config";
            this.label_login.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Devoluções,
            this.Emprestimo});
            listViewGroup3.Header = "Rafael ";
            listViewGroup3.Name = "Rafael";
            listViewGroup3.Tag = "";
            listViewGroup4.Header = "Felipe";
            listViewGroup4.Name = "Felipe";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            listViewItem5.Group = listViewGroup3;
            listViewItem6.Group = listViewGroup3;
            listViewItem7.Group = listViewGroup4;
            listViewItem8.Group = listViewGroup4;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(338, 409);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 170);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // label_DiaSemana
            // 
            this.label_DiaSemana.AutoSize = true;
            this.label_DiaSemana.BackColor = System.Drawing.Color.Transparent;
            this.label_DiaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiaSemana.ForeColor = System.Drawing.Color.White;
            this.label_DiaSemana.Location = new System.Drawing.Point(6, 52);
            this.label_DiaSemana.Name = "label_DiaSemana";
            this.label_DiaSemana.Size = new System.Drawing.Size(29, 31);
            this.label_DiaSemana.TabIndex = 9;
            this.label_DiaSemana.Text = "d";
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
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackgroundImage = global::AcervoMusical.Properties.Resources.data;
            this.panel3.Controls.Add(this.pictureBox_Login);
            this.panel3.Location = new System.Drawing.Point(55, 134);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(43, 311);
            this.panel3.TabIndex = 27;
            // 
            // labelRelogio
            // 
            this.labelRelogio.AutoSize = true;
            this.labelRelogio.BackColor = System.Drawing.Color.Transparent;
            this.labelRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelogio.ForeColor = System.Drawing.Color.White;
            this.labelRelogio.Location = new System.Drawing.Point(142, 88);
            this.labelRelogio.Name = "labelRelogio";
            this.labelRelogio.Size = new System.Drawing.Size(21, 29);
            this.labelRelogio.TabIndex = 11;
            this.labelRelogio.Text = "r";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackgroundImage = global::AcervoMusical.Properties.Resources.data;
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Controls.Add(this.labelSemana);
            this.panel1.Controls.Add(this.labelRelogio);
            this.panel1.Controls.Add(this.label_Data);
            this.panel1.Controls.Add(this.label_DiaSemana);
            this.panel1.Controls.Add(this.label_relogio);
            this.panel1.Location = new System.Drawing.Point(79, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 121);
            this.panel1.TabIndex = 14;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(6, 9);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(29, 31);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "d";
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.BackColor = System.Drawing.Color.Transparent;
            this.labelSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemana.ForeColor = System.Drawing.Color.White;
            this.labelSemana.Location = new System.Drawing.Point(6, 52);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(29, 31);
            this.labelSemana.TabIndex = 12;
            this.labelSemana.Text = "d";
            // 
            // button_MediaPlayer
            // 
            this.button_MediaPlayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_MediaPlayer.BackgroundImage = global::AcervoMusical.Properties.Resources.mediaplayer;
            this.button_MediaPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_MediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MediaPlayer.Location = new System.Drawing.Point(139, 230);
            this.button_MediaPlayer.Name = "button_MediaPlayer";
            this.button_MediaPlayer.Size = new System.Drawing.Size(195, 175);
            this.button_MediaPlayer.TabIndex = 25;
            this.button_MediaPlayer.UseVisualStyleBackColor = true;
            // 
            // button_Agenda
            // 
            this.button_Agenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Agenda.BackgroundImage = global::AcervoMusical.Properties.Resources.agenda;
            this.button_Agenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Agenda.Location = new System.Drawing.Point(140, 408);
            this.button_Agenda.Name = "button_Agenda";
            this.button_Agenda.Size = new System.Drawing.Size(194, 175);
            this.button_Agenda.TabIndex = 23;
            this.button_Agenda.UseVisualStyleBackColor = true;
            // 
            // button_Mubox
            // 
            this.button_Mubox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Mubox.BackgroundImage = global::AcervoMusical.Properties.Resources.mubox;
            this.button_Mubox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Mubox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Mubox.Location = new System.Drawing.Point(139, 49);
            this.button_Mubox.Name = "button_Mubox";
            this.button_Mubox.Size = new System.Drawing.Size(320, 175);
            this.button_Mubox.TabIndex = 22;
            this.button_Mubox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.button_Consultas);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(658, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 355);
            this.panel2.TabIndex = 28;
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
            // 
            // button_Emprestimos
            // 
            this.button_Emprestimos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Emprestimos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Emprestimos.BackgroundImage")));
            this.button_Emprestimos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Emprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Emprestimos.Location = new System.Drawing.Point(463, 49);
            this.button_Emprestimos.Name = "button_Emprestimos";
            this.button_Emprestimos.Size = new System.Drawing.Size(194, 175);
            this.button_Emprestimos.TabIndex = 29;
            this.button_Emprestimos.UseVisualStyleBackColor = true;
            // 
            // button_Musicas
            // 
            this.button_Musicas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Musicas.BackColor = System.Drawing.Color.Transparent;
            this.button_Musicas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Musicas.BackgroundImage")));
            this.button_Musicas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Musicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Musicas.Location = new System.Drawing.Point(661, 50);
            this.button_Musicas.Name = "button_Musicas";
            this.button_Musicas.Size = new System.Drawing.Size(315, 173);
            this.button_Musicas.TabIndex = 26;
            this.button_Musicas.UseVisualStyleBackColor = false;
            this.button_Musicas.Click += new System.EventHandler(this.button_Musicas_Click);
            // 
            // button_Amigos
            // 
            this.button_Amigos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Amigos.BackgroundImage = global::AcervoMusical.Properties.Resources.amigos1;
            this.button_Amigos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Amigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Amigos.Location = new System.Drawing.Point(338, 228);
            this.button_Amigos.Name = "button_Amigos";
            this.button_Amigos.Size = new System.Drawing.Size(318, 175);
            this.button_Amigos.TabIndex = 24;
            this.button_Amigos.UseVisualStyleBackColor = true;
            // 
            // button_Consultas
            // 
            this.button_Consultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Consultas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Consultas.BackgroundImage")));
            this.button_Consultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultas.Location = new System.Drawing.Point(2, 0);
            this.button_Consultas.Name = "button_Consultas";
            this.button_Consultas.Size = new System.Drawing.Size(317, 175);
            this.button_Consultas.TabIndex = 13;
            this.button_Consultas.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1037, 632);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_Emprestimos);
            this.Controls.Add(this.button_Musicas);
            this.Controls.Add(this.button_MediaPlayer);
            this.Controls.Add(this.button_Amigos);
            this.Controls.Add(this.button_Agenda);
            this.Controls.Add(this.button_Mubox);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPrincipal";
            this.Text = "tool";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_relogio;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.PictureBox pictureBox_Login;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Devoluções;
        private System.Windows.Forms.ColumnHeader Emprestimo;
        private System.Windows.Forms.Label label_DiaSemana;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelRelogio;
        private System.Windows.Forms.Button button_Emprestimos;
        private System.Windows.Forms.Button button_Consultas;
        private System.Windows.Forms.Button button_Musicas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.Button button_MediaPlayer;
        private System.Windows.Forms.Button button_Amigos;
        private System.Windows.Forms.Button button_Agenda;
        private System.Windows.Forms.Button button_Mubox;
        private System.Windows.Forms.Panel panel2;


    }
}