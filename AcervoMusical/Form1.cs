using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcervoMusical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
            FormPrincipal abrir_principal = new FormPrincipal();
            abrir_principal.Show();

            //this.Dispose();
        }

        private void textBox_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            // evento para quando precionar a tecla Enter ao tenta entrar no AcervoMusical
            if (e.KeyChar == 13)
            {
                if (textBox_Login.Text != "" && textBox_Senha.Text != "")
                {
                    if (textBox_Login.Text == "admin" && textBox_Senha.Text == "123")
                    {
                        new FormPrincipal().Show();
                    }
                    else
                    {
                        
                        label_mensagem.Text = "Senha ou usuário inválido";
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox_Login, "Preencha o campo com seu nome de acesso");
                    errorProvider1.SetError(textBox_Senha, "Preencha o campo com sua senha de acesso");
                }

            }
        }

        private void textBox_Login_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Login.Text = "";
        }

        private void textBox_Senha_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_Senha.Text = "";
        }
    }
}
