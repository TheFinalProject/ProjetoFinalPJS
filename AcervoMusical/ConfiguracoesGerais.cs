using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AcervoMusical
{
    public partial class ConfiguracoesGerais : Form
    {
        public FormPrincipal FP;

        public ConfiguracoesGerais(FormPrincipal FrmPrincipal)
        {
            InitializeComponent();
            FP = FrmPrincipal;
        }

        

        public void MudarCor(string Cor)
        {
            comboBox_cores.Text = Cor;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_cores.Text == "Rosa")
            {
                FP.BackColor = System.Drawing.Color.Pink;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if(comboBox_cores.Text == "Vermelho")
            {
                FP.BackColor = System.Drawing.Color.Red;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Azul")
            {
                FP.BackColor = System.Drawing.Color.Navy;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Roxo")
            {
                FP.BackColor = System.Drawing.Color.Purple;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Amarelo")
            {
                FP.BackColor = System.Drawing.Color.Yellow;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Verde")
            {
                FP.BackColor = System.Drawing.Color.Green;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Preto")
            {
                FP.BackColor = System.Drawing.Color.Black;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            else if (comboBox_cores.Text == "Branco")
            {
                FP.BackColor = System.Drawing.Color.White;
                FP.Refresh();
                panel_ConfigGerais.BackColor = FP.BackColor;
            }
            
            
        }

        private void button_Salvar_Click(object sender, EventArgs e)
        {
            byte Travar;

            if(checkBox_TravarBotoes.Checked == true)
                Travar = 1;
            else
                Travar = 0;

            if (FP.Conector.Conectar())
            {
                try
                {
                    SqlCommand Comando = new SqlCommand("UPDATE ConfiguracoesForm SET FundoFormulario ='" + comboBox_cores.Text + "', TravarBotoes = " + Travar, FP.Conector.Conexao);
                    Comando.ExecuteNonQuery();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "");
                }
                finally
                {
                    FP.Conector.Desconectar();
                }
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                FP.Conector.Conectar();
                SqlCommand Comando = new SqlCommand("Exec Padrao", FP.Conector.Conexao);
                Comando.ExecuteNonQuery();

                if (MessageBox.Show("O sistema será reiniciado, Deseja Continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    Environment.Exit(0);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "");
            }
            finally
            {
                FP.Conector.Desconectar();
            }
        }

        private void ConfiguracoesGerais_Load(object sender, EventArgs e)
        {
            panel_ConfigGerais.BackColor = FP.BackColor;
        }
    }
}
