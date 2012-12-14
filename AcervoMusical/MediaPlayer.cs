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
    public partial class MediaPlayer : Form
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        public FormPrincipal FP;
        //Variavel usada para adicionar musicas máximo 1000.
        string[] Musicas = new string[1000];
        int cont;

        private void MediaPlayer_Load(object sender, EventArgs e)
        {
            panel_MediaPlayer.BackColor = FP.BackColor;
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (button_Play.Text == "PLAY")
            //Quando der play ele vai tocar a musica, caso o listbox tenha 1 musica selecionado, caso nao tenha ele nao executará nenhuma ação
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                if (listBox_Musicas.SelectedItems.Count > 0)
                {
                    WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];
                    timer_tempo.Start();
                    button_Play.Text = "PAUSE";
                }
            }
            else if (button_Play.Text == "PAUSE")
            {
                WindowsMediaPlayer.Ctlcontrols.pause();
                button_Play.Text = "RESUME";
            }
            else if (button_Play.Text == "RESUME")
            {
                WindowsMediaPlayer.Ctlcontrols.play();
                button_Play.Text = "PAUSE";
            }
        }
            
        private void button_Add_Click(object sender, EventArgs e)
        {
            //Abrirá a janela de procura do windows, que possibilitará abrir musicas do seu computador para ouvir durante a execução do programa
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                //Conta quantas musicas vc adicionou e percorre uma por uma, organizando-as no listBox. 
                for (int i = 0; i < open.FileNames.LongLength; ++i)
                {
                    //Verifica se o que voce abriu contem o valor passado no listbox. e se for falso. ele conta mais uma musica e adiciona no listbox
                    if (listBox_Musicas.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        listBox_Musicas.Items.Add(open.SafeFileNames.GetValue(i));
                        Musicas[cont] = open.FileNames.GetValue(i).ToString();
                        cont++;
                    }
                }
                if (listBox_Musicas.SelectedIndex < 0)
                {
                    listBox_Musicas.SetSelected(0, true);

                }
            }
        }

        private void button_Pause_Click(object sender, EventArgs e)
        {
            //Pausará a musica no instante em que ela está!
            WindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            //Parará a Musica e retomará do inicio.
            WindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void button_Resume_Click(object sender, EventArgs e)
        {
            //Continuará a tocar uma musica cuja foi pausada do mesmo ponto.
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button_Primeiro_Click(object sender, EventArgs e)
        {
            //Verifica se o item selecionado eh maior que 0 se for, ele te joga para a primeira posição do listbox, fazendo tocar a primeira musica!
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                listBox_Musicas.SetSelected(0, true);
                WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];
            }
        }

        private void button_anterior_Click(object sender, EventArgs e)
        {
            //Verifica se tem itens selecionados. caso tenha verifica se o indice é diferente de 0 se for, ele te joga pra musica anterior.
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                if (listBox_Musicas.SelectedIndex != 0)
                {
                    listBox_Musicas.SetSelected(listBox_Musicas.SelectedIndex - 1, true);
                    WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];

                }
            }
        }

        private void button_proximo_Click(object sender, EventArgs e)
        {
            //Verifica se há item selecionado caso tenha, verifica se o indice é diferente do total de musicas - 1 ou seja a ultima, se nao for ele te joga para a proxima musica.
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                if (listBox_Musicas.SelectedIndex != listBox_Musicas.Items.Count - 1)
                {
                    listBox_Musicas.SetSelected(listBox_Musicas.SelectedIndex + 1, true);
                    WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];

                }
            }
        }

        private void button_ultimo_Click(object sender, EventArgs e)
        {
            //Verifica se o item selecionado eh maior que 0 se for, ele te joga para a ultima posição do listbox, fazendo tocar a ultima musica!
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                listBox_Musicas.SetSelected(listBox_Musicas.Items.Count - 1, true);
                WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];
            }
        }

        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.volume = trackBar_Volume.Value;
        }

    }
}
