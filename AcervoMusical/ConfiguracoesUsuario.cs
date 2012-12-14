using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AcervoMusical
{
    public partial class ConfiguracoesUsuario : Form
    {
        public FormPrincipal FP;
        Class_DataSet DataSetLogin = new Class_DataSet();

        public ConfiguracoesUsuario()
        {
            InitializeComponent();
            DataSetLogin.Login();
        }

        byte Ativado;  
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Habilitar.Checked == true)
            {
                textBox_Login.Enabled = true;
                textBox_Password.Enabled = true;
                comboBox_Smtp.Enabled = true;
                textBox_Email.Enabled = true;
                textBox_EmailSenha.Enabled = true;
                Ativado = 1;

            }
            else
            {
                textBox_EmailSenha.Enabled = true;
                comboBox_Smtp.Enabled = false;
                textBox_Email.Enabled = false;
                textBox_Login.Enabled = false;
                textBox_Password.Enabled = false;
                Ativado = 0;
            }
        }

        private void ConfiguracoesUsuario_Load(object sender, EventArgs e)
        {
            panel_Usuario.BackColor = FP.BackColor;
            string AtivarLogin;

            int ContadorDeRegistro = DataSetLogin.Dados.Tables.Count;

            foreach (DataRow Registro in DataSetLogin.Dados.Tables["Login"].Rows)
            {
                if (ContadorDeRegistro > 1)
                {
                    if (Registro["AtivarLogin"].ToString() == "True")
                    {
                        AtivarLogin = Registro["AtivarLogin"].ToString();
                        textBox_Login.Text = Registro["Nome"].ToString();
                        textBox_Password.Text = Registro["Senha"].ToString();
                        textBox_Email.Text = Registro["Email"].ToString();
                        textBox_EmailSenha.Text = Registro["EmailSenha"].ToString();
                        comboBox_Smtp.Text = Registro["Smtp"].ToString();
                    }
                    else
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Smtp SMTP = new Smtp();
            SMTP.ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();
                SqlCommand CmdInserir = new SqlCommand("INSERT INTO Usuario VALUES(@Login, @Senha, @Email, @EmailSenha, @Smtp, @AtivarLogin,0)", FP.Conector.Conexao);

                #region Paramametro Login
                SqlParameter Login = new SqlParameter();
                Login.Value = textBox_Login.Text;
                Login.SourceColumn = "Login";
                Login.ParameterName = "@Login";
                Login.SqlDbType = SqlDbType.VarChar;
                Login.Size = 20;
                #endregion

                #region Parametro Senha
                SqlParameter Senha = new SqlParameter();
                Senha.Value = textBox_Senha.Text;
                Senha.SourceColumn = "Senha";
                Senha.ParameterName = "@Senha";
                Senha.SqlDbType = SqlDbType.VarChar;
                Senha.Size = 20;
                #endregion

                #region Parametro Email
                SqlParameter Email = new SqlParameter();
                Email.Value = textBox_Email.Text;
                Email.SourceColumn = "Email";
                Email.ParameterName = "@Email";
                Email.SqlDbType = SqlDbType.VarChar;
                Email.Size = 20;
                #endregion

                #region Parametro Senha Email
                SqlParameter EmailSenha = new SqlParameter();
                EmailSenha.Value = textBox_EmailSenha.Text;
                EmailSenha.SourceColumn = "EmailSenha";
                EmailSenha.ParameterName = "@EmailSenha";
                EmailSenha.SqlDbType = SqlDbType.VarChar;
                EmailSenha.Size = 20;
                #endregion

                #region Parametro SMTP
                SqlParameter Smtp = new SqlParameter();
                Smtp.Value = comboBox_Smtp.Text;
                Smtp.SourceColumn = "Smtp";
                Smtp.ParameterName = "@Smtp";
                Smtp.SqlDbType = SqlDbType.VarChar;
                Smtp.Size = 25;
                #endregion

                #region Parametro Ativar Login
                SqlParameter Ativar = new SqlParameter();
                Ativar.Value = Ativado;
                Ativar.SourceColumn = "AtivarLogin";
                Ativar.ParameterName = "@AtivarLogin";
                Ativar.SqlDbType = SqlDbType.Bit;
                #endregion

                CmdInserir.Parameters.AddRange(new SqlParameter[] { Login, Senha, Email, EmailSenha, Smtp, Ativar});
                CmdInserir.ExecuteNonQuery();
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            finally
            {
                FP.Conector.Desconectar();
            }         
        }
    }
}
