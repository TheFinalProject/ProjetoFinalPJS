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
        public Consultas()
        {
            InitializeComponent();
        }

        public FormPrincipal FP;

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FP.Conector.Conectar();
            SqlDataReader LeitorBusca;

            ListViewItem PreencheMusicas = new ListViewItem();

            try
            {
                SqlCommand CmdBuscar = new SqlCommand("SELECT * From Musicas WHERE Nome_Musica = @NomeMusica",FP.Conector.Conexao);

                SqlParameter NomeMusica = new SqlParameter();
                NomeMusica.Value = textBox_Nome.Text;
                NomeMusica.SourceColumn = "Nome_Musica";
                NomeMusica.ParameterName = "@NomeMusica";
                NomeMusica.SqlDbType = SqlDbType.VarChar;
                NomeMusica.Size = 50;

                CmdBuscar.Parameters.Add(NomeMusica);
                LeitorBusca = CmdBuscar.ExecuteReader();
                listView_ConsultaMusicas.Clear();

                while (LeitorBusca.Read())
                {
                    PreencheMusicas.Text = LeitorBusca["Nome_Musica"].ToString();
                    PreencheMusicas.SubItems.Add(LeitorBusca["Tipo_Midia"].ToString());
                    PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Album"].ToString());
                    PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Autor"].ToString());
                    PreencheMusicas.SubItems.Add(LeitorBusca["Nome_Interprete"].ToString());
                    PreencheMusicas.SubItems.Add(LeitorBusca["Nota"].ToString());
                    PreencheMusicas.SubItems.Add(LeitorBusca["Observacao"].ToString());

                    listView_ConsultaMusicas.Items.Add(PreencheMusicas);
                    
                }

                LeitorBusca.Close();
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

        private void Consultas_Load(object sender, EventArgs e)
        {
             Class_DataSet ConsultaMusicas = new Class_DataSet();
            ConsultaMusicas.PreencheMusicas();
            #region ListView de Musicas
            foreach (DataRow registro in ConsultaMusicas.Dados.Tables["MusicasCompletas"].Rows)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = registro["Nome_Musica"].ToString();
                Item.SubItems.Add(registro["Tipo_Midia"].ToString());
                Item.SubItems.Add(registro["Nome_Album"].ToString());
                Item.SubItems.Add(registro["Nome_Autor"].ToString());
                Item.SubItems.Add(registro["Nome_Interprete"].ToString());
                Item.SubItems.Add(registro["Nota"].ToString());
                Item.SubItems.Add(registro["Observacao"].ToString());
                listView_ConsultaMusicas.Items.Add(Item);
            }
            #endregion
        }
    }
}
