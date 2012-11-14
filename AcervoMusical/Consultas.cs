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

        private void panel1_Enter(object sender, EventArgs e)
        {
            panel1.Width= 600;
            panel1.Height = 800;
        }

        private void panel1_Leave(object sender, EventArgs e)
        {
            panel1.Width = 100;
            panel1.Height = 200;
        }

        private void panel3_Enter(object sender, EventArgs e)
        {
            panel3.Width = 600;
            panel3.Height = 800;
        }

        private void panel3_Leave(object sender, EventArgs e)
        {
            panel3.Width = 100;
            panel3.Height = 200;
        }
    }
}
