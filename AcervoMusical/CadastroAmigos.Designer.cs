namespace AcervoMusical
{
    partial class CadastroAmigos
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
            this.button_Remover = new System.Windows.Forms.Button();
            this.groupBox_Remover = new System.Windows.Forms.GroupBox();
            this.textBox_Remover = new System.Windows.Forms.TextBox();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.listView_Amigos = new System.Windows.Forms.ListView();
            this.maskedTextBox_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.textBox_Bairro = new System.Windows.Forms.TextBox();
            this.label_Bairro = new System.Windows.Forms.Label();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label_Numero = new System.Windows.Forms.Label();
            this.textBox_Endereco = new System.Windows.Forms.TextBox();
            this.label_Endereço = new System.Windows.Forms.Label();
            this.label_Telefone = new System.Windows.Forms.Label();
            this.textBox_NomeAmigo = new System.Windows.Forms.TextBox();
            this.label_Nome = new System.Windows.Forms.Label();
            this.button_Editar = new System.Windows.Forms.Button();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Número = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Remover.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(478, 17);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(75, 23);
            this.button_Remover.TabIndex = 60;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            // 
            // groupBox_Remover
            // 
            this.groupBox_Remover.Controls.Add(this.button_Editar);
            this.groupBox_Remover.Controls.Add(this.button_Remover);
            this.groupBox_Remover.Controls.Add(this.textBox_Remover);
            this.groupBox_Remover.Location = new System.Drawing.Point(12, 92);
            this.groupBox_Remover.Name = "groupBox_Remover";
            this.groupBox_Remover.Size = new System.Drawing.Size(647, 51);
            this.groupBox_Remover.TabIndex = 58;
            this.groupBox_Remover.TabStop = false;
            this.groupBox_Remover.Text = "Remover / Editar";
            // 
            // textBox_Remover
            // 
            this.textBox_Remover.Location = new System.Drawing.Point(6, 19);
            this.textBox_Remover.Name = "textBox_Remover";
            this.textBox_Remover.Size = new System.Drawing.Size(466, 20);
            this.textBox_Remover.TabIndex = 1;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(571, 63);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 57;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Location = new System.Drawing.Point(490, 63);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cadastrar.TabIndex = 56;
            this.button_Cadastrar.Text = "Adicionar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Location = new System.Drawing.Point(400, 24);
            this.textBox_Email.MaximumSize = new System.Drawing.Size(600, 20);
            this.textBox_Email.MinimumSize = new System.Drawing.Size(150, 20);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(154, 20);
            this.textBox_Email.TabIndex = 55;
            // 
            // label_Email
            // 
            this.label_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(401, 8);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 54;
            this.label_Email.Text = "E-mail";
            // 
            // listView_Amigos
            // 
            this.listView_Amigos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Amigos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Email,
            this.Telefone,
            this.Endereço,
            this.Número,
            this.Bairro});
            this.listView_Amigos.Location = new System.Drawing.Point(12, 149);
            this.listView_Amigos.Name = "listView_Amigos";
            this.listView_Amigos.Size = new System.Drawing.Size(790, 345);
            this.listView_Amigos.TabIndex = 53;
            this.listView_Amigos.UseCompatibleStateImageBehavior = false;
            this.listView_Amigos.View = System.Windows.Forms.View.Details;
            // 
            // maskedTextBox_Telefone
            // 
            this.maskedTextBox_Telefone.Location = new System.Drawing.Point(557, 24);
            this.maskedTextBox_Telefone.Mask = "(99) 9999-9999";
            this.maskedTextBox_Telefone.MaximumSize = new System.Drawing.Size(152, 20);
            this.maskedTextBox_Telefone.Name = "maskedTextBox_Telefone";
            this.maskedTextBox_Telefone.Size = new System.Drawing.Size(80, 20);
            this.maskedTextBox_Telefone.TabIndex = 52;
            // 
            // textBox_Bairro
            // 
            this.textBox_Bairro.Location = new System.Drawing.Point(297, 63);
            this.textBox_Bairro.MinimumSize = new System.Drawing.Size(157, 20);
            this.textBox_Bairro.Name = "textBox_Bairro";
            this.textBox_Bairro.Size = new System.Drawing.Size(177, 20);
            this.textBox_Bairro.TabIndex = 51;
            // 
            // label_Bairro
            // 
            this.label_Bairro.AutoSize = true;
            this.label_Bairro.Location = new System.Drawing.Point(294, 47);
            this.label_Bairro.Name = "label_Bairro";
            this.label_Bairro.Size = new System.Drawing.Size(34, 13);
            this.label_Bairro.TabIndex = 50;
            this.label_Bairro.Text = "Bairro";
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(229, 63);
            this.textBox_Numero.MaximumSize = new System.Drawing.Size(62, 20);
            this.textBox_Numero.MinimumSize = new System.Drawing.Size(30, 20);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(62, 20);
            this.textBox_Numero.TabIndex = 49;
            // 
            // label_Numero
            // 
            this.label_Numero.AutoSize = true;
            this.label_Numero.Location = new System.Drawing.Point(226, 47);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(44, 13);
            this.label_Numero.TabIndex = 48;
            this.label_Numero.Text = "Numero";
            // 
            // textBox_Endereco
            // 
            this.textBox_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Endereco.Location = new System.Drawing.Point(12, 63);
            this.textBox_Endereco.MaximumSize = new System.Drawing.Size(442, 20);
            this.textBox_Endereco.MinimumSize = new System.Drawing.Size(130, 20);
            this.textBox_Endereco.Name = "textBox_Endereco";
            this.textBox_Endereco.Size = new System.Drawing.Size(211, 20);
            this.textBox_Endereco.TabIndex = 47;
            // 
            // label_Endereço
            // 
            this.label_Endereço.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Endereço.AutoSize = true;
            this.label_Endereço.Location = new System.Drawing.Point(9, 47);
            this.label_Endereço.Name = "label_Endereço";
            this.label_Endereço.Size = new System.Drawing.Size(53, 13);
            this.label_Endereço.TabIndex = 46;
            this.label_Endereço.Text = "Endereço";
            // 
            // label_Telefone
            // 
            this.label_Telefone.AutoSize = true;
            this.label_Telefone.Location = new System.Drawing.Point(554, 8);
            this.label_Telefone.Name = "label_Telefone";
            this.label_Telefone.Size = new System.Drawing.Size(49, 13);
            this.label_Telefone.TabIndex = 45;
            this.label_Telefone.Text = "Telefone";
            // 
            // textBox_NomeAmigo
            // 
            this.textBox_NomeAmigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NomeAmigo.Location = new System.Drawing.Point(12, 24);
            this.textBox_NomeAmigo.MaximumSize = new System.Drawing.Size(600, 20);
            this.textBox_NomeAmigo.MinimumSize = new System.Drawing.Size(150, 20);
            this.textBox_NomeAmigo.Name = "textBox_NomeAmigo";
            this.textBox_NomeAmigo.Size = new System.Drawing.Size(382, 20);
            this.textBox_NomeAmigo.TabIndex = 44;
            // 
            // label_Nome
            // 
            this.label_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Nome.AutoSize = true;
            this.label_Nome.Location = new System.Drawing.Point(9, 8);
            this.label_Nome.Name = "label_Nome";
            this.label_Nome.Size = new System.Drawing.Size(35, 13);
            this.label_Nome.TabIndex = 43;
            this.label_Nome.Text = "Nome";
            // 
            // button_Editar
            // 
            this.button_Editar.Location = new System.Drawing.Point(559, 16);
            this.button_Editar.Name = "button_Editar";
            this.button_Editar.Size = new System.Drawing.Size(75, 23);
            this.button_Editar.TabIndex = 59;
            this.button_Editar.Text = "Editar";
            this.button_Editar.UseVisualStyleBackColor = true;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 200;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 121;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 97;
            // 
            // Endereço
            // 
            this.Endereço.Text = "Endereço";
            this.Endereço.Width = 159;
            // 
            // Número
            // 
            this.Número.Text = "Número";
            this.Número.Width = 51;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 154;
            // 
            // CadastroAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 502);
            this.Controls.Add(this.groupBox_Remover);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.listView_Amigos);
            this.Controls.Add(this.maskedTextBox_Telefone);
            this.Controls.Add(this.textBox_Bairro);
            this.Controls.Add(this.label_Bairro);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.label_Numero);
            this.Controls.Add(this.textBox_Endereco);
            this.Controls.Add(this.label_Endereço);
            this.Controls.Add(this.label_Telefone);
            this.Controls.Add(this.textBox_NomeAmigo);
            this.Controls.Add(this.label_Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(821, 534);
            this.Name = "CadastroAmigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Amigos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroAmigos_FormClosing);
            this.groupBox_Remover.ResumeLayout(false);
            this.groupBox_Remover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.GroupBox groupBox_Remover;
        private System.Windows.Forms.Button button_Editar;
        private System.Windows.Forms.TextBox textBox_Remover;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ListView listView_Amigos;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Endereço;
        private System.Windows.Forms.ColumnHeader Número;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Telefone;
        private System.Windows.Forms.TextBox textBox_Bairro;
        private System.Windows.Forms.Label label_Bairro;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.TextBox textBox_Endereco;
        private System.Windows.Forms.Label label_Endereço;
        private System.Windows.Forms.Label label_Telefone;
        private System.Windows.Forms.TextBox textBox_NomeAmigo;
        private System.Windows.Forms.Label label_Nome;


    }
}