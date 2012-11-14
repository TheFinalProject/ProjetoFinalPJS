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
    public partial class CadastroAmigos : Form
    {
        public CadastroAmigos()
        {
            InitializeComponent();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroAmigos_FormClosing(object sender, FormClosingEventArgs e)
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
            }
            if (soma > 0)
            {
                if (MessageBox.Show("O Formulário contém dados não salvos, deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}