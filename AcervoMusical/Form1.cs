using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcervoMusical
{
    public partial class Login : Form
    {

        Login login;
        //minha conexao com o banco de dados
        SqlConnection Conexao = new SqlConnection();
        private string StrSQL = string.Empty;
        //string de conexao
        private string StringConexao = "Data Source=(local); Initial Catalog=Acervo; Integrated Security=SSPI";

        //variavel para controlar se esta logado ou nao, a principio ela começara sem logar.
        public bool logado = false;
        
        public Login()
        {
            InitializeComponent();
        }

        private void logar()
        {
            Conexao = new SqlConnection(StringConexao);
            string Login, Senha;
            try
            {
                Login = textBox_Login.Text;
                Senha = textBox_Senha.Text;
                //Comando SQL que retorna quantos usuarios pertecem o Login Digitado
                StrSQL = "SELECT COUNT (Login) FROM usuario WHERE Login = @L AND Senha = @S";
                SqlCommand CmdSql = new SqlCommand(StrSQL, Conexao);
                CmdSql.Parameters.Add("@L", SqlDbType.VarChar).Value = Login;
                CmdSql.Parameters.Add("@S", SqlDbType.VarChar).Value = Senha;
                
                //Abrindo a conexão
                Conexao.Open();

                int Verifica = (int)CmdSql.ExecuteScalar();
                //Verificãção se ele encontrou algum usuário com certo Login e Senha
                if (Verifica > 0)
                {
                    logado = true;
                    login.Close();
                }
                else
                {
                    logado = false;
                    
                }
            }
            catch(Exception erro)
            {
                label_mensagem.Text = erro.Message;
            }
            finally
            {
                if (Conexao != null)
                    Conexao.Close();
            }
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
            logar();
            if (logado)
            {
                
            }
            else
            {
                label_mensagem.Text = "Usuário ou Senha Inválida!";
            }
        }
        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
