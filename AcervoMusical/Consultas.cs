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
    public partial class Consultas : Form
    {
        //Class_DataSet DataSet_Filtro = new Class_DataSet();
        public Consultas()
        {
            InitializeComponent();
            //DataSet_Filtro.PreencheMusicas
        }

        public FormPrincipal FP;

        private void tabPage2_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            FP.Conector.Conectar();
            DataSet DataFiltro = new DataSet();

            SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("SELECT * FROM Musicas", FP.Conector.Conexao);
            AdaptadorFiltro.Fill(DataFiltro, "Musicas");
            DataTable TabelaFiltro = DataFiltro.Tables["Musicas"];


            //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar, pois nao consegue ter 2 valores em 2 listviews. 
            foreach (DataRow registro in DataFiltro.Tables["Musicas"].Rows)
            {
                //if (checkBox_Nome.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Nome_Musica"].ToString().ToUpper().Contains(textBox_Nome.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_Interprete.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Nome_Interprete"].ToString().ToUpper().Contains(textBox_Interprete.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_Autor.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Nome_Autor"].ToString().ToUpper().Contains(textBox_Autor.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_Album.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Nome_Album"].ToString().ToUpper().Contains(textBox_Album.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_OrigemCompra.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Origem_Compra"].ToString().ToUpper().Contains(textBox_OrigemCompra.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_Midia.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Tipo_Midia"].ToString().ToUpper().Contains(comboBox_Midia.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //if (checkBox_Nota.Checked)
                //{
                //    if (registro.RowState != DataRowState.Deleted && !registro["Nota"].ToString().ToUpper().Contains(comboBox_Nota.Text.ToUpper()))
                //    {
                //        registro.Delete();
                //    }
                //}
                //////Superior a data de album
                ////if (checkBox_DataAlbum.Checked)
                ////    if (registro.RowState != DataRowState.Deleted && DataAlbum < dateTimePicker_Album.Value)
                ////        registro.Delete();

                //////Inferior a data de album
                ////if (.Checked)
                ////    if (registro.RowState != DataRowState.Deleted && DataAlbum > dateTimePickerDataAlbum1.Value)
                ////        registro.Delete();

                //////Superior a data da compra
                ////if (checkBox_dataCompra.Checked)
                ////    if (registro.RowState != DataRowState.Deleted && DataCompra < dateTimeDataCompra.Value)
                ////        registro.Delete();

                //////Inferior a data de album
                ////if (checkBoxDataCompra1.Checked)
                ////    if (registro.RowState != DataRowState.Deleted && DataCompra > dateTimePickerDataCompra1.Value)
                ////        registro.Delete();
            }

            listView_ConsultaMusicas.Items.Clear();

            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriMusicas = new ListViewItem();
                    InseriMusicas.Text = RegistroMusicas["Nome_Musica"].ToString();
                    InseriMusicas.SubItems.Add(RegistroMusicas["Tipo_Midia"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Autor"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Interprete"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Origem_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nota"].ToString());

                    listView_ConsultaMusicas.Items.Add(InseriMusicas);
                }
            }
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            FiltrarTodasMusicas();
        }
        public void FiltrarTodasMusicas()
        {
            DataSet ChamarMusicas = new DataSet();

            SqlDataAdapter Adapta = new SqlDataAdapter("SELECT * FROM Musicas", FP.Conector.Conexao);

            Adapta.Fill(ChamarMusicas, "Musicas");

            DataTable TabelaFiltro = ChamarMusicas.Tables["Musicas"];

            // ListViewItem MusicasFiltro = new ListViewItem();
            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriMusicas = new ListViewItem();
                    InseriMusicas.Text = RegistroMusicas["Nome_Musica"].ToString();
                    InseriMusicas.SubItems.Add(RegistroMusicas["Tipo_Midia"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Autor"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Interprete"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Origem_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nota"].ToString());

                    listView_ConsultaMusicas.Items.Add(InseriMusicas);
                }
            }
        }

        private void button_TodasMusicas_Click(object sender, EventArgs e)
        {
            listView_ConsultaMusicas.Items.Clear();
            FiltrarTodasMusicas();
        }

        private void textBox_Nome_TextChanged(object sender, EventArgs e)
        {
            FP.Conector.Conectar();
            DataSet DataFiltro = new DataSet();

            SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("SELECT * FROM Musicas", FP.Conector.Conexao);
            AdaptadorFiltro.Fill(DataFiltro, "Musicas");
            DataTable TabelaFiltro = DataFiltro.Tables["Musicas"];


            //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar, pois nao consegue ter 2 valores em 2 listviews. 
            foreach (DataRow registro in DataFiltro.Tables["Musicas"].Rows)
            {

                if (textBox_Nome.Text != "")
                {
                    if (registro.RowState != DataRowState.Deleted && !registro["Nome_Musica"].ToString().ToUpper().Contains(textBox_Nome.Text.ToUpper()))
                    {
                        registro.Delete();
                    }
                }
            }
            listView_ConsultaMusicas.Items.Clear();

            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriMusicas = new ListViewItem();
                    InseriMusicas.Text = RegistroMusicas["Nome_Musica"].ToString();
                    InseriMusicas.SubItems.Add(RegistroMusicas["Tipo_Midia"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Autor"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Interprete"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Origem_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nota"].ToString());

                    listView_ConsultaMusicas.Items.Add(InseriMusicas);
                }
            }


            //listView_ConsultaMusicas.Items.Clear();

            //for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            //{
            //    DataRow RegistroMusicas = TabelaFiltro.Rows[i];
            //    // Somente as linhas que não foram deletadas
            //    if (RegistroMusicas.RowState != DataRowState.Deleted)
            //    {
            //        // Define os itens da lista
            //        ListViewItem InseriMusicas = new ListViewItem();
            //        InseriMusicas.Text = RegistroMusicas["Nome"].ToString();
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Telefone"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Email"].ToString());
            //        listView_AgendaAmigos.Items.Add(InseriMusicas);
            //    }
            //}   
        }

        private void textBox_Interprete_TextChanged(object sender, EventArgs e)
        {

            FP.Conector.Conectar();
            DataSet DataFiltro = new DataSet();

            SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("SELECT * FROM Musicas", FP.Conector.Conexao);
            AdaptadorFiltro.Fill(DataFiltro, "Musicas");
            DataTable TabelaFiltro = DataFiltro.Tables["Musicas"];

            //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar, pois nao consegue ter 2 valores em 2 listviews. 
            foreach (DataRow registro in DataFiltro.Tables["Musicas"].Rows)
            {

                if (textBox_Interprete.Text != string.Empty && !registro["Nome_Interprete"].ToString().ToUpper().Contains(textBox_Interprete.Text.ToUpper()) || textBox_Autor.Text != string.Empty && !registro["Nome_Autor"].ToString().ToUpper().Contains(textBox_Autor.Text.ToUpper()) || textBox_Album.Text != string.Empty && !registro["Nome_Album"].ToString().ToUpper().Contains(textBox_Album.Text.ToUpper())||textBox_Nome.Text != string.Empty && !registro["Nome_Musica"].ToString().ToUpper().Contains(textBox_Nome.Text.ToUpper()))
                {
                    registro.Delete();
                }
            }

            listView_ConsultaMusicas.Items.Clear();
            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriMusicas = new ListViewItem();
                    InseriMusicas.Text = RegistroMusicas["Nome_Musica"].ToString();
                    InseriMusicas.SubItems.Add(RegistroMusicas["Tipo_Midia"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Autor"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Interprete"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Album"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Data_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Origem_Compra"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Nota"].ToString());

                    listView_ConsultaMusicas.Items.Add(InseriMusicas);
                }
            }
        }

    }
}
