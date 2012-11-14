using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AcervoMusical
{
    public partial class Login : Form
    {

        
       
        
        public Login()
        {
            InitializeComponent();
        }

        
        private void button_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
