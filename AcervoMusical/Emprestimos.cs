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
    public partial class Emprestimos : Form
    {
        public Emprestimos()
        {
            InitializeComponent();
        }

        public FormPrincipal FP;

        List<List<string>> ListaDeDados = new List<List<string>>();
        List<string> ListaDeRegistros = new List<string>();

        Class_DataSet DatasetEmprestimos = new Class_DataSet();

        int Id_Amigo=0, Id_Musica=0;
        string NomeDoAmigo, NomeDaMusica;

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            panel_Emprestimos.BackColor = FP.BackColor;

            AutoCompleteStringCollection DadosComboboxAmigos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DadosComboboxMusicas = new AutoCompleteStringCollection();

            DatasetEmprestimos.PreencheAmigos();
            DatasetEmprestimos.PreencheMusicas();
            DatasetEmprestimos.PreencheEmprestimos();

            int ContadorDeDados = DatasetEmprestimos.Dados.Tables.Count;
            int ContadorDeEmprestimos = 0;

            if (ContadorDeDados > 0)
            {
                foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["EmprestimosCompletos"].Rows)
                {
                    //Carrega os Valores do dataset no Listview
                    ListViewItem ListaDeEmprestimos = new ListViewItem();

                    ListaDeEmprestimos.Text = (registro["Nome"].ToString());
                    ListaDeEmprestimos.SubItems.Add(registro["Nome_Album"].ToString());
                    ListaDeEmprestimos.SubItems.Add(registro["Data_Emprestimo"].ToString());

                    listView_Emprestimos.Items.Add(ListaDeEmprestimos);
                }
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
                {
                    ListaDeRegistros.Add(Registro["Nome"].ToString());
                    ListaDeRegistros.Add(Registro["Email"].ToString());
                    ListaDeRegistros.Add(Registro["Telefone"].ToString());
                    ListaDeRegistros.Add(Registro["Endereco"].ToString());
                    ListaDeRegistros.Add(Registro["Bairro"].ToString());

                    ListaDeDados.Add(ListaDeRegistros);

                    comboBox_NomeAmigos.Items.Add(Registro["Nome"]);
                    DadosComboboxAmigos.Add(Registro["Nome"].ToString());
                    comboBox_NomeAmigos.AutoCompleteCustomSource = DadosComboboxAmigos;
                }
                foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
                {
                    if ((registro["Tipo_Midia"].ToString() != "Digital") && (registro["Status"].ToString() != "True"))
                    {
                        comboBox_NomeMusicas.Items.Add(registro["Nome_Album"]);
                        DadosComboboxMusicas.Add(registro["Nome_Album"].ToString());
                        comboBox_NomeMusicas.AutoCompleteCustomSource = DadosComboboxMusicas;
                    }
                    else if ((registro["Tipo_Midia"].ToString() != "Digital") && (registro["Status"].ToString() == "True"))
                    {
                        ContadorDeEmprestimos = ContadorDeEmprestimos + 1;
                        label_Emprestados.Text = "Voce tem : " + ContadorDeEmprestimos + " Albun(s) emprestado(s).";
                        label_Emprestados.Visible = true;
                    }
                }
            }
            else
                comboBox_NomeMusicas.Text = "Acervo Vazio.";
        }

        private void button_Emprestar_Click(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();
                SqlCommand CmdInserir = new SqlCommand("INSERT INTO Emprestimos(Data_Emprestimo, EmprestimosId_amigo, EmprestimosId_musicas) VALUES (@DataEmprestimo, @IdAmigo, @IdMusica)", FP.Conector.Conexao);

                #region Parametro Data de Emprestimo
                SqlParameter DataEmprestimo = new SqlParameter();
                DataEmprestimo.Value = dateTimePicker_emprestimo.Value;
                DataEmprestimo.SourceColumn = "Data_Emprestimo";
                DataEmprestimo.ParameterName = "@DataEmprestimo";
                DataEmprestimo.SqlDbType = SqlDbType.Date;
                #endregion

                #region Parametro Id Amigo
                SqlParameter IdAmigo = new SqlParameter();
                IdAmigo.Value = Id_Amigo;
                IdAmigo.SourceColumn = "EmprestimosId_amigo";
                IdAmigo.ParameterName = "@IdAmigo";
                IdAmigo.SqlDbType = SqlDbType.Int;
                IdAmigo.Size = 50;
                #endregion

                #region Parametro Id Musica
                SqlParameter IdMusica = new SqlParameter();
                IdMusica.Value = Id_Musica;
                IdMusica.SourceColumn = "EmprestimosId_musicas";
                IdMusica.ParameterName = "@IdMusica";
                IdMusica.SqlDbType = SqlDbType.Int;
                #endregion

                CmdInserir.Parameters.AddRange(new SqlParameter[] { DataEmprestimo, IdMusica, IdAmigo });
                CmdInserir.ExecuteNonQuery();

                //Atualiza o status do album para que nao possa mais ser emprestado
                SqlCommand CmdAtualizar = new SqlCommand("UPDATE Musicas SET Status = 1 WHERE Nome_Album = @NomeALbum",FP.Conector.Conexao);
                SqlParameter NomeAlbum = new SqlParameter();
                NomeAlbum.Value = comboBox_NomeMusicas.Text;
                NomeAlbum.SourceColumn = "Status";
                NomeAlbum.ParameterName = "@NomeAlbum";
                NomeAlbum.SqlDbType = SqlDbType.VarChar;
                NomeAlbum.Size = 50;

                CmdAtualizar.Parameters.AddRange(new SqlParameter[] {NomeAlbum});
                CmdAtualizar.ExecuteNonQuery();

                ListViewItem ListaDeEmprestimos = new ListViewItem();
                ListaDeEmprestimos.Text = comboBox_NomeAmigos.Text;
                ListaDeEmprestimos.SubItems.Add(comboBox_NomeMusicas.Text);
                ListaDeEmprestimos.SubItems.Add(dateTimePicker_emprestimo.Value.ToShortDateString());

                listView_Emprestimos.Items.Add(ListaDeEmprestimos);
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
        }

        private void comboBox_NomeAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {         
            try
            {
                FP.Conector.Conectar();

                SqlCommand IdAmigo = new SqlCommand("SELECT id_amigo FROM Amigos WHERE Nome = @NomeAmigo", FP.Conector.Conexao);
                IdAmigo.Parameters.Add("@NomeAmigo", SqlDbType.VarChar);
                IdAmigo.Parameters["@NomeAmigo"].Value = comboBox_NomeAmigos.Text;

                Id_Amigo = (int)IdAmigo.ExecuteScalar();
                NomeDoAmigo = comboBox_NomeAmigos.Text;

                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["EmprestimosCompletos"].Rows)
                {
                    if (Registro["Nome"].ToString() == comboBox_NomeAmigos.Text)
                    {
                        textBox_Tel.Text = Registro["Telefone"].ToString();
                        textBox_Email.Text = Registro["Email"].ToString();
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                FP.Conector.Desconectar();
            }
        }

        private void comboBox_NomeMusicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();

                SqlCommand IdMusica= new SqlCommand("SELECT id_musicas FROM Musicas WHERE Nome_Album = @NomeAlbum", FP.Conector.Conexao);
                IdMusica.Parameters.Add("@NomeAlbum", SqlDbType.VarChar);
                IdMusica.Parameters["@NomeAlbum"].Value = comboBox_NomeMusicas.Text;

                Id_Musica = (int)IdMusica.ExecuteScalar();
                NomeDaMusica = comboBox_NomeMusicas.Text;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                FP.Conector.Desconectar();
            }
        }

        private void button_ConsultarAlbum_Click(object sender, EventArgs e)
        {
            Consultas ConsultarAlbum = new Consultas();
            ConsultarAlbum.FP = FP;
            ConsultarAlbum.Show();
        }

        private void button_ConsultarAmigos_Click(object sender, EventArgs e)
        {
            CadastroAmigos ConsultarAmigos = new CadastroAmigos();
            ConsultarAmigos.FP = FP;
            ConsultarAmigos.Show();
        }

        private void listView_Emprestimos_Click(object sender, EventArgs e)
        {
            comboBox_NomeAmigos.Text = listView_Emprestimos.SelectedItems[0].Text;
            comboBox_NomeMusicas.Text = listView_Emprestimos.FocusedItem.SubItems[1].Text;
            dateTimePicker_emprestimo.Value = Convert.ToDateTime(listView_Emprestimos.FocusedItem.SubItems[2].Text);


        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox_PesquisarEmprestimo.Text == "Pesquisar" && textBox_PesquisarEmprestimo.ForeColor == Color.Silver)
            {
                textBox_PesquisarEmprestimo.Clear();
                textBox_PesquisarEmprestimo.ForeColor = Color.Black;
            }               

        }

        private void textBox_PesquisarEmprestimo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_PesquisarEmprestimo.Text != "")
                {
                    FP.Conector.Conectar();
                    DatasetEmprestimos.ConsultarEmprestimos(textBox_PesquisarEmprestimo.Text);

                    foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["ConsultarEmprestimos"].Rows)
                    {
                        ListViewItem ListaDeEmprestimos = new ListViewItem();

                        ListaDeEmprestimos.Text = Registro["Nome"].ToString();
                        ListaDeEmprestimos.SubItems.Add(Registro["Nome_Album"].ToString());
                        ListaDeEmprestimos.SubItems.Add(Registro["Data_Emprestimo"].ToString());

                        listView_Emprestimos.Items.Add(ListaDeEmprestimos);
                    }
                }         
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
