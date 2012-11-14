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
    public partial class CadastroMusicas : Form
    {
        public CadastroMusicas()
        {
            InitializeComponent();
        }

        private void comboBox_Midia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Midia.SelectedItem.ToString() == "Digital")
            {
                label_Musica.Visible = true;
                textBox_Musicas.Visible = true;
            }
            else
            {
                label_Musica.Visible = false;
                textBox_Musicas.Visible = false;
            }
        }



    }
}
