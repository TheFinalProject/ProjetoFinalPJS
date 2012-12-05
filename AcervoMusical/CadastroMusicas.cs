﻿using System;
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
        Class_DataSet DataSetMusicas = new Class_DataSet();
        public CadastroMusicas()
        {
            InitializeComponent();
            DataSetMusicas.PreencheMusicas();
        }

        ListViewItem Musicas = new ListViewItem();
        public FormPrincipal FP;
        //Variavel criada para verificação de botao caso precionado
        bool fechar = false;

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

        #region Botão Adicionar
        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            if (button_Adicionar.Text == "Adicionar")
            {
                if (FP.Conector.Conectar())
                {
                    try
                    {
                        SqlCommand Adicionar = new SqlCommand("Insert into Musicas (Nome_Interprete, Nome_Autor, Nome_Album, Data_Album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota,Nome_Musica, Status) values (@Interprete, @Autor, @Album, @DataAlbum, @DataCompra, @Origem, @Midia, @Observacao, @Nota, @Musica, @Status)", FP.Conector.Conexao);
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

                        Adicionar.Parameters.AddRange(new SqlParameter[] { NomeInterprete, Autor, Album, DataAlbum, DataCompra, Origem, Midia, Observacao, Nota, Musica, Status });
                        Adicionar.ExecuteNonQuery();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message, "");
                    }
                    finally
                    {
                        if (FP.Conector != null)
                            FP.Conector.Conexao.Close();
                    }

                    Musicas = new ListViewItem();
                    Musicas.Group = listView_Cadastro_Musicas.Groups[comboBox_Midia.Text];
                    Musicas.Text = textBox_Musicas.Text;
                    Musicas.SubItems.Add(textBox_Album.Text);
                    Musicas.SubItems.Add(textBox_Autor.Text);
                    Musicas.SubItems.Add(textBox_Interprete.Text);
                    Musicas.SubItems.Add(textBox_Classificação.Text);
                    Musicas.SubItems.Add(textBox_Observacao.Text);
                    listView_Cadastro_Musicas.Items.Add(Musicas);
                }
            }
            else
            {
                try
                {
                    FP.Conector.Conectar();


                    //comando para alterar os valores do amigo////(Nome_Interprete, Nome_Autor, Nome_Album, Data_Album, Data_Compra, Origem_Compra, Tipo_Midia, Observacao, Nota,Nome_Musica, Status) values (@Interprete, @Autor, @Album, @DataAlbum, @DataCompra, @Origem, @Midia, @Observacao, @Nota, @Musica, @Status)"
                    SqlCommand CmdUpdate = new SqlCommand("UPDATE Musicas SET Nome_Interprete = @Interprete, Nome_Autor = @Autor, Nome_Album = @Album, Data_Album = @DataAlbm, Data_Compra = @Datacompra, Origem_Compra = @Origem, Tipo_Midia = @Midia, Observacao = @Observacao, Nota = @Nota, Nome_Musica = @Musica, Status = @Status WHERE (Nome_Musica = @Musica) AND (Nome_Autor = @Autor) AND (Nome_Album = @Album)", FP.Conector.Conexao);

                    #region Parametros Update

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

                    
                    CmdUpdate.ExecuteNonQuery();

                    CmdUpdate.Parameters.AddRange(new SqlParameter[] { NomeInterprete, Autor, Album, DataAlbum, DataCompra, Origem, Midia, Observacao, Nota, Musica, Status });
                        CmdUpdate.ExecuteNonQuery();

                    #region atualiza o listview depois de alterações
                    for (int i = listView_Cadastro_Musicas.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem atualiza = listView_Cadastro_Musicas.SelectedItems[i];
                        atualiza.Group = listView_Cadastro_Musicas.Groups[comboBox_Midia.Text];
                        atualiza.Text = textBox_Musicas.Text;
                        atualiza.SubItems.Add(textBox_Album.Text);
                        atualiza.SubItems.Add(textBox_Autor.Text);
                        atualiza.SubItems.Add(textBox_Interprete.Text);
                        atualiza.SubItems.Add(textBox_Classificação.Text);
                        atualiza.SubItems.Add(textBox_Observacao.Text);
                        listView_Cadastro_Musicas.Items.Add(atualiza);
                    }
                    #endregion

                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    FP.Conector.Desconectar();
                }
            }

        }

        #endregion

        #region Botões de Cancelar e fechar formulario
        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            //se o botao foi precionado altera o valor da variavel para true e fecha o form
            fechar = true;
            this.Close();
        }

        private void CadastroMusicas_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (c is ComboBox)
                    {
                        ComboBox combo = (ComboBox)c;
                        if (combo.Text != "")
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
        #endregion

        private void button_Remover_Click(object sender, EventArgs e)
        {
            SqlCommand Deletar = new SqlCommand("Delete from Musicas where (Nome_Musica = @Musica) and (Nome_Autor = @Autor ) and (Nome_Album = @Album)", FP.Conector.Conexao);
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
            #region ParametroMusica
            SqlParameter Musica = new SqlParameter();
            Musica.SourceColumn = "Nome_Musica";
            Musica.Value = textBox_Musicas.Text;
            Musica.ParameterName = "@Musica";
            Musica.SqlDbType = SqlDbType.VarChar;
            Musica.Size = 50;
            #endregion
            Deletar.Parameters.AddRange(new SqlParameter[] {Musica, Autor, Album});
            Deletar.ExecuteNonQuery();

            for (int i = listView_Cadastro_Musicas.SelectedIndices.Count - 1; i >= 0; --i)
            {
                ListViewItem removido = listView_Cadastro_Musicas.SelectedItems[i];
                listView_Cadastro_Musicas.Items.Remove(removido);
            }
        }


        private void CadastroMusicas_Load(object sender, EventArgs e)
        {
            #region ListView de Musicas
            foreach (DataRow registro in DataSetMusicas.Dados.Tables["MusicasCompletas"].Rows)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = registro["Nome_Musica"].ToString();
                Item.Group = listView_Cadastro_Musicas.Groups[registro["Tipo_Midia"].ToString()];
                Item.SubItems.Add(registro["Nome_Album"].ToString());
                Item.SubItems.Add(registro["Nome_Autor"].ToString());
                Item.SubItems.Add(registro["Nome_Interprete"].ToString());
                Item.SubItems.Add(registro["Nota"].ToString());
                Item.SubItems.Add(registro["Observacao"].ToString());
                listView_Cadastro_Musicas.Items.Add(Item);
            }
            #endregion
        }

        private void listView_Cadastro_Musicas_Click(object sender, EventArgs e)
        {
            if (listView_Cadastro_Musicas.SelectedItems != null)
            {
                button_Adicionar.Text = "Salvar";
                button_Remover.Enabled = true;
                //coloca os itens e subitens nos textbox para edição
                textBox_Musicas.Text = listView_Cadastro_Musicas.SelectedItems[0].Text;
                textBox_Album.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[1].Text;
                textBox_Autor.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[2].Text;
                textBox_Interprete.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[3].Text;
                textBox_Classificação.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[4].Text;
                textBox_Observacao.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[5].Text;
                comboBox_Midia.Text = listView_Cadastro_Musicas.SelectedItems[0].Group.Header;
            }
            else
            {
                button_Remover.Enabled = false;
            }       
        }

        private void listView_Cadastro_Musicas_Click_1(object sender, EventArgs e)
        {
            textBox_Musicas.Text = listView_Cadastro_Musicas.SelectedItems[0].Text;
            textBox_Autor.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[2].Text;
            textBox_Album.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[1].Text;
            textBox_Interprete.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[3].Text;
            textBox_Classificação.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[4].Text;
            textBox_Observacao.Text = listView_Cadastro_Musicas.FocusedItem.SubItems[5].Text;
            comboBox_Midia.SelectedItem = listView_Cadastro_Musicas.FocusedItem.Group.ToString();
        }



        //private void textBox_BuscaMusica_TextChanged(object sender, EventArgs e)
        //{
        //    if (FP.Conector.Conectar())
        //    {
        //        if (textBox_BuscaMusica.Text != "")
        //        {
        //            DataSetMusicas.BuscarMusicas(textBox_BuscaMusica.Text);
        //            foreach (DataRow registro in DataSetMusicas.Dados.Tables["BuscaMusicas"].Rows)
        //            {
        //                ListViewItem Item = new ListViewItem();
        //                Item.Text = registro["Nome_Musica"].ToString();
        //                Item.Group = listView_Cadastro_Musicas.Groups[registro["Tipo_Midia"].ToString()];
        //                Item.SubItems.Add(registro["Nome_Album"].ToString());
        //                Item.SubItems.Add(registro["Nome_Autor"].ToString());
        //                Item.SubItems.Add(registro["Nome_Interprete"].ToString());
        //                Item.SubItems.Add(registro["Nota"].ToString());
        //                Item.SubItems.Add(registro["Observacao"].ToString());
        //                listView_Cadastro_Musicas.Items.Add(Item);
        //            }
        //        }
        //        else
        //        {
        //            DataSetMusicas.PreencheMusicas();
        //            foreach (DataRow registro in DataSetMusicas.Dados.Tables["MusicasCompletas"].Rows)
        //            {
        //                ListViewItem Item = new ListViewItem();
        //                Item.Text = registro["Nome_Musica"].ToString();
        //                //Item.Group = registro["Tipo_Midia"].ToString();
        //                Item.SubItems.Add(registro["Nome_Album"].ToString());
        //                Item.SubItems.Add(registro["Nome_Autor"].ToString());
        //                Item.SubItems.Add(registro["Nome_Interprete"].ToString());
        //                Item.SubItems.Add(registro["Nota"].ToString());
        //                Item.SubItems.Add(registro["Observacao"].ToString());
        //                listView_Cadastro_Musicas.Items.Add(Item);
        //            }
        //        }
        //   }
        //}
    }
}
    
