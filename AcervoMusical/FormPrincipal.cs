﻿using System;
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
        Class_DataSet DataSetLogin = new Class_DataSet();

        public FormPrincipal()
        {
            InitializeComponent();
            DataSetLogin.Login();
            DataSetLogin.PreencheEmprestimos();
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
            else if (sender == pictureBox_Sair)
                label_Sair.Visible = true;
        }

        public void Esconder_texto(object sender, EventArgs e)
        {
            label_login.Visible = false;
            label_Ferramentas.Visible = false;
            label_Sair.Visible = false;
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
                textBox_Mubox.Visible = true;
            }
            else if (sender == button_Musicas)
            {
                CadastroMusicas CM = new CadastroMusicas();
                CM.FP = this;
                CM.Show();
            }
            else if (sender == button_Amigos)
            {
                if (Application.OpenForms.OfType<CadastroAmigos>().Count() > 0)
                {
                    MessageBox.Show("Form ja está aberto");
                }
                else
                {
                    CadastroAmigos CA = new CadastroAmigos();
                    CA.FP = this;
                    CA.Show();
                }
                
            }
            else if (sender == pictureBox_Login)
            {
                ConfiguracoesUsuario CU = new ConfiguracoesUsuario();
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
            

            try
            {
                timer_Relogio.Start();
                Conector.Conectar();

                foreach (DataRow Registro in DataSetLogin.Dados.Tables["Usuario"].Rows)
                {
                    if (Registro["Login"].ToString() != "Admin")
                    {
                        if ((Registro["AtivarLogin"].ToString() == "True") && (Registro["IdLogin"].ToString() == "2"))
                        {
                            #region Chama o formulario de Login
                            Login Login = new Login();
                            Login.FP = this;
                            Login.ShowDialog();
                            #endregion
                        }
                    }

                }

                #region Posicionamento dos Botoes no Formulario

                SqlDataReader LeitorPosicaoBotao;
                SqlCommand CmdPosicaoBotao = new SqlCommand("SELECT * FROM ConfiguracoesBotoes", Conector.Conexao);
                LeitorPosicaoBotao = CmdPosicaoBotao.ExecuteReader();

                while (LeitorPosicaoBotao.Read())
                {
                    if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Agenda")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Agenda.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Mubox")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Mubox.Location = Localizacao;
                        this.textBox_Mubox.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Amigos")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Amigos.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Musicas")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Musicas.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Media player")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_MediaPlayer.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Emprestimos")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Emprestimos.Location = Localizacao;
                    }
                    else if (LeitorPosicaoBotao["Botao"].ToString() == "Botao Consulta")
                    {
                        int Localizacaox = int.Parse((LeitorPosicaoBotao["Localizacaox"].ToString()));
                        int Localizacaoy = int.Parse((LeitorPosicaoBotao["Localizacaoy"].ToString()));
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.button_Consultas.Location = Localizacao;
                    }
                }

                LeitorPosicaoBotao.Close();

                #endregion

                #region Posicionamento dos Panels no Formulario

                SqlDataReader LeitorPosicaoPanel;
                SqlCommand CmdPosicaoPanel = new SqlCommand("SELECT * FROM ConfiguracoesPanel", Conector.Conexao);
                LeitorPosicaoPanel = CmdPosicaoPanel.ExecuteReader();

                while (LeitorPosicaoPanel.Read())
                {
                    if (LeitorPosicaoPanel["Panel"].ToString() == "Panel Configuracoes")
                    {
                        int Localizacaox = int.Parse(LeitorPosicaoPanel["Localizacaox"].ToString());
                        int Localizacaoy = int.Parse(LeitorPosicaoPanel["Localizacaoy"].ToString());
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.panel_Configuraçoes.Location = Localizacao;
                    }
                    else
                    {
                        int Localizacaox = int.Parse(LeitorPosicaoPanel["Localizacaox"].ToString());
                        int Localizacaoy = int.Parse(LeitorPosicaoPanel["Localizacaoy"].ToString());
                        Point Localizacao = new Point(Localizacaox, Localizacaoy);
                        this.panel_Relogio.Location = Localizacao;
                    }

                }
                LeitorPosicaoPanel.Close();

                #endregion

                #region Posicionamento do ListView no Formulario

                SqlDataReader LeitorPosicaoListView;
                SqlCommand CmdPosicaoListView = new SqlCommand("SELECT * FROM ConfiguracoesListView", Conector.Conexao);
                LeitorPosicaoListView = CmdPosicaoListView.ExecuteReader();

                while (LeitorPosicaoListView.Read())
                {
                    int Localizacaox = int.Parse(LeitorPosicaoListView["LocalizacaoX"].ToString());
                    int Localizacaoy = int.Parse(LeitorPosicaoListView["LocalizacaoY"].ToString());
                    Point Localizacao = new Point(Localizacaox, Localizacaoy);
                    this.listView_Devolucoes.Location = Localizacao;
                }

                LeitorPosicaoListView.Close();

                #endregion

                #region Configurações de Cores e Trava de botoes

                SqlDataReader ConfigFormPrincipal;
                SqlCommand CmdConfigFormPrincipal = new SqlCommand("SELECT * FROM ConfiguracoesForm", Conector.Conexao);
                ConfigFormPrincipal = CmdConfigFormPrincipal.ExecuteReader();

                while (ConfigFormPrincipal.Read())
                {
                    ConfiguracoesGerais Config = new ConfiguracoesGerais(this);
                    Config.MudarCor(ConfigFormPrincipal["FundoFormulario"].ToString());
                }
                ConfigFormPrincipal.Close();

                #endregion
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
            }
            finally
            {
                Conector.Desconectar();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label_Data.Text = DateTime.Now.ToShortDateString();
            label_DiaDaSemana.Text = DateTime.Now.ToString("dddd");
            label_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Salva as alterações do formulario
            Conector.Conectar();
            
            if (Conector.Conectar())
            {
                try
                {   
                    #region Comando Para salvar configuraçoes finais dos botoes
                    SqlCommand CmdUpdateBotoes = new SqlCommand("UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Amigos.Location.X.ToString() + ", Localizacaoy =" + button_Amigos.Location.Y.ToString() + " WHERE Botao = 'Botao Amigos'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Mubox.Location.X.ToString() + ", Localizacaoy =" + button_Mubox.Location.Y.ToString() + " WHERE Botao = 'Botao Mubox'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Agenda.Location.X.ToString() + ", Localizacaoy =" + button_Agenda.Location.Y.ToString() + " WHERE Botao = 'Botao Agenda'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Musicas.Location.X.ToString() + ", Localizacaoy =" + button_Musicas.Location.Y.ToString() + " WHERE Botao = 'Botao Musicas'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_MediaPlayer.Location.X.ToString() + ", Localizacaoy =" + button_MediaPlayer.Location.Y.ToString() + " WHERE Botao = 'Botao Media Player'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Emprestimos.Location.X.ToString() + ", Localizacaoy =" + button_Emprestimos.Location.Y.ToString() + " WHERE Botao = 'Botao Emprestimos'" +
                                                        "UPDATE ConfiguracoesBotoes SET Localizacaox =" + button_Consultas.Location.X.ToString() + ", Localizacaoy =" + button_Consultas.Location.Y.ToString() + " WHERE Botao = 'Botao Consulta'" , Conector.Conexao);
                    #endregion

                    #region Comando Para salvar configuracoes finais dos panels
                    SqlCommand CmdUpdatePanel = new SqlCommand("UPDATE ConfiguracoesPanel SET LocalizacaoX =" + panel_Configuraçoes.Location.X.ToString() + ", LocalizacaoY =" + panel_Configuraçoes.Location.Y.ToString() + " WHERE Panel = 'Panel Configuracoes'" +                                              "UPDATE ConfiguracoesPanel SET LocalizacaoX=" + panel_Relogio.Location.X + ", LocalizacaoY=" + panel_Relogio.Location.Y + "WHERE Panel = 'Panel Timer'", Conector.Conexao);
                    #endregion

                    #region Comando Para salvar configuracoes finais do ListView
                    SqlCommand CmdUpdateLisView = new SqlCommand("UPDATE ConfiguracoesListView SET LocalizacaoX=" + listView_Devolucoes.Location.X + ", LocalizacaoY="+listView_Devolucoes.Location.Y+"WHERE ListView = 'Devolucoes'", Conector.Conexao);
                    #endregion

                    //Executa os comando inseridos
                    CmdUpdateBotoes.ExecuteNonQuery();
                    CmdUpdateLisView.ExecuteNonQuery();
                    CmdUpdatePanel.ExecuteNonQuery();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "");
                }
                finally
                {
                    if (Conector != null)
                        Conector.Conexao.Close();
                }

            }
            #endregion
        }

        private void textBox_Mubox_DoubleClick(object sender, EventArgs e)
        {
            textBox_Mubox.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {

            foreach (DataRow Registro in DataSetLogin.Dados.Tables["EmprestimosCompletos"].Rows)
            {
                if ((Registro["Status"].ToString() == "True") && (Registro["Data_Devolucao"].ToString() == ""))
                {
                    ListViewItem ListaEmprestimos = new ListViewItem();
                    ListaEmprestimos.Text = Registro["Nome"].ToString();
                    ListaEmprestimos.SubItems.Add(Registro["EmprestimosTipo_Midia"].ToString());
                    ListaEmprestimos.SubItems.Add(Registro["Nome_Album"].ToString());
                    ListaEmprestimos.SubItems.Add(Registro["Data_Emprestimo"].ToString());
                    listView_Devolucoes.Items.Add(ListaEmprestimos);
                }
            }
        }
    }
}
