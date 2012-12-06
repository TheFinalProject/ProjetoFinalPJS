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
    public partial class Emprestimos : Form
    {
        public Emprestimos()
        {
            InitializeComponent();
        }

        public FormPrincipal FP;

        private void Emprestimos_Load(object sender, EventArgs e)
        {
            Class_DataSet DatasetEmprestimos = new Class_DataSet();
            AutoCompleteStringCollection Dados = new AutoCompleteStringCollection();

            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
            {
                Dados.Add(registro["Nome"].ToString());
            }
        }

        private void comboBox_NomeAmigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_NomeAmigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_NomeAmigo.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
            comboBox_NomeAmigo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

//                comboBox1.AutoCompleteSource = AutoCompleteSource.AllSystemSources;
//comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend; 
        }
    }
}
