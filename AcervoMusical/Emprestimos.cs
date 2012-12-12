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
            int ContadorDeEmprestimos = 0;

            if (ContadorDeDados > 0)
            {
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["EmprestimosCompletos"].Rows)
                {
                    //Carrega os Valores do dataset no Listview
                    ListViewItem ListaDeEmprestimos = new ListViewItem();

                    ListaDeEmprestimos.Text = (Registro["Nome"].ToString());
                    ListaDeEmprestimos.SubItems.Add(Registro["EmprestimosTipo_Midia"].ToString());
                    ListaDeEmprestimos.SubItems.Add(Registro["Nome_Album"].ToString());
                    ListaDeEmprestimos.SubItems.Add(Registro["Data_Emprestimo"].ToString());

                    listView_Emprestimos.Items.Add(ListaDeEmprestimos);
                }
                foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
                {
                    comboBox_NomeAmigos.Items.Add(Registro["Nome"]);
                    DadosComboboxAmigos.Add(Registro["Nome"].ToString());
                    comboBox_NomeAmigos.AutoCompleteCustomSource = DadosComboboxAmigos;
                }
                foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
                {
                    if ((registro["Tipo_Midia"].ToString() != "Digital") && (registro["Status"].ToString() != "True"))
                    {
                        comboBox_TipoMidia.Items.Add(registro["Tipo_Midia"]);
                        DadosComboboxTipoDeMidia.Add(registro["Tipo_Midia"].ToString());
                        comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxTipoDeMidia;
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
                comboBox_TipoMidia.Text = "Acervo Vazio.";
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
                            SqlCommand CmdInserir = new SqlCommand("INSERT INTO Emprestimos(Data_Emprestimo, EmprestimosTipo_Midia,EmprestimosId_amigo, EmprestimosId_musicas) VALUES (@DataEmprestimo,@EmprestimosTipo_Midia, @IdAmigo, @IdMusica)", FP.Conector.Conexao);

                            #region Parametro Data de Emprestimo
                            SqlParameter DataEmprestimo = new SqlParameter();
                            DataEmprestimo.Value = dateTimePicker_emprestimo.Value;
                            DataEmprestimo.SourceColumn = "Data_Emprestimo";
                            DataEmprestimo.ParameterName = "@DataEmprestimo";
                            DataEmprestimo.SqlDbType = SqlDbType.Date;
                            #endregion

                            #region Parametro Tipo de Midia
                            SqlParameter TipoMidia = new SqlParameter();
                            DataEmprestimo.Value = comboBox_TipoMidia.Text;
                            DataEmprestimo.SourceColumn = "EmprestimosTipo_Midia";
                            DataEmprestimo.ParameterName = "@EmprestimosTipo_Midia";
                            DataEmprestimo.SqlDbType = SqlDbType.VarChar;
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
                            SqlCommand CmdAtualizar = new SqlCommand("UPDATE Musicas SET Status = 1 WHERE Nome_Album = @NomeALbum", FP.Conector.Conexao);
                            SqlParameter NomeAlbum = new SqlParameter();
                            NomeAlbum.Value = comboBox_TipoMidia.Text;
                            NomeAlbum.SourceColumn = "Status";
                            NomeAlbum.ParameterName = "@NomeAlbum";
                            NomeAlbum.SqlDbType = SqlDbType.VarChar;
                            NomeAlbum.Size = 50;

                            CmdAtualizar.Parameters.AddRange(new SqlParameter[] { NomeAlbum });
                            CmdAtualizar.ExecuteNonQuery();

                            ListViewItem ListaDeEmprestimos = new ListViewItem();
                            ListaDeEmprestimos.Text = comboBox_NomeAmigos.Text;
                            ListaDeEmprestimos.SubItems.Add(comboBox_TipoMidia.Text);
                            ListaDeEmprestimos.SubItems.Add(dateTimePicker_emprestimo.Value.ToShortDateString());

                            listView_Emprestimos.Items.Add(ListaDeEmprestimos);
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
            comboBox_NomeAmigos.Text = listView_Emprestimos.SelectedItems[0].Text;
            comboBox_TipoMidia.Text = listView_Emprestimos.FocusedItem.SubItems[1].Text;
            comboBox_TipoMidia.Text = listView_Emprestimos.FocusedItem.SubItems[2].Text;
            dateTimePicker_emprestimo.Value = Convert.ToDateTime(listView_Emprestimos.FocusedItem.SubItems[3].Text);

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
            AutoCompleteStringCollection DadosComboboxAlbum = new AutoCompleteStringCollection();

            foreach (DataRow Registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {
                if ((comboBox_TipoMidia.Text == "DVD") && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
                else if ((Registro["Tipo_Midia"].ToString() == "Vinil") && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
                else if ((Registro["Tipo_Midia"].ToString() == "CD") && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Clear();
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
                else if ((Registro["Tipo_Midia"].ToString() == "K7") && (Registro["Status"].ToString() != "True"))
                {
                    comboBox_NomeAlbum.Items.Add(Registro["Nome_Album"]);
                    DadosComboboxAlbum.Add(Registro["Nome_Album"].ToString());
                    comboBox_TipoMidia.AutoCompleteCustomSource = DadosComboboxAlbum;
                }
            }
        }
    }
}
