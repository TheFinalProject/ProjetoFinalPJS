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

            AutoCompleteStringCollection DadosComboboxAmigos = new AutoCompleteStringCollection();
            AutoCompleteStringCollection DadosComboboxMusicas = new AutoCompleteStringCollection();

            DatasetEmprestimos.PreencheAmigos();
            DatasetEmprestimos.PreencheMusicas();

            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["AmigosCompletos"].Rows)
            {
                    comboBox_NomeAmigos.Items.Add(registro["Nome"]);
                    DadosComboboxAmigos.Add(registro["Nome"].ToString());
                    comboBox_NomeAmigos.AutoCompleteCustomSource = DadosComboboxAmigos;
            }
            foreach (DataRow registro in DatasetEmprestimos.Dados.Tables["MusicasCompletas"].Rows)
            {
                int ContadorDeRegistros = registro.ItemArray.Count();
                if (ContadorDeRegistros > 0)
                {
                    if (registro["Tipo_Midia"].ToString() != "Digital")
                    {
                        comboBox_NomeMusicas.Items.Add(registro["Nome_Album"]);
                        DadosComboboxMusicas.Add(registro["Nome_Album"].ToString());
                        comboBox_NomeMusicas.AutoCompleteCustomSource = DadosComboboxMusicas;
                    }
                }
                else
                    comboBox_NomeMusicas.Text = "Nao ha midias para emprestimo";
            }
        }
    }
}
