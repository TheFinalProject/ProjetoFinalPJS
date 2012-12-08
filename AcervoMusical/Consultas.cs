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
                DateTime DataAlbum = Convert.ToDateTime(registro["Data_Album"]);
                DateTime DataCompra = Convert.ToDateTime(registro["Data_Compra"]);
                if (checkBox_Nome.Checked)
                {
                    if (registro.RowState != DataRowState.Deleted && registro["Nome_Musica"].ToString() != textBox_Nome.Text)
                    {
                        registro.Delete();
                    }
                }
                if (checkBox_Interprete.Checked)
                {
                    if (registro.RowState != DataRowState.Deleted && registro["Nome_Interprete"].ToString() != textBox_Interprete.Text)
                    {
                        registro.Delete();
                    }
                }
                if (checkBox_Autor.Checked)
                {
                    if(registro.RowState != DataRowState.Deleted && registro["Nome_Autor"].ToString() != textBox_Autor.Text)
                    {
                        registro.Delete();
                    }
                }
                if(checkBox_Album.Checked)
                {
                    if(registro.RowState != DataRowState.Deleted && registro["Nome_Album"].ToString() != textBox_Album.Text)
                    {
                        registro.Delete();
                    }
                }
                if (checkBox_OrigemCompra.Checked)
                {
                    if (registro.RowState != DataRowState.Deleted && registro["Origem_Compra"].ToString() != textBox_OrigemCompra.Text)
                    {
                        registro.Delete();
                    }
                }
                if (checkBox_Midia.Checked)
                {
                    if (registro.RowState != DataRowState.Deleted && registro["Tipo_Midia"].ToString() != comboBox_Midia.Text)
                    {
                        registro.Delete();
                    }
                }
                if (checkBox_Nota.Checked)
                {
                    if (registro.RowState != DataRowState.Deleted && registro["Nota"].ToString() != comboBox_Nota.Text)
                    {
                        registro.Delete();
                    }
                }
                //   //Superior a data de album
                //if (checkBox_DataAlbum.Checked)
                //    if (registro.RowState != DataRowState.Deleted && DataAlbum < dateTimePicker_Album.Value)
                //        registro.Delete();

                //    //Inferior a data de album
                //if (checkBox_dataAlbum1.Checked)
                //    if (registro.RowState != DataRowState.Deleted && DataAlbum > dateTimePickerDataAlbum1.Value)
                //        registro.Delete();

                //    //Superior a data da compra
                //if (checkBox_dataCompra.Checked)
                //    if (registro.RowState != DataRowState.Deleted && DataCompra < dateTimeDataCompra.Value)
                //        registro.Delete();

                //    //Inferior a data de album
                //if (checkBoxDataCompra1.Checked)
                //    if (registro.RowState != DataRowState.Deleted && DataCompra > dateTimePickerDataCompra1.Value)
                //        registro.Delete();
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

            //SqlDataReader LeitorBusca;

            //ListViewItem PreencheMusicas = new ListViewItem();

            //try
            //{
            //    SqlCommand CmdBuscar = new SqlCommand("SELECT * From Musicas WHERE Nome_Musica = @NomeMusica",FP.Conector.Conexao);

            //    SqlParameter NomeMusica = new SqlParameter();
            //    NomeMusica.Value = textBox_Nome.Text;
            //    NomeMusica.SourceColumn = "Nome_Musica";
            //    NomeMusica.ParameterName = "@NomeMusica";
            //    NomeMusica.SqlDbType = SqlDbType.VarChar;
            //    NomeMusica.Size = 50;

            //    CmdBuscar.Parameters.Add(NomeMusica);
            //    LeitorBusca = CmdBuscar.ExecuteReader();
            //    listView_ConsultaMusicas.Clear();

            //    while (LeitorBusca.Read())
            //    {

            //        PreencheMusicas.Text = LeitorBusca["Nome_Musica"].ToString();
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Tipo_Midia"].ToString());
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Album"].ToString());
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Autor"].ToString());
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Interprete"].ToString());
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Nota"].ToString());
            //        PreencheMusicas.SubItems.Add(LeitorBusca["Observacao"].ToString());
                    
        }     

            //        listView_ConsultaMusicas.Items.Add(PreencheMusicas);
 
        //        LeitorBusca.Close();
        //    }
        //    catch (SqlException erro)
        //    {
        //        MessageBox.Show(erro.Message);

        //    }
        //    finally
        //    {
        //        FP.Conector.Desconectar();
        //    }
        //}

        private void Consultas_Load(object sender, EventArgs e)
        {
            FiltrarTodasMusicas();
            //foreach (DataRow registro in ChamarMusicas.Tables["Musicas"].Rows)
            //{
            //    MusicasFiltro.Text = registro["Nome_Musica"].ToString();
            //    MusicasFiltro.SubItems.Add(registro["Tipo_Midia"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Nome_Album"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Nome_Autor"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Nome_Interprete"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Data_Album"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Data_Compra"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Origem_Compra"].ToString());
            //    MusicasFiltro.SubItems.Add(registro["Nota"].ToString());
            //    listView_ConsultaMusicas.Items.Add(MusicasFiltro);
            //}
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
            FiltrarTodasMusicas();
        }

    }
}
