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
    public partial class ConfiguracoesGerais : Form
    {
        FormPrincipal Principal;

        public ConfiguracoesGerais(FormPrincipal FrmPrincipal)
        {
            InitializeComponent();
            Principal = FrmPrincipal;
        }

        public FormPrincipal FP;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_cores.Text == "Rosa")
            {
                Principal.BackColor = System.Drawing.Color.Pink;
                Principal.Refresh();
            }
            else if(comboBox_cores.Text == "Vermelho")
            {
                Principal.BackColor = System.Drawing.Color.Red;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Azul")
            {
                Principal.BackColor = System.Drawing.Color.Navy;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Roxo")
            {
                Principal.BackColor = System.Drawing.Color.Purple;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Amarelo")
            {
                Principal.BackColor = System.Drawing.Color.Yellow;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Verde")
            {
                Principal.BackColor = System.Drawing.Color.Green;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Preto")
            {
                Principal.BackColor = System.Drawing.Color.Black;
                Principal.Refresh();
            }
            else if (comboBox_cores.Text == "Branco")
            {
                Principal.BackColor = System.Drawing.Color.White;
                Principal.Refresh();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ConfiguracoesGerais_Load(object sender, EventArgs e)
        {

        }
    }
}
