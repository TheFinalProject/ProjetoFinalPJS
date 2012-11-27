using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace AcervoMusical
{
    public partial class CadastroAmigos : Form
    {
        public CadastroAmigos()
        {
            InitializeComponent();
        }

        Class_Conexão ClasseConexao = new Class_Conexão();
        //Variavel criada para verificação de botao caso precionado
        bool fechar = false;
        int Id_Cidade = 0;

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            //se o botao foi precionado altera o valor da variavel para true e fecha o form
            fechar = true;
            this.Close();

        }

        private void CadastroAmigos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verifica se a variavel manteve o seu valor inicial, se caso manteve, ele entra e verifica se há dados salvos ou nao!!!
            if (fechar == false)
            {
                int soma = 0;
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox t = (TextBox)c;
                        if (t.Text != "")
                        {
                            soma++;
                        }
                    }
                }
                if (soma > 0)
                {
                    if (MessageBox.Show("O Formulário contém dados não salvos, deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        fechar = true;
                        this.Close();

                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Class_Conexão ClasseConexao = new Class_Conexão();
            ClasseConexao.conectar();
            if (ClasseConexao.conectar())
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("Insert into Amigos (Nome, Telefone, Endereço, Bairro, Numero, Email, AmigosId_Cidade, AmigosId_Estado) values (@Nome, @Telefone, @Endereço, @Bairro, @Numero, @Email, @AmigosId_Cidade, @AmigosId_Estado)", ClasseConexao.Conexao);
                    #region Parametros
                    #region Param_Amigo
                    SqlParameter NomeAmigo = new SqlParameter();
                    NomeAmigo.Value = textBox_NomeAmigo.Text;
                    NomeAmigo.SourceColumn = "Nome";
                    NomeAmigo.ParameterName = "@Nome";
                    NomeAmigo.SqlDbType = SqlDbType.VarChar;
                    NomeAmigo.Size = 50;
                    #endregion

                    #region Param_Telefone
                    SqlParameter Telefone = new SqlParameter();
                    Telefone.SourceColumn = "Telefone";
                    Telefone.Value = maskedTextBox_Telefone.Text;
                    Telefone.ParameterName = "@Telefone";
                    Telefone.SqlDbType = SqlDbType.Char;
                    Telefone.Size = 15;
                    #endregion

                    #region Param_Endereço
                    SqlParameter Endereco = new SqlParameter();
                    Endereco.SourceColumn = "Endereço";
                    Endereco.Value = textBox_Endereco.Text;
                    Endereco.ParameterName = "@Endereço";
                    Endereco.SqlDbType = SqlDbType.VarChar;
                    Endereco.Size = 50;
                    #endregion

                    #region Param_Bairro
                    SqlParameter Bairro = new SqlParameter();
                    Bairro.SourceColumn = "Bairro";
                    Bairro.Value = textBox_Bairro.Text;
                    Bairro.ParameterName = "@Bairro";
                    Bairro.SqlDbType = SqlDbType.VarChar;


                    #endregion

                    #region Param_Numero
                    SqlParameter Numero = new SqlParameter();
                    Numero.SourceColumn = "Numero";
                    Numero.Value = textBox_Numero.Text;
                    Numero.ParameterName = "@Numero";
                    Numero.SqlDbType = SqlDbType.Char;
                    Numero.Size = 10;
                    #endregion

                    #region Param_Email
                    SqlParameter Email = new SqlParameter();
                    Email.SourceColumn = "Email";
                    Email.Value = textBox_Email.Text;
                    Email.ParameterName = "@Email";
                    Email.SqlDbType = SqlDbType.VarChar;
                    Email.Size = 50;
                    #endregion

                    #region Param_Cidade
                    SqlParameter Cidade = new SqlParameter();
                    Cidade.SourceColumn = "AmigosId_Cidade";
                    Cidade.Value = Id_Cidade;
                    Cidade.ParameterName = "@AmigosId_Cidade";
                    Cidade.SqlDbType = SqlDbType.Int;

                    #endregion

                    #region Param_Estado
                    SqlParameter Estado = new SqlParameter();
                    Estado.SourceColumn = "AmigosId_Estado";
                    Estado.Value = comboBox_UF.Text;
                    Estado.ParameterName = "@AmigosId_Estado";
                    Estado.SqlDbType = SqlDbType.Char;
                    Estado.Size = 3;
                    #endregion
                    #endregion

                    Comando.Parameters.AddRange(new SqlParameter[] { NomeAmigo, Telefone, Endereco, Bairro, Numero, Email, Cidade, Estado });
                    Comando.ExecuteNonQuery();

                    ListViewItem Amigos = new ListViewItem();
                    Amigos.Text = textBox_NomeAmigo.Text;
                    Amigos.Group = listView_CadastroAmigos.Groups[comboBox_Cidade.SelectedItem.ToString()];
                    Amigos.SubItems.Add(maskedTextBox_Telefone.Text);
                    Amigos.SubItems.Add(textBox_Endereco.Text);
                    Amigos.SubItems.Add(textBox_Numero.Text);
                    Amigos.SubItems.Add(textBox_Email.Text);
                    listView_CadastroAmigos.Items.Add(Amigos);
               
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "");
                }
                finally
                {
                    if (ClasseConexao != null)
                        ClasseConexao.Conexao.Close();
                }
            }
        }

        private void CadastroAmigos_Load(object sender, EventArgs e)
        {
            SqlDataReader LeitorEstados;

            if (ClasseConexao.conectar())
            {
                SqlCommand CmdEstados = new SqlCommand("Select * From Estados", ClasseConexao.Conexao);

                LeitorEstados = CmdEstados.ExecuteReader();

                while (LeitorEstados.Read())
                {
                    comboBox_UF.Items.Add(LeitorEstados["id_Estado"].ToString());
                }

                LeitorEstados.Close();
            }
        }

        private void comboBox_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega o combobox_Cidade com os valores de cada estado
            comboBox_Cidade.Items.Clear();
            SqlDataReader LeitorCidades;
            if (ClasseConexao.conectar())
            {
                SqlCommand CmdCidades = new SqlCommand("SELECT Nome FROM Cidades WHERE CidadeId_uf = '" + comboBox_UF.Text + "'", ClasseConexao.Conexao);

                LeitorCidades = CmdCidades.ExecuteReader();

                while (LeitorCidades.Read())
                {
                    comboBox_Cidade.Items.Add(LeitorCidades["Nome"].ToString());
                }

                LeitorCidades.Close();
            }
        }

        private void comboBox_Cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlCommand IdCidades = new SqlCommand("SELECT id_Cidade FROM Cidades WHERE Nome = @Nome", ClasseConexao.Conexao);
            IdCidades.Parameters.Add("@Nome", SqlDbType.VarChar);
            IdCidades.Parameters["@Nome"].Value = comboBox_Cidade.Text;

            try
            {
                ClasseConexao.conectar();
                Id_Cidade = (int)IdCidades.ExecuteScalar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                ClasseConexao.desconectar();
            }
            
        }
    }
}