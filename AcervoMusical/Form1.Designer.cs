namespace AcervoMusical
{
    partial class Form1
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.button_Entrar = new System.Windows.Forms.Button();
            this.textBox_Senha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_mensagem = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_Login.Location = new System.Drawing.Point(6, 19);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(174, 20);
            this.textBox_Login.TabIndex = 1;
            this.textBox_Login.Text = "Nome";
            this.textBox_Login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Login_MouseClick);
            this.textBox_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Login_KeyPress);
            // 
            // button_Entrar
            // 
            this.button_Entrar.Location = new System.Drawing.Point(18, 233);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(75, 23);
            this.button_Entrar.TabIndex = 2;
            this.button_Entrar.Text = "Entrar";
            this.button_Entrar.UseVisualStyleBackColor = true;
            this.button_Entrar.Click += new System.EventHandler(this.button_Entrar_Click);
            // 
            // textBox_Senha
            // 
            this.textBox_Senha.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox_Senha.Location = new System.Drawing.Point(6, 45);
            this.textBox_Senha.Name = "textBox_Senha";
            this.textBox_Senha.Size = new System.Drawing.Size(174, 20);
            this.textBox_Senha.TabIndex = 4;
            this.textBox_Senha.Text = "Senha";
            this.textBox_Senha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Senha_MouseClick);
            this.textBox_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Login_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_mensagem);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.textBox_Senha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.Location = new System.Drawing.Point(7, 72);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(0, 13);
            this.label_mensagem.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 217);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu a senha?";
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(117, 233);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 6;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 268);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Button button_Entrar;
        private System.Windows.Forms.TextBox textBox_Senha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label_mensagem;
    }
}

