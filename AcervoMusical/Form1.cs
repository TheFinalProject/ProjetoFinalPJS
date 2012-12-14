using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AcervoMusical
{
    public partial class Login : Form
    {
        public FormPrincipal FP = new FormPrincipal();

        public Login()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_Entrar_Click(object sender, EventArgs e)
        {
            Class_DataSet DataSetLogin = new Class_DataSet();
            bool Entrar = false;

            DataSetLogin.Login();

            foreach (DataRow Registro in DataSetLogin.Dados.Tables["Usuario"].Rows)
            {
                if(Registro["Login"].ToString() == textBox_Login.Text)
                {
                    if (Registro["senha"].ToString() == textBox_Senha.Text)
                    {
                        this.Close();
                        Entrar = true;
                    }
                }
            }
            if (Entrar == false)
            {
                label_mensagem.Text = "Login Invalido!!";
                label_mensagem.Visible = true;
            }
            else
                label_mensagem.Visible = false;
        }

        private void textBox_Login_Enter(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "Nome")
            {
                textBox_Login.Text = string.Empty;
            }
        }

        private void textBox_Login_Leave(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "" || textBox_Login.Text == " ")
            {
                textBox_Login.Text = "Nome";
            }
        }

        private void textBox_Senha_Enter(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "Senha")
            {
                textBox_Senha.Text = string.Empty;
            }

        }

        private void textBox_Senha_Leave(object sender, EventArgs e)
        {
            if (textBox_Senha.Text == "" || textBox_Senha.Text == " ")
            {
                textBox_Senha.Text = "Senha";
            }
        }
    }
}
