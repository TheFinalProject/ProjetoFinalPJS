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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        Class_DataSet DatasetPesqAmigos = new Class_DataSet();
        public FormPrincipal FP;

        private void Agenda_Load(object sender, EventArgs e)
        {
            DatasetPesqAmigos.PreencheAmigos();
            foreach (DataRow registro in DatasetPesqAmigos.Dados.Tables["AmigosCompletos"].Rows)
            {
                ListViewItem Amigos = new ListViewItem();
                Amigos.Text = registro["Nome"].ToString();
                Amigos.SubItems.Add(registro["Telefone"].ToString());
                Amigos.SubItems.Add(registro["Email"].ToString());
                listView_AgendaAmigos.Items.Add(Amigos);

            }
            foreach (ListViewItem item in listView_AgendaAmigos.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = Color.Gainsboro;
                }
                else
                {
                    item.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void button_BuscarAmigo_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox_PesquisaAmigo_TextChanged(object sender, EventArgs e)
        {
            FP.Conector.Conectar();
            DataSet DataFiltro = new DataSet();

            SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("SELECT * FROM Amigos", FP.Conector.Conexao);
            AdaptadorFiltro.Fill(DataFiltro, "Amigos");
            DataTable TabelaFiltro = DataFiltro.Tables["Amigos"];


            //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar, pois nao consegue ter 2 valores em 2 listviews. 
            foreach (DataRow registro in DataFiltro.Tables["Amigos"].Rows)
            {

                if (textBox_PesquisaAmigo.Text != "")
                {
                    if (registro.RowState != DataRowState.Deleted && !registro["Nome"].ToString().ToUpper().Contains(textBox_PesquisaAmigo.Text.ToUpper()))
                    {
                        registro.Delete();
                    }
                }
            }

            listView_AgendaAmigos.Items.Clear();

            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriMusicas = new ListViewItem();
                    InseriMusicas.Text = RegistroMusicas["Nome"].ToString();
                    InseriMusicas.SubItems.Add(RegistroMusicas["Telefone"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Email"].ToString());
                    listView_AgendaAmigos.Items.Add(InseriMusicas);
                }
            }
        }
    }
}
