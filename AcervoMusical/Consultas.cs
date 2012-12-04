using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            
            Class_DataSet ConsultaMusicas = new Class_DataSet();
            ConsultaMusicas.PreencheMusicas();
            #region ListView de Musicas
            foreach (DataRow registro in ConsultaMusicas.Dados.Tables["MusicasCompletas"].Rows)
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = registro["Nome_Musica"].ToString();
                //Item.Group = registro["Tipo_Midia"].ToString();
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
