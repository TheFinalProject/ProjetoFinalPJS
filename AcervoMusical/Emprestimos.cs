﻿using System;
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
        public FormPrincipal FP;

        Class_DataSet DatasetEmprestimos = new Class_DataSet();

        int Id_Amigo = 0, Id_Musica = 0;
        string NomeDoAmigo, NomeDaMusica;

        

        public Emprestimos()
        {
            InitializeComponent();
        }

        public void LimparTexto()
        {
            comboBox_NomeAlbum.Text = null;
            comboBox_NomeAmigos.Text = null;
            comboBox_TipoMidia.Text = null;
            textBox_Email.Text = null;
            textBox_Tel.Text = null;
            dateTimePicker_emprestimo.ResetText();
            
        }

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            panel_Emprestimos.BackColor = FP.BackColor;

            AutoCompleteStringCollection DadosComboboxAmigos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DadosComboboxTipoDeMidia = new AutoCompleteStringCollection();

            DatasetEmprestimos.PreencheAmigos();
            DatasetEmprestimos.PreencheMusicas();
            DatasetEmprestimos.PreencheEmprestimos();

            int ContadorDeDados = DatasetEmprestimos.Dados.Tables.Count;

            if (ContadorDeDados > 0)
            {
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["EmprestimosCompletos"].Rows)
                {
                    string Teste = Registro["Status"].ToString();
                    string teste2 = Registro["Data_Devolucao"].ToString();
                    if ((Registro["Status"].ToString() != "True") && (Registro["Data_Devolucao"].ToString() != string.Empty))
                    {
                        //Carrega os Valores do dataset no Listview
                        ListViewItem ListaDeEmprestimos = new ListViewItem();

                        ListaDeEmprestimos.Text = (Registro["Nome"].ToString());
                        ListaDeEmprestimos.SubItems.Add(Registro["EmprestimosTipo_Midia"].ToString());
                        ListaDeEmprestimos.SubItems.Add(Registro["Nome_Album"].ToString());
                        ListaDeEmprestimos.SubItems.Add(Registro["Data_Emprestimo"].ToString());

                        listView_Emprestimos.Items.Add(ListaDeEmprestimos);
                    }
                }

                //Carrega os nomes dos amigos cadastrados no combobox_NomeAmigo
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
                {
                    comboBox_NomeAmigos.Items.Add(Registro["Nome"]);
                    DadosComboboxAmigos.Add(Registro["Nome"].ToString());
                    comboBox_NomeAmigos.AutoCompleteCustomSource = DadosComboboxAmigos;
                }
                int ContadorDeEmprestimos = listView_Emprestimos.Items.Count;
                if (ContadorDeEmprestimos > 0)
                {
                    label_Emprestados.Text = "Voce tem : " + ContadorDeEmprestimos + " Albun(s) emprestado(s).";
                    label_Emprestados.Visible = true;
                }
                else
                    label_Emprestados.Visible = false;

                //Apresenta a quantidade de emprestimos
                //foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
                //{
                //    if ((Registro["Tipo_Midia"].ToString() != "Digital") && (Registro["Status"].ToString() == "True"))
                //    {
                //        ContadorDeEmprestimos = ContadorDeEmprestimos + 1;
                //        label_Emprestados.Text = "Voce tem : " + ContadorDeEmprestimos + " Albun(s) emprestado(s).";
                //        label_Emprestados.Visible = true;
                //    }
                //}
            }
            else
            {
                comboBox_TipoMidia.Text = "Acervo Vazio.";
                comboBox_NomeAlbum.Text = "Acervo Vazio.";
            }
        }

        private void button_Emprestar_Click(object sender, EventArgs e)
        {
            if (button_Emprestar.Text == "Emprestar")
            {
                if (comboBox_NomeAmigos.Text != string.Empty)
                {
                    if (comboBox_TipoMidia.Text != string.Empty)
                    {
                        try
                        {
                            FP.Conector.Conectar();
                            SqlCommand CmdInserir = new SqlCommand("INSERT INTO Emprestimos(Data_Emprestimo, EmprestimosId_amigo, EmprestimosId_musicas, EmprestimosTipo_Midia) VALUES (@DataEmprestimo, @IdAmigo, @IdMusica,@EmprestimosTipo_Midia)", FP.Conector.Conexao);

                            #region Parametro Data de Emprestimo
                            SqlParameter DataEmprestimo = new SqlParameter();
                            DataEmprestimo.Value = dateTimePicker_emprestimo.Value.ToShortDateString();
                            DataEmprestimo.SourceColumn = "Data_Emprestimo";
                            DataEmprestimo.ParameterName = "@DataEmprestimo";
                            DataEmprestimo.SqlDbType = SqlDbType.Date;
                            #endregion

                            #region Parametro Tipo de Midia
                            SqlParameter TipoMidia = new SqlParameter();
                            TipoMidia.Value = comboBox_TipoMidia.Text;
                            TipoMidia.SourceColumn = "EmprestimosTipo_Midia";
                            TipoMidia.ParameterName = "@EmprestimosTipo_Midia";
                            TipoMidia.SqlDbType = SqlDbType.VarChar;
                            TipoMidia.Size = 50;
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

                            CmdInserir.Parameters.AddRange(new SqlParameter[] { DataEmprestimo, IdMusica, IdAmigo, TipoMidia });
                            CmdInserir.ExecuteNonQuery();

                            //Atualiza o status do album na tabela musicas para que nao possa mais ser emprestado
                            SqlCommand CmdAtualizar = new SqlCommand("UPDATE Musicas SET Status = 1 WHERE id_musicas = @IdAlbum", FP.Conector.Conexao);
                            SqlParameter NomeAlbum = new SqlParameter();

                            #region Parametro Status
                            NomeAlbum.Value = Id_Musica;
                            NomeAlbum.SourceColumn = "Status";
                            NomeAlbum.ParameterName = "@IdAlbum";
                            NomeAlbum.SqlDbType = SqlDbType.Int;
                            #endregion

                            CmdAtualizar.Parameters.AddRange(new SqlParameter[] { NomeAlbum });
                            CmdAtualizar.ExecuteNonQuery();

                            ListViewItem ListaDeEmprestimos = new ListViewItem();
                            ListaDeEmprestimos.Text = comboBox_NomeAmigos.Text;
                            ListaDeEmprestimos.SubItems.Add(comboBox_TipoMidia.Text);
                            ListaDeEmprestimos.SubItems.Add(comboBox_NomeAlbum.Text);
                            ListaDeEmprestimos.SubItems.Add(dateTimePicker_emprestimo.Value.ToShortDateString());

                            listView_Emprestimos.Items.Add(ListaDeEmprestimos);

                            comboBox_NomeAlbum.Items.Remove(comboBox_NomeAlbum.Text);
                            //LimparTexto();
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
                    else
                        MessageBox.Show("Nenhuma musica foi selecionada");
                }
                else
                    MessageBox.Show("Nenhum Amigo foi selecionado");
            }
            else
            {
                button_Emprestar.Text = "Emprestar";
                button_Devolver.Enabled = false;
                LimparTexto();
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
            //comboBox_NomeAmigos.Text = listView_Emprestimos.FocusedItem.SubItems[0].ToString();
            //comboBox_TipoMidia.Text = listView_Emprestimos.FocusedItem.SubItems[1].ToString();
            //comboBox_NomeAlbum.Text = listView_Emprestimos.FocusedItem.SubItems[2].ToString();
            //dateTimePicker_emprestimo.Value = Convert.ToDateTime(listView_Emprestimos.FocusedItem.SubItems[3].ToString());

            try
            {
                FP.Conector.Conectar();

                SqlCommand IdMusica = new SqlCommand("SELECT id_musicas FROM Musicas WHERE Nome_Album = @NomeAlbum", FP.Conector.Conexao);
                IdMusica.Parameters.Add("@NomeAlbum", SqlDbType.VarChar);
                IdMusica.Parameters["@NomeAlbum"].Value = listView_Emprestimos.FocusedItem.SubItems[2].Text;

                SqlCommand IdAmigo = new SqlCommand("SELECT id_amigo FROM Amigos WHERE Nome = @NomeAmigo", FP.Conector.Conexao);
                IdAmigo.Parameters.Add("@NomeAmigo", SqlDbType.VarChar);
                IdAmigo.Parameters["@NomeAmigo"].Value = listView_Emprestimos.FocusedItem.SubItems[0].Text;

                Id_Amigo = (int)IdAmigo.ExecuteScalar();

                Id_Musica = (int)IdMusica.ExecuteScalar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                FP.Conector.Desconectar();
            }
        
            button_Emprestar.Text = "Voltar";
            button_Devolver.Enabled = true;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();

                SqlCommand IdMusica = new SqlCommand("SELECT id_musicas FROM Musicas WHERE Nome_Album = @NomeAlbum", FP.Conector.Conexao);
                IdMusica.Parameters.Add("@NomeAlbum", SqlDbType.VarChar);
                IdMusica.Parameters["@NomeAlbum"].Value = comboBox_NomeAlbum.Text;

                Id_Musica = (int)IdMusica.ExecuteScalar();
                NomeDaMusica = comboBox_TipoMidia.Text;


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

        private void comboBox_TipoMidia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_NomeAlbum.Items.Clear();
            comboBox_NomeAlbum.ResetText();

            AutoCompleteStringCollection DadosComboboxAlbum = new AutoCompleteStringCollection();

            foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {
                string Teste = Registro["Status"].ToString();
                string Teste2 = Registro["Nome_Album"].ToString();
                if ((comboBox_TipoMidia.Text == Registro["Tipo_Midia"].ToString()) && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_NomeAlbum.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
                //else if ((Registro["Tipo_Midia"].ToString() == "Vinil") && (Registro["Status"].ToString() != "True"))
                //{
                //    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                //    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                //    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                //}
                //else if ((Registro["Tipo_Midia"].ToString() == "CD") && (Registro["Status"].ToString() != "True"))
                //{
                //    comboBox_NomeAlbum.Items.Clear();
                //    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                //    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                //    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                //}
                //else if ((Registro["Tipo_Midia"].ToString() == "K7") && (Registro["Status"].ToString() != "True"))
                //{
                //    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                //    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                //    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                //}
            }
        }

        private void button_Devolver_Click(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();

                //Atualiza a data de Devolução para que possa gerar um relatorio
                SqlCommand CmdAtualizarEmprestimos = new SqlCommand("UPDATE Emprestimos SET Data_Devolucao = @DataDevolucao WHERE (EmprestimosId_musicas = @IdAlbum) AND (EmprestimosId_Amigo = @IdAmigo)", FP.Conector.Conexao);

                #region Parametro Id Amigo
                SqlParameter DataDevolucao = new SqlParameter();
                DataDevolucao.Value = DateTime.Now.ToShortDateString();
                DataDevolucao.SourceColumn = "Data_Devolucao";
                DataDevolucao.ParameterName = "@DataDevolucao";
                DataDevolucao.SqlDbType = SqlDbType.Date;
                #endregion

                #region Parametro Id Amigo
                SqlParameter IdAmigo = new SqlParameter();
                IdAmigo.Value = Id_Amigo;
                IdAmigo.SourceColumn = "EmprestimosId_amigo";
                IdAmigo.ParameterName = "@IdAmigo";
                IdAmigo.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro Id Musica
                SqlParameter IdAlbum = new SqlParameter();
                IdAlbum.Value = Id_Musica;
                IdAlbum.SourceColumn = "EmprestimosId_musicas";
                IdAlbum.ParameterName = "@IdAlbum";
                IdAlbum.SqlDbType = SqlDbType.Int;
                #endregion

                CmdAtualizarEmprestimos.Parameters.AddRange(new SqlParameter[] { IdAlbum, IdAmigo, DataDevolucao });
                CmdAtualizarEmprestimos.ExecuteNonQuery();

                //Atualiza o status da musica para que possa ser emprestado por outro amigo
                SqlCommand CmdAtualizarMusicas = new SqlCommand("UPDATE Musicas SET Status = 0 WHERE id_musicas = @IdMusica", FP.Conector.Conexao);

                #region Parametro Id Musica
                SqlParameter IdMusica = new SqlParameter();
                IdMusica.Value = Id_Amigo;
                IdMusica.SourceColumn = "id_musica";
                IdMusica.ParameterName = "@IdMusica";
                IdMusica.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro Tipo de Midia
                SqlParameter TipoMidia= new SqlParameter();
                TipoMidia.Value = Id_Musica;
                TipoMidia.SourceColumn = "Tipo_Midia";
                TipoMidia.ParameterName = "@TipoMidia";
                TipoMidia.SqlDbType = SqlDbType.VarChar;
                TipoMidia.Size = 10;
                #endregion

                CmdAtualizarMusicas.Parameters.AddRange(new SqlParameter[] { IdMusica, TipoMidia });
                CmdAtualizarMusicas.ExecuteNonQuery();

                for (int I = listView_Emprestimos.Items.Count; I <= 0; --I)
                {
                    ListViewItem Remover = listView_Emprestimos.SelectedItems[I];
                    listView_Emprestimos.Items.Remove(Remover);
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
