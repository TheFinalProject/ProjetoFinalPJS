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
        string[] Musicas = new string[1000];
        int cont;

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];
                timer_tempo.Start();
            }
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; ++i)
                {
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
            WindowsMediaPlayer.Ctlcontrols.pause();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void button_Resume_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button_Primeiro_Click(object sender, EventArgs e)
        {
            if (listBox_Musicas.SelectedItems.Count > 0)
            {
                listBox_Musicas.SetSelected(0, true);
                WindowsMediaPlayer.URL = Musicas[listBox_Musicas.SelectedIndex];
            }
        }

        private void button_anterior_Click(object sender, EventArgs e)
        {
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
