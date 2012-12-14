namespace AcervoMusical
{
    partial class ConfiguracoesGerais
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
            this.comboBox_cores = new System.Windows.Forms.ComboBox();
            this.button_Salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_TravarBotoes = new System.Windows.Forms.CheckBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.panel_ConfigGerais = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ConfigGerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_cores
            // 
            this.comboBox_cores.FormattingEnabled = true;
            this.comboBox_cores.Items.AddRange(new object[] {
            "Rosa",
            "Azul",
            "Vermelho",
            "Amarelo",
            "Roxo",
            "Preto",
            "Branco"});
            this.comboBox_cores.Location = new System.Drawing.Point(16, 118);
            this.comboBox_cores.Name = "comboBox_cores";
            this.comboBox_cores.Size = new System.Drawing.Size(261, 21);
            this.comboBox_cores.TabIndex = 0;
            this.comboBox_cores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Salvar
            // 
            this.button_Salvar.Location = new System.Drawing.Point(132, 283);
            this.button_Salvar.Name = "button_Salvar";
            this.button_Salvar.Size = new System.Drawing.Size(75, 23);
            this.button_Salvar.TabIndex = 1;
            this.button_Salvar.Text = "Salvar";
            this.button_Salvar.UseVisualStyleBackColor = true;
            this.button_Salvar.Click += new System.EventHandler(this.button_Salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cor de fundo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Travar os botoes";
            // 
            // checkBox_TravarBotoes
            // 
            this.checkBox_TravarBotoes.AutoSize = true;
            this.checkBox_TravarBotoes.Location = new System.Drawing.Point(108, 159);
            this.checkBox_TravarBotoes.Name = "checkBox_TravarBotoes";
            this.checkBox_TravarBotoes.Size = new System.Drawing.Size(15, 14);
            this.checkBox_TravarBotoes.TabIndex = 4;
            this.checkBox_TravarBotoes.UseVisualStyleBackColor = true;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(213, 283);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 6;
            this.button_Reset.Text = "Padroes";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // panel_ConfigGerais
            // 
            this.panel_ConfigGerais.Controls.Add(this.label3);
            this.panel_ConfigGerais.Controls.Add(this.pictureBox1);
            this.panel_ConfigGerais.Location = new System.Drawing.Point(0, 0);
            this.panel_ConfigGerais.Name = "panel_ConfigGerais";
            this.panel_ConfigGerais.Size = new System.Drawing.Size(300, 60);
            this.panel_ConfigGerais.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CONFIGURAÇOES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcervoMusical.Properties.Resources.Ferramentas;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ConfiguracoesGerais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 317);
            this.Controls.Add(this.panel_ConfigGerais);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.checkBox_TravarBotoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Salvar);
            this.Controls.Add(this.comboBox_cores);
            this.Name = "ConfiguracoesGerais";
            this.Text = "ConfiguracoesGerais";
            this.Load += new System.EventHandler(this.ConfiguracoesGerais_Load);
            this.panel_ConfigGerais.ResumeLayout(false);
            this.panel_ConfigGerais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_cores;
        private System.Windows.Forms.Button button_Salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_TravarBotoes;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Panel panel_ConfigGerais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}