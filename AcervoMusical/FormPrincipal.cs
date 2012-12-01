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
    public partial class FormPrincipal : Form
    {
        public Class_Conexão Conector = new Class_Conexão();

        public FormPrincipal()
        {
            InitializeComponent();
        }
              
        
        //Variaveis para controle de Posicionamento
        bool Mover;
        Point Inicial;

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Mover = true;
                Inicial = e.Location;
            }
            if (sender is ListView)
            {
                Mover = true;
                Inicial = e.Location;
            }
            if (sender is Panel)
            {
                Mover = true;
                Inicial = e.Location;
            } 
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button)
                Mover = false;
            if (sender is ListView)
                Mover = false;
            if(sender is Panel)
                Mover = false;                    
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            #region "Condições que verificam qual Objeto será mudado de lugar"
            if (sender is Button)
            {
                Button BotaoSelecionado = (Button)sender;
                if (Mover == true)
                {
                    if ((BotaoSelecionado.Left + (e.X - Inicial.X) >= 0 && BotaoSelecionado.Right + (e.X - Inicial.X) <= this.Width - 4) && (BotaoSelecionado.Top + (e.Y - Inicial.Y) >= 0 && BotaoSelecionado.Bottom + (e.Y - Inicial.Y) <= this.Height - 32))
                    {
                        BotaoSelecionado.Location = new Point(BotaoSelecionado.Left + (e.X - Inicial.X), BotaoSelecionado.Top + (e.Y - Inicial.Y));
                    }
                }
            }
            else if (sender is ListView)
            {
                ListView LisviewSelecionado = (ListView)sender;
                if (Mover == true)
                {
                    if ((LisviewSelecionado.Left + (e.X - Inicial.X) >= 0 && LisviewSelecionado.Right + (e.X - Inicial.X) <= this.Width - 4) && (LisviewSelecionado.Top + (e.Y - Inicial.Y) >= 0 && LisviewSelecionado.Bottom + (e.Y - Inicial.Y) <= this.Height - 32))
                    {
                        LisviewSelecionado.Location = new Point(LisviewSelecionado.Left + (e.X - Inicial.X), LisviewSelecionado.Top + (e.Y - Inicial.Y));
                    }
                }
            }
            else if (sender is Panel)
            {
                Panel PanelSelecionado = (Panel)sender;
                if (Mover == true)
                {
                    if ((PanelSelecionado.Left + (e.X - Inicial.X) >= 0 && PanelSelecionado.Right + (e.X - Inicial.X) <= this.Width - 4) && (PanelSelecionado.Top + (e.Y - Inicial.Y) >= 0 && PanelSelecionado.Bottom + (e.Y - Inicial.Y) <= this.Height - 32))
                    {
                        PanelSelecionado.Location = new Point(PanelSelecionado.Left + (e.X - Inicial.X), PanelSelecionado.Top + (e.Y - Inicial.Y));
                    }
                }
            }
            #endregion
        }
        public void Mostrar_texto(object sender, EventArgs e)
        {
            if (sender == pictureBox_Login)
                label_login.Visible = true;
            else if (sender == pictureBox_ferramentas)
                label_Ferramentas.Visible = true;
        }

        public void Esconder_texto(object sender, EventArgs e)
        {
            label_login.Visible = false;
            label_Ferramentas.Visible = false;
        }

        private void Abrir_Fomulario(object sender, EventArgs e)
        {
            if (sender == button_Agenda)
            {
                Agenda AG = new Agenda();
                AG.FP = this;
                AG.Show();
            }
            else if (sender == button_Consultas)
            {
                Consultas CO = new Consultas();
                CO.FP = this;
                CO.Show();
            }
            else if (sender == button_Emprestimos)
            {
                Emprestimos EM = new Emprestimos();
                EM.FP = this;
                EM.Show();
            }
            else if (sender == button_MediaPlayer)
            {
                MediaPlayer MP = new MediaPlayer();
                MP.FP = this;
                MP.Show();
            }
            else if (sender == button_Mubox)
            {
                Mubox MU = new Mubox();
                MU.FP = this;
                MU.Show();
            }
            else if (sender == button_Musicas)
            {
                CadastroMusicas CM = new CadastroMusicas();
                CM.FP = this;
                CM.Show();
            }
            else if (sender == button_Amigos)
            {
                CadastroAmigos CA = new CadastroAmigos();
                CA.FP = this;
                CA.Show();
            }
            else if (sender == pictureBox_Login)
            {
                ConfiguracoesUsuario CU = new ConfiguracoesUsuario("");
                CU.FP = this;
                CU.Show();
            }
            else if (sender == pictureBox_ferramentas)
            {
                ConfiguracoesGerais CG = new ConfiguracoesGerais(this);
                CG.FP = this;
                CG.Show();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer_Relogio.Start();
            Conector.Conectar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label_relogio.Text = DateTime.Now.ToLongTimeString();
            //label_Data.Text = DateTime.Now.ToShortDateString();
            //label_DiaSemana.Text = DateTime.Now.DayOfWeek.ToString();
        }
    }
}
