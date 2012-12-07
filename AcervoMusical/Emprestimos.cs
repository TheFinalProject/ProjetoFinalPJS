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

        Class_DataSet DatasetEmprestimos = new Class_DataSet();

        int Id_Amigo=0, Id_Musica=0;
        string NomeDoAmigo, NomeDaMusica;

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            

            AutoCompleteStringCollection DadosComboboxAmigos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DadosComboboxMusicas = new AutoCompleteStringCollection();

            DatasetEmprestimos.PreencheAmigos();
            DatasetEmprestimos.PreencheMusicas();

            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
            {
                    comboBox_NomeAmigos.Items.Add(registro["Nome"]);
                    DadosComboboxAmigos.Add(registro["Nome"].ToString());
                    comboBox_NomeAmigos.AutoCompleteCustomSource = DadosComboboxAmigos;
            }
            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {
                int ContadorDeRegistros = registro.ItemArray.Count();
                int ContadorDeEmprestimos = 0;

                if (ContadorDeRegistros > 0)
                {
                    if (registro["Tipo_Midia"].ToString() != "Digital" && registro["Status"].ToString() != "1")
                    {
                        comboBox_NomeMusicas.Items.Add(registro["Nome_Album"]);
                        DadosComboboxMusicas.Add(registro["Nome_Album"].ToString());
                        comboBox_NomeMusicas.AutoCompleteCustomSource = DadosComboboxMusicas;
                    }
                    else if (registro["Status"].ToString() == "1")
                    {
                        ContadorDeRegistros = ContadorDeRegistros++;
                        comboBox_NomeMusicas.Text = "Voce tem : " + ContadorDeEmprestimos + " emprestados.";
                    }
                }
                else
                    comboBox_NomeMusicas.Text = "Nao ha midias para emprestimo";
            }
        }

        private void button_Emprestar_Click(object sender, EventArgs e)
        {

            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {

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
            ConsultarAlbum.Show();
        }

        private void button_ConsultarAmigos_Click(object sender, EventArgs e)
        {
            CadastroAmigos ConsultarAmigos = new CadastroAmigos();
            ConsultarAmigos.FP = FP;
            ConsultarAmigos.Show();
        }
    }
}
