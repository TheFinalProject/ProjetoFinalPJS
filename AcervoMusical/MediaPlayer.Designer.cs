namespace AcervoMusical
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.button_anterior = new System.Windows.Forms.Button();
            this.button_proximo = new System.Windows.Forms.Button();
            this.button_ultimo = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Primeiro = new System.Windows.Forms.Button();
            this.listBox_Musicas = new System.Windows.Forms.ListBox();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer_tempo = new System.Windows.Forms.Timer(this.components);
            this.panel_MediaPlayer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Resume = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.panel_MediaPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(9, 92);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Volume.Size = new System.Drawing.Size(45, 380);
            this.trackBar_Volume.TabIndex = 43;
            this.trackBar_Volume.Value = 50;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // button_anterior
            // 
            this.button_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_anterior.Location = new System.Drawing.Point(244, 15);
            this.button_anterior.Name = "button_anterior";
            this.button_anterior.Size = new System.Drawing.Size(55, 40);
            this.button_anterior.TabIndex = 37;
            this.button_anterior.Text = "<";
            this.button_anterior.UseVisualStyleBackColor = false;
            this.button_anterior.Click += new System.EventHandler(this.button_anterior_Click);
            // 
            // button_proximo
            // 
            this.button_proximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proximo.Location = new System.Drawing.Point(609, 15);
            this.button_proximo.Name = "button_proximo";
            this.button_proximo.Size = new System.Drawing.Size(55, 40);
            this.button_proximo.TabIndex = 36;
            this.button_proximo.Text = ">";
            this.button_proximo.UseVisualStyleBackColor = false;
            this.button_proximo.Click += new System.EventHandler(this.button_proximo_Click);
            // 
            // button_ultimo
            // 
            this.button_ultimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ultimo.Location = new System.Drawing.Point(670, 15);
            this.button_ultimo.Name = "button_ultimo";
            this.button_ultimo.Size = new System.Drawing.Size(55, 40);
            this.button_ultimo.TabIndex = 35;
            this.button_ultimo.Text = ">>";
            this.button_ultimo.UseVisualStyleBackColor = false;
            this.button_ultimo.Click += new System.EventHandler(this.button_ultimo_Click);
            // 
            // button_Play
            // 
            this.button_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.ForeColor = System.Drawing.Color.White;
            this.button_Play.Location = new System.Drawing.Point(381, 15);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(70, 40);
            this.button_Play.TabIndex = 34;
            this.button_Play.Text = "PLAY";
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.White;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Location = new System.Drawing.Point(2, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(100, 60);
            this.button_Add.TabIndex = 33;
            this.button_Add.Text = "Abrir Musica";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Primeiro
            // 
            this.button_Primeiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Primeiro.Location = new System.Drawing.Point(183, 15);
            this.button_Primeiro.Name = "button_Primeiro";
            this.button_Primeiro.Size = new System.Drawing.Size(55, 40);
            this.button_Primeiro.TabIndex = 38;
            this.button_Primeiro.Text = "<<";
            this.button_Primeiro.UseVisualStyleBackColor = false;
            this.button_Primeiro.Click += new System.EventHandler(this.button_Primeiro_Click);
            // 
            // listBox_Musicas
            // 
            this.listBox_Musicas.FormattingEnabled = true;
            this.listBox_Musicas.Location = new System.Drawing.Point(61, 98);
            this.listBox_Musicas.Name = "listBox_Musicas";
            this.listBox_Musicas.Size = new System.Drawing.Size(753, 368);
            this.listBox_Musicas.TabIndex = 44;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(217, 399);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(427, 37);
            this.WindowsMediaPlayer.TabIndex = 45;
            this.WindowsMediaPlayer.Visible = false;
            // 
            // timer_tempo
            // 
            this.timer_tempo.Enabled = true;
            // 
            // panel_MediaPlayer
            // 
            this.panel_MediaPlayer.Controls.Add(this.label1);
            this.panel_MediaPlayer.Controls.Add(this.button_Add);
            this.panel_MediaPlayer.Controls.Add(this.pictureBox1);
            this.panel_MediaPlayer.Location = new System.Drawing.Point(-2, 0);
            this.panel_MediaPlayer.Name = "panel_MediaPlayer";
            this.panel_MediaPlayer.Size = new System.Drawing.Size(871, 60);
            this.panel_MediaPlayer.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(738, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "MEDIA PLAYER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Resume);
            this.groupBox1.Controls.Add(this.button_Pause);
            this.groupBox1.Controls.Add(this.button_Stop);
            this.groupBox1.Controls.Add(this.button_Play);
            this.groupBox1.Controls.Add(this.button_Primeiro);
            this.groupBox1.Controls.Add(this.button_anterior);
            this.groupBox1.Controls.Add(this.button_ultimo);
            this.groupBox1.Controls.Add(this.button_proximo);
            this.groupBox1.Location = new System.Drawing.Point(11, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 67);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // button_Resume
            // 
            this.button_Resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Resume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Resume.ForeColor = System.Drawing.Color.White;
            this.button_Resume.Location = new System.Drawing.Point(457, 15);
            this.button_Resume.Name = "button_Resume";
            this.button_Resume.Size = new System.Drawing.Size(70, 40);
            this.button_Resume.TabIndex = 41;
            this.button_Resume.Text = "RESUME";
            this.button_Resume.UseVisualStyleBackColor = false;
            this.button_Resume.Click += new System.EventHandler(this.button_Resume_Click_1);
            // 
            // button_Pause
            // 
            this.button_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pause.ForeColor = System.Drawing.Color.White;
            this.button_Pause.Location = new System.Drawing.Point(305, 15);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(70, 40);
            this.button_Pause.TabIndex = 40;
            this.button_Pause.Text = "PAUSE";
            this.button_Pause.UseVisualStyleBackColor = false;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click_1);
            // 
            // button_Stop
            // 
            this.button_Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Stop.ForeColor = System.Drawing.Color.White;
            this.button_Stop.Location = new System.Drawing.Point(533, 15);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(70, 40);
            this.button_Stop.TabIndex = 39;
            this.button_Stop.Text = "STOP";
            this.button_Stop.UseVisualStyleBackColor = false;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click_1);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 547);
            this.Controls.Add(this.panel_MediaPlayer);
            this.Controls.Add(this.listBox_Musicas);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.groupBox1);
            this.Name = "MediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaPlayer";
            this.Load += new System.EventHandler(this.MediaPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.panel_MediaPlayer.ResumeLayout(false);
            this.panel_MediaPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Button button_anterior;
        private System.Windows.Forms.Button button_proximo;
        private System.Windows.Forms.Button button_ultimo;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Primeiro;
        private System.Windows.Forms.ListBox listBox_Musicas;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Timer timer_tempo;
        private System.Windows.Forms.Panel panel_MediaPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Resume;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Stop;
    }
}