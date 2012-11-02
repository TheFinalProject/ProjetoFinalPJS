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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Entrar_Click(object sender, EventArgs e)
        {
            FormPrincipal abrir_principal = new FormPrincipal();
            abrir_principal.Show();

        }

        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
