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
                Amigos.SubItems.Add(registro["Endereço"].ToString());
                Amigos.SubItems.Add(registro["Numero"].ToString());
                Amigos.SubItems.Add(registro["Bairro"].ToString());
                Amigos.SubItems.Add(registro["Email"].ToString());
                Amigos.SubItems.Add(registro["NomeCidade"].ToString());
                Amigos.SubItems.Add(registro["CidadeId_uf"].ToString());
                listView_AgendaAmigos.Items.Add(Amigos);
            }
        }

        private void button_BuscarAmigo_Click(object sender, EventArgs e)
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
                    if (registro.RowState != DataRowState.Deleted && registro["Nome"].ToString() != textBox_PesquisaAmigo.Text)
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
                    InseriMusicas.SubItems.Add(RegistroMusicas["Endereço"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Numero"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Bairro"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["Email"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["AmigosId_Cidade"].ToString());
                    InseriMusicas.SubItems.Add(RegistroMusicas["AmigosId_Estado"].ToString());

                    listView_AgendaAmigos.Items.Add(InseriMusicas);
                }
            }
        }
    }
}
