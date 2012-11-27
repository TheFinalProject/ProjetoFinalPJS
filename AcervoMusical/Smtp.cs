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
    public partial class Smtp : Form
    {
        
        public Smtp()
        {
            InitializeComponent();
        }

        private void listView_smtp_DoubleClick(object sender, EventArgs e)
        {
            string Valor;
            Valor = listView_smtp.SelectedItems[0].SubItems[1].ToString();
            ConfiguracoesUsuario ConfigUser = new ConfiguracoesUsuario(Valor);
            this.Close();
        }

        private void listView_smtp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
