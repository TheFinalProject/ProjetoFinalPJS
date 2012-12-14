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
        public FormPrincipal FP;

        Class_DataSet DatasetEmprestimos = new Class_DataSet();

        int Id_Amigo = 0, Id_Musica = 0;
        string NomeDoAmigo, NomeDaMusica;

        

        public Emprestimos()
        {
            InitializeComponent();
            DatasetEmprestimos.PreencheAmigos();
            DatasetEmprestimos.PreencheEmprestimos();
        }
        public void CalcularEmprestimos()
        {
            int ContadorDeEmprestimos = listView_Emprestimos.Items.Count;
            if (ContadorDeEmprestimos > 0)
            {
                label_Emprestados.Text = "Voce tem : " + ContadorDeEmprestimos + " Albun(s) emprestado(s).";
                label_Emprestados.Visible = true;
            }
            else
                label_Emprestados.Visible = false;
        }

        public void LimparTexto()
        {
            comboBox_NomeAlbum.Text = "";
            comboBox_NomeAmigos.Text = "";
            comboBox_TipoMidia.Text = "";
            textBox_Email.Text = "";
            textBox_Tel.Text = "";
            dateTimePicker_emprestimo.ResetText();         
        }

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            panel_Emprestimos.BackColor = FP.BackColor;

            AutoCompleteStringCollection DadosComboboxAmigos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DadosComboboxTipoDeMidia = new AutoCompleteStringCollection();

            int ContadorDeDados = DatasetEmprestimos.Dados.Tables.Count;

            if (ContadorDeDados > 0)
            {
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["EmprestimosCompletos"].Rows)
                {
                    if ((Registro["Status"].ToString() == "True") && (Registro["Data_Devolucao"].ToString() == ""))
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
                CalcularEmprestimos();
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
                    label_NomeAmigo.ForeColor = Color.Black;

                    if ((comboBox_NomeAlbum.Text != string.Empty) && (comboBox_TipoMidia.Text != string.Empty) )
                    {
                        try
                        {                            
                            FP.Conector.Conectar();
                            SqlCommand CmdInserir = new SqlCommand("INSERT INTO Emprestimos(Data_Emprestimo, EmprestimosId_amigo, EmprestimosId_musicas, EmprestimosTipo_Midia) VALUES (@DataEmprestimo, @IdAmigo, @IdMusica,@EmprestimosTipo_Midia)", FP.Conector.Conexao);

                            #region Pega Id_Amigo
                            SqlCommand PegaIdAmigo = new SqlCommand("SELECT id_amigo FROM Amigos WHERE (Nome = @NomeAmigo) AND (Email = @Email )", FP.Conector.Conexao);
                            PegaIdAmigo.Parameters.Add("@NomeAmigo", SqlDbType.VarChar);
                            PegaIdAmigo.Parameters.Add("@Email", SqlDbType.VarChar);
                            PegaIdAmigo.Parameters.Add("@Telefone", SqlDbType.VarChar);

                            PegaIdAmigo.Parameters["@NomeAmigo"].Value = comboBox_NomeAmigos.Text;
                            PegaIdAmigo.Parameters["@Email"].Value = textBox_Email.Text;
                            PegaIdAmigo.Parameters["@Telefone"].Value = textBox_Tel.Text;

                            Id_Amigo = (int)PegaIdAmigo.ExecuteScalar();
                            NomeDoAmigo = comboBox_NomeAmigos.Text;
                            #endregion

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
                            comboBox_NomeAlbum.Text = string.Empty;
                            comboBox_TipoMidia.Text = string.Empty;

                            CalcularEmprestimos();
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
                        label_Album.ForeColor = Color.Red;
                }
                else
                    label_NomeAmigo.ForeColor = Color.Red;
            }
            else if(button_Emprestar.Text == "Voltar")
            {
                button_Emprestar.Text = "Emprestar";
                button_Devolver.Enabled = false;
            }
        }

        private void comboBox_NomeAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {         
            try
            {
                FP.Conector.Conectar();

                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
                {
                    if (Registro["Nome"].ToString() == comboBox_NomeAmigos.Text)
                    {
                        textBox_Email.Text = Registro["Email"].ToString();
                        textBox_Tel.Text = Registro["Telefone"].ToString();
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
            DatasetEmprestimos.PreencheEmprestimos();
            DatasetEmprestimos.PreencheMusicas();

            comboBox_NomeAlbum.Items.Clear();
            comboBox_NomeAlbum.ResetText();

            AutoCompleteStringCollection DadosComboboxAlbum = new AutoCompleteStringCollection();

            foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {
                if ((comboBox_TipoMidia.Text == Registro["Tipo_Midia"].ToString()) && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_NomeAlbum.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
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
                SqlCommand CmdAtualizarMusicas = new SqlCommand("UPDATE Musicas SET Status = 0 WHERE (id_musicas = @IdMusica) AND (Tipo_Midia = @TipoMidia)", FP.Conector.Conexao);

                #region Parametro Id Musica
                SqlParameter IdMusica = new SqlParameter();
                IdMusica.Value = Id_Musica;
                IdMusica.SourceColumn = "id_musica";
                IdMusica.ParameterName = "@IdMusica";
                IdMusica.SqlDbType = SqlDbType.Int;
                #endregion

                #region Parametro Tipo de Midia
                SqlParameter TipoMidia= new SqlParameter();
                TipoMidia.Value = listView_Emprestimos.SelectedItems[0].SubItems[1].Text;
                TipoMidia.SourceColumn = "Tipo_Midia";
                TipoMidia.ParameterName = "@TipoMidia";
                TipoMidia.SqlDbType = SqlDbType.VarChar;
                TipoMidia.Size = 10;
                #endregion

                CmdAtualizarMusicas.Parameters.AddRange(new SqlParameter[] { IdMusica, TipoMidia });
                CmdAtualizarMusicas.ExecuteNonQuery();

                listView_Emprestimos.Items.Remove(listView_Emprestimos.SelectedItems[0]);

                CalcularEmprestimos();

                button_Devolver.Enabled = false;
                button_Emprestar.Text = "Emprestar";
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
