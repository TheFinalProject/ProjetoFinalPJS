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
    public partial class CadastroMusicas : Form
    {
        public CadastroMusicas()
        {
            InitializeComponent();
        }

        private void comboBox_Midia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Midia.SelectedItem.ToString() == "Digital")
            {
                label_Musica.Visible = true;
                textBox_Musicas.Visible = true;
            }
            else
            {
                label_Musica.Visible = false;
                textBox_Musicas.Visible = false;
            }
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            Class_Conexão ClasseConexao = new Class_Conexão();
            ClasseConexao.conectar();
            if (ClasseConexao.conectar())
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("Insert into Musicas (Nome_Interprete, Nome_Autor, Nome_Album, Data_Album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota,Nome_Musica, Status) values (@Interprete, @Autor, @Album, @DataAlbum, @DataCompra, @Origem, @Midia, @Observacao, @Nota, @Musica, @Status)", ClasseConexao.Conexao);
                    #region Parametros
                    #region ParametroInterprete
                    SqlParameter NomeInterprete = new SqlParameter();
                    NomeInterprete.Value = textBox_Interprete.Text;
                    NomeInterprete.SourceColumn = "Nome_Interprete";
                    NomeInterprete.ParameterName = "@Interprete";
                    NomeInterprete.SqlDbType = SqlDbType.VarChar;
                    NomeInterprete.Size = 50;
                    #endregion

                    #region ParametroAutor
                    SqlParameter Autor = new SqlParameter();
                    Autor.SourceColumn = "Nome_Autor";
                    Autor.Value = textBox_Autor.Text;
                    Autor.ParameterName = "@Autor";
                    Autor.SqlDbType = SqlDbType.VarChar;
                    Autor.Size = 50;
                    #endregion

                    #region ParametroAlbum
                    SqlParameter Album = new SqlParameter();
                    Album.SourceColumn = "Nome_Album";
                    Album.Value = textBox_Album.Text;
                    Album.ParameterName = "@Album";
                    Album.SqlDbType = SqlDbType.VarChar;
                    Album.Size = 50;
                    #endregion

                    #region ParametroDataAlbum
                    SqlParameter DataAlbum = new SqlParameter();
                    DataAlbum.SourceColumn = "Data_Album";
                    DataAlbum.SqlDbType = SqlDbType.Date;
                    DataAlbum.Value = dateTimePicker_DataAlbum.Value.ToShortDateString();
                    DataAlbum.ParameterName = "@DataAlbum";
                    
                    #endregion

                    #region ParametroDataCompra
                    SqlParameter DataCompra = new SqlParameter();
                    DataCompra.SourceColumn = "Data_Compra";
                    DataCompra.SqlDbType = SqlDbType.Date;
                    DataCompra.Value = dateTimePicker_DataCampra.Value.ToShortDateString();
                    DataCompra.ParameterName = "@DataCompra";
                    
                    #endregion

                    #region ParametroOrigem
                    SqlParameter Origem = new SqlParameter();
                    Origem.SourceColumn = "Origem_Compra";
                    Origem.Value = textBox_Origem.Text;
                    Origem.ParameterName = "@Origem";
                    Origem.SqlDbType = SqlDbType.VarChar;
                    Origem.Size = 40;
                    #endregion

                    #region ParametroObservação
                    SqlParameter Observacao = new SqlParameter();
                    Observacao.SourceColumn = "Observacao";
                    Observacao.Value = textBox_Observacao.Text;
                    Observacao.ParameterName = "@Observacao";
                    Observacao.SqlDbType = SqlDbType.VarChar;
                    Observacao.Size = 200;
                    #endregion

                    #region ParametroMidia
                    SqlParameter Midia = new SqlParameter();
                    Midia.SourceColumn = "Tipo_Midia";
                    Midia.Value = comboBox_Midia.SelectedItem.ToString();
                    Midia.ParameterName = "@Midia";
                    Midia.SqlDbType = SqlDbType.VarChar;
                    Midia.Size = 10;
                    #endregion

                    #region ParametroNota
                    SqlParameter Nota = new SqlParameter();
                    Nota.SourceColumn = "Nota";
                    Nota.Value = textBox_Classificação.Text;
                    Nota.ParameterName = "@Nota";
                    Nota.SqlDbType = SqlDbType.SmallInt;
                    #endregion

                    #region ParametroStatus
                    SqlParameter Status = new SqlParameter();
                    Status.SourceColumn = "Status";
                    Status.Value = 0;
                    Status.ParameterName = "@Status";
                    Status.SqlDbType = SqlDbType.Bit;

                    #endregion

                    #region ParametroMusica
                    SqlParameter Musica = new SqlParameter();
                    Musica.SourceColumn = "Nome_Musica";
                    Musica.Value = textBox_Musicas.Text;
                    Musica.ParameterName = "@Musica";
                    Musica.SqlDbType = SqlDbType.VarChar;
                    Musica.Size = 50;
                    #endregion
                    #endregion
                    Comando.Parameters.AddRange(new SqlParameter[] {NomeInterprete, Autor, Album, DataAlbum, DataCompra, Origem, Midia, Observacao, Nota, Musica, Status });
                    Comando.ExecuteNonQuery();

                    ListViewItem Item = new ListViewItem();
                    Item.Text = textBox_Musicas.Text;
                    Item.Group = listView_Cadastro_Musicas.Groups[comboBox_Midia.SelectedItem.ToString()];
                    Item.SubItems.Add(textBox_Album.Text);
                    Item.SubItems.Add(textBox_Autor.Text);
                    Item.SubItems.Add(textBox_Interprete.Text);
                    Item.SubItems.Add(textBox_Classificação.Text);
                    Item.SubItems.Add(textBox_Observacao.Text);
                    listView_Cadastro_Musicas.Items.Add(Item);

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

        private void textBox_Musicas_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
