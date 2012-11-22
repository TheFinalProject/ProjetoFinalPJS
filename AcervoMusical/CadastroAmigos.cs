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
            
            ClasseConexao.conectar();
            ArrayList Array_Insercao = new ArrayList();

            if (ClasseConexao.conectar())
            {
                try
                {

                    Array_Insercao.Add(textBox_NomeAmigo.Text);
                    Array_Insercao.Add(maskedTextBox_Telefone.Text);
                    Array_Insercao.Add(textBox_Endereco.Text);
                    Array_Insercao.Add(textBox_Bairro.Text);
                    Array_Insercao.Add(textBox_Numero.Text);
                    Array_Insercao.Add(textBox_Email.Text);
                    Array_Insercao.Add(comboBox_Cidade.Text);
                    Array_Insercao.Add(comboBox_UF.Text);


                    //cria novo comando em sql para inserção de dados na tabela de amigos!
                    SqlCommand comando = new SqlCommand("INSERT INTO Amigos VALUES (@Nome, @Telefone, @Endereço, @Bairro, @Numero, @Email, @id_Cidade, @id_Estado)", ClasseConexao.Conexao);

                    comando.Parameters.Add(new SqlParameter("@Nome", Array_Insercao[0]));
                    comando.Parameters.Add(new SqlParameter("@Telefone", Array_Insercao[1]));
                    comando.Parameters.Add(new SqlParameter("@Endereço", Array_Insercao[2]));
                    comando.Parameters.Add(new SqlParameter("@Bairro", Array_Insercao[3]));
                    comando.Parameters.Add(new SqlParameter("@Numero", Array_Insercao[4]));
                    comando.Parameters.Add(new SqlParameter("@Email", Array_Insercao[5]));
                    comando.Parameters.Add(new SqlParameter("@id_Cidade", Array_Insercao[6]));
                    comando.Parameters.Add(new SqlParameter("@id_Estado", Array_Insercao[7]));
                    comando.ExecuteNonQuery();



                    //SqlParameter Nome = new SqlParameter();
                    //Nome.Value = textBox_NomeAmigo.Text;
                    //Nome.SourceColumn = "Nome";
                    //Nome.ParameterName = "@Nome";
                    //Nome.SqlDbType = SqlDbType.VarChar;
                    //Nome.Size = 50;


                    //SqlParameter Nome = new SqlParameter();
                    //Nome.Value = textBox_NomeAmigo.Text;
                    //Nome.SourceColumn = "Nome";
                    //Nome.ParameterName = "@Nome";
                    //Nome.SqlDbType = SqlDbType.VarChar;
                    //Nome.Size = 50;

                }
                catch (Exception erro)
                {

                }
                

            }
        }

        private void CadastroAmigos_Load(object sender, EventArgs e)
        {
            SqlDataReader LeitorEstados;
            SqlDataReader LeitorCidades;

            SqlCommand Cmd = new SqlCommand("Select * From Estados", ClasseConexao.Conexao);

            LeitorEstados = Cmd.ExecuteReader();

            while (LeitorEstados.Read())
            {
                comboBox_UF.Items.Add(LeitorEstados.Read());
            }
        }
    }
}