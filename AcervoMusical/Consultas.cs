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
        Class_DataSet DataSetFiltro = new Class_DataSet();
        public Consultas()
        {
            InitializeComponent();
            //construtor do form de consultas que carrega os valores das musicasdo banco de dados no listview
            DataSetFiltro.PreencheMusicas();
            DataSetFiltro.PreencheEmprestimos();
        }

        public FormPrincipal FP;

        private void button1_Click(object sender, EventArgs e)
        {

            //FP.Conector.Conectar();
            //DataSet DataFiltro = new DataSet();

            //SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("SELECT * FROM Musicas", FP.Conector.Conexao);
            //AdaptadorFiltro.Fill(DataFiltro, "Musicas");
            //DataTable TabelaFiltro = DataFiltro.Tables["Musicas"];


            ////Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar, pois nao consegue ter 2 valores em 2 listviews. 
            //foreach (DataRow registro in DataFiltro.Tables["Musicas"].Rows)
            //{
            //    DateTime Data_Album = Convert.ToDateTime(registro["Data_Album"]);
            //    if (registro.RowState != DataRowState.Deleted && Data_Album != dateTimePicker_Album.Value)
            //        registro.Delete();
            //}

            //listView_ConsultaMusicas.Items.Clear();

            //for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            //{
            //    DataRow RegistroMusicas = TabelaFiltro.Rows[i];
            //    // Somente as linhas que não foram deletadas
            //    if (RegistroMusicas.RowState != DataRowState.Deleted)
            //    {
            //        // Define os itens da lista
            //        ListViewItem InseriMusicas = new ListViewItem();
            //        InseriMusicas.Text = RegistroMusicas["Nome_Musica"].ToString();
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Tipo_Midia"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Album"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Autor"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Nome_Interprete"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Data_Album"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Data_Compra"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Origem_Compra"].ToString());
            //        InseriMusicas.SubItems.Add(RegistroMusicas["Nota"].ToString());

            //        listView_ConsultaMusicas.Items.Add(InseriMusicas);
            //    }
            //}
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            FiltrarTodasMusicas();
            panel_Consulta.BackColor = FP.BackColor;
            //FiltraEmprestimos();

        }
        //metodo que puxa sempre todas as musicas do dataset e preenche o listview do formulario de consultas
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

        public void FiltraEmprestimos()
        {
            DataSet ChamarEmprestimos = new DataSet();

            SqlDataAdapter AdaptadorEmprestimos = new SqlDataAdapter("SELECT * FROM Emprestimos", FP.Conector.Conexao);

            AdaptadorEmprestimos.Fill(ChamarEmprestimos, "Emprestimos");

            DataTable TabelaFiltroEmprestimos = ChamarEmprestimos.Tables["Emprestimos"];

            // ListViewItem MusicasFiltro = new ListViewItem();
            for (int i = 0; i < TabelaFiltroEmprestimos.Rows.Count; i++)
            {
                DataRow RegistroMusicas = TabelaFiltroEmprestimos.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroMusicas.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriEmprestimos = new ListViewItem();
                    InseriEmprestimos.Text = RegistroMusicas["EmprestimosId_Amigo"].ToString();
                    InseriEmprestimos.SubItems.Add(RegistroMusicas["EmprestimosTipo_Midia"].ToString());
                    InseriEmprestimos.SubItems.Add(RegistroMusicas["Data_Devolucao"].ToString());
                    InseriEmprestimos.SubItems.Add(RegistroMusicas["Data_Emprestimo"].ToString());
                    listView_ConsultaEmprestimos.Items.Add(InseriEmprestimos);
                }
            }
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
                string Teste = registro["Nome_Album"].ToString();

                #region condições de consulta
                if (textBox_Interprete.Text != string.Empty && !registro["Nome_Interprete"].ToString().ToUpper().Contains(textBox_Interprete.Text.ToUpper()) || textBox_Autor.Text != string.Empty && !registro["Nome_Autor"].ToString().ToUpper().Contains(textBox_Autor.Text.ToUpper()) || textBox_Album.Text != string.Empty && !registro["Nome_Album"].ToString().ToUpper().Contains(textBox_Album.Text.ToUpper()) || textBox_Nome.Text != string.Empty && !registro["Nome_Musica"].ToString().ToUpper().Contains(textBox_Nome.Text.ToUpper()) || textBox_OrigemCompra.Text != string.Empty && !registro["Origem_Compra"].ToString().ToUpper().Contains(textBox_OrigemCompra.Text.ToUpper()) || comboBox_Midia.Text != string.Empty && !registro["Tipo_Midia"].ToString().ToUpper().Contains(comboBox_Midia.Text.ToUpper()) || (!(checkBox_QualquerData.Checked) || !(DateTime.Parse(dateTimePicker_Album.Value.ToShortDateString()) >= DateTime.Parse(registro["Data_Album"].ToString()) && DateTime.Parse(dateTimePicker_AteAlbum.Value.ToShortDateString()) >= DateTime.Parse(registro["Data_Album"].ToString()) || DateTime.Parse(dateTimePicker_Compra.Value.ToShortDateString()) >= DateTime.Parse(registro["Data_Compra"].ToString()) && DateTime.Parse(dateTimePicker_AteCompra.Value.ToShortDateString()) >= DateTime.Parse(registro["Data_Compra"].ToString()))) || comboBox_Nota.Text != string.Empty && !registro["Nota"].ToString().ToUpper().Contains(comboBox_Nota.Text.ToUpper()))
                {
                    registro.Delete();
                }
                #endregion
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
            FP.Conector.Desconectar();
        }

        //private void textBox_NomeEmprestimo_TextChanged(object sender, EventArgs e)
        //{
        //    FP.Conector.Conectar();
        //    DataSet DataFiltro = new DataSet();
        //    SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("Select Amigos.Nome, Amigos.Telefone, Amigos.Endereço, Amigos.Numero, Amigos.Email,Amigos.Bairro, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade", FP.Conector.Conexao);
        //    AdaptadorFiltro.Fill(DataFiltro, "Amigos");
        //    DataTable TabelaFiltro = DataFiltro.Tables["Amigos"];

        //    //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar. 
        //    foreach (DataRow registro in DataFiltro.Tables["Amigos"].Rows)
        //    {
        //        if (registro.RowState != DataRowState.Deleted && !registro["Nome"].ToString().ToUpper().Contains(textBox_Remover.Text.ToUpper()))
        //        {
        //            registro.Delete();
        //        }
        //    }

        //    listView_CadastroAmigos.Items.Clear();

        //    for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
        //    {
        //        DataRow RegistroAmigos = TabelaFiltro.Rows[i];
        //        // Somente as linhas que não foram deletadas
        //        if (RegistroAmigos.RowState != DataRowState.Deleted)
        //        {
        //            // Define os itens da lista
        //            ListViewItem InseriAmigos = new ListViewItem();

        //            InseriAmigos.Text = RegistroAmigos["Nome"].ToString();
        //            InseriAmigos.SubItems.Add(RegistroAmigos["Telefone"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["Endereço"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["Numero"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["Bairro"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["Email"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["NomeCidade"].ToString());
        //            InseriAmigos.SubItems.Add(RegistroAmigos["CidadeId_uf"].ToString());
        //            listView_CadastroAmigos.Items.Add(InseriAmigos);
        //        }
        //    }
        //    FP.Conector.Desconectar();
        //}

        private void tabPage_Emprestimos_Enter(object sender, EventArgs e)
        {
            listView_ConsultaEmprestimos.Items.Clear();
            foreach (DataRow Registro in DataSetFiltro.Dados.Tables["EmprestimosCompletos"].Rows)
            {
                if ((Registro["Status"].ToString() == "True") && (Registro["Data_Devolucao"].ToString() == ""))
                {
                    ListViewItem ListaEmprestimos = new ListViewItem();
                    ListaEmprestimos.Text = Registro["Nome"].ToString();
                    ListaEmprestimos.SubItems.Add(Registro["EmprestimosTipo_Midia"].ToString());
                    ListaEmprestimos.SubItems.Add(Registro["Nome_Album"].ToString());
                    ListaEmprestimos.SubItems.Add(Registro["Data_Emprestimo"].ToString());
                    listView_ConsultaEmprestimos.Items.Add(ListaEmprestimos);
                }
            }
        }

        private void textBox_NomeEmprestimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            DataSetFiltro.PreencheEmprestimos();
            listView_ConsultaDevolucoes.Items.Clear();
            foreach (DataRow Registro in DataSetFiltro.Dados.Tables["EmprestimosCompletos"].Rows)
            {
                if ((Registro["Status"].ToString() == "false") && (Registro["Data_Devolucao"].ToString() != ""))
                {
                    ListViewItem ListaDevolucoes = new ListViewItem();
                    ListaDevolucoes.Text = Registro["Nome"].ToString();
                    ListaDevolucoes.SubItems.Add(Registro["EmprestimosTipo_Midia"].ToString());
                    ListaDevolucoes.SubItems.Add(Registro["Nome_Album"].ToString());
                    ListaDevolucoes.SubItems.Add(Registro["Data_Devolucao"].ToString());
                    listView_ConsultaDevolucoes.Items.Add(ListaDevolucoes);
                }
            }
        }

    }
}
