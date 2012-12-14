namespace AcervoMusical
{
    partial class Login
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
            this.button_sair = new System.Windows.Forms.Button();
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
            this.textBox_Login.Enter += new System.EventHandler(this.textBox_Login_Enter);
            this.textBox_Login.Leave += new System.EventHandler(this.textBox_Login_Leave);
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
            this.textBox_Senha.Enter += new System.EventHandler(this.textBox_Senha_Enter);
            this.textBox_Senha.Leave += new System.EventHandler(this.textBox_Senha_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_mensagem);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.textBox_Senha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(18, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label_mensagem
            // 
            this.label_mensagem.AutoSize = true;
            this.label_mensagem.BackColor = System.Drawing.Color.Transparent;
            this.label_mensagem.ForeColor = System.Drawing.Color.Red;
            this.label_mensagem.Location = new System.Drawing.Point(7, 72);
            this.label_mensagem.Name = "label_mensagem";
            this.label_mensagem.Size = new System.Drawing.Size(26, 13);
            this.label_mensagem.TabIndex = 5;
            this.label_mensagem.Text = "Erro";
            this.label_mensagem.Visible = false;
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
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // button_sair
            // 
            this.button_sair.Location = new System.Drawing.Point(117, 233);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 6;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_Cancelar_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 268);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label_mensagem;
    }
}

