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

                }
                catch (Exception erro)
                {
                    throw erro;
                }
                finally
                {
                    ClasseConexao.desconectar();
                }
            }
        }

        private void CadastroAmigos_Load(object sender, EventArgs e)
        {
            SqlDataReader LeitorEstados;

            if (!ClasseConexao.conectar())
            {
                return;
            }
            else
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

        private void CadastroAmigos_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader LeitorCidades;

            if (!ClasseConexao.conectar())
            {
            }
            else
            {

                SqlCommand CmdCidades = new SqlCommand("SELECT Cidades.Nome FROM Cidades INNER JOIN Estados ON Cidades.CidadeId_uf = Estados.id_Estado WHERE Estados.id_Estado = '"+comboBox_UF.Text+"'", ClasseConexao.Conexao);

                LeitorCidades = CmdCidades.ExecuteReader();

                while (LeitorCidades.Read())
                {
                    comboBox_Cidade.Items.Add(LeitorCidades["Nome"].ToString());
                }

                LeitorCidades.Close();
            }
        }
    }
}