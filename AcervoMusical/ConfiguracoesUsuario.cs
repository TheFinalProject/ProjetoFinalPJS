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
    public partial class ConfiguracoesUsuario : Form
    {

        public ConfiguracoesUsuario(string SmtpSelecionado)
        {
            InitializeComponent();
            textBox_smtp.Text = SmtpSelecionado;
        }

        public FormPrincipal FP;

        private void label8_Click(object sender, EventArgs e)
        {
           new Smtp().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Habilitar.Checked == true)
            {
                textBox_Senha.Visible = true;
                label_Senha.Visible = true;
                label_MaxChar.Visible = true;
            }
            else
            {
                textBox_Senha.Visible = false;
                label_Senha.Visible = false;
                label_MaxChar.Visible = false;
            }

        }

        private void ConfiguracoesUsuario_Load(object sender, EventArgs e)
        {
            panel_Usuario.BackColor = FP.BackColor;
        }
    }
}
