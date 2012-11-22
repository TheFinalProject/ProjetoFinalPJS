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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroMusicas CadastroMusica = new CadastroMusicas();
            CadastroMusica.MdiParent = this;
            CadastroMusica.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroAmigos CadastroAmigo = new CadastroAmigos();
            CadastroAmigo.MdiParent = this;
            CadastroAmigo.Show();
        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void button_Musicas_Click(object sender, EventArgs e)
        {
            new CadastroMusicas().ShowDialog();
        }

        private void button_Amigos_Click(object sender, EventArgs e)
        {
            new CadastroAmigos().ShowDialog();
        }

        private void button_Consultas_Click(object sender, EventArgs e)
        {
            new Consultas().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }
}
