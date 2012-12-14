using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace AcervoMusical
{
    public partial class CadastroAmigos : Form
    {
        public CadastroAmigos()
        {
            InitializeComponent();
        }

        DataSet FiltraAmigo = new DataSet();
        Class_DataSet DatasetAmigos = new Class_DataSet();
        ListViewItem Amigos = new ListViewItem();
        public FormPrincipal FP;

        //Variavel criada para verificação de botao caso precionado
        bool fechar = false;
        int Id_Cidade = 0;
        string NomeCidade = null;

        public void Limpar()
        {
            textBox_NomeAmigo.Text = string.Empty;
            textBox_Email.Text = string.Empty;
            maskedTextBox_Telefone.Text = string.Empty;
            textBox_Endereco.Text = string.Empty;
            textBox_Numero.Text = string.Empty;
            comboBox_UF.Text = string.Empty;
            comboBox_Cidade.Text = string.Empty;
            textBox_Bairro.Text = string.Empty;

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {

            //se o botao foi precionado altera o valor da variavel para true e fecha o form
            fechar = true;
            this.Close();

        }

        private void CadastroAmigos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Verifica se a variavel manteve o seu valor inicial, se caso manteve, ele entra e verifica se há dados salvos ou nao!!!

            if (button_Cadastrar.Text == "Salvar")
                return;
            

            //passa no formulario verificando se tem campos nao salvos, se caso tenha, ele sinaliza que existe informações nao salva se mesmo diante disto queira continuar.
                if (fechar == false)
                {
                    int soma = 0;
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            TextBox t = (TextBox)c;
                            if (t.Text != "")
                            {
                                soma++;
                            }
                        }
                    }
                    if (soma > 0)
                    {
                        if (MessageBox.Show("O Formulário contém dados não salvos, deseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            fechar = true;
                            this.Close();

                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }
            
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {

            FP.Conector.Conectar();
            if (button_Cadastrar.Text == "Adicionar")
            {

                // tenta conectar se conseguir, vai executar um comando somando quantos registros existe com os campos que determinam a pessoa igual!. 
                if (FP.Conector.Conectar())
                {
                    SqlCommand VerficaDublicidade = new SqlCommand("Select count(*) from Amigos where (Nome = @Nome) and (Telefone = @Telefone) and (Email = @Email)", FP.Conector.Conexao);


                    #region Parametros Duplicidade
                    SqlParameter NomeVerificador = new SqlParameter();
                    NomeVerificador.Value = textBox_NomeAmigo.Text;
                    NomeVerificador.SourceColumn = "Nome";
                    NomeVerificador.ParameterName = "@Nome";
                    NomeVerificador.SqlDbType = SqlDbType.VarChar;
                    NomeVerificador.Size = 50;


                    SqlParameter TelefoneVerificador = new SqlParameter();
                    TelefoneVerificador.SourceColumn = "Telefone";
                    TelefoneVerificador.Value = maskedTextBox_Telefone.Text;
                    TelefoneVerificador.ParameterName = "@Telefone";
                    TelefoneVerificador.SqlDbType = SqlDbType.Char;
                    TelefoneVerificador.Size = 15;

                    SqlParameter EmailVerificador = new SqlParameter();
                    EmailVerificador.SourceColumn = "Email";
                    EmailVerificador.Value = textBox_Email.Text;
                    EmailVerificador.ParameterName = "@Email";
                    EmailVerificador.SqlDbType = SqlDbType.VarChar;
                    EmailVerificador.Size = 50;
                    #endregion

                    VerficaDublicidade.Parameters.AddRange(new SqlParameter[] { NomeVerificador, TelefoneVerificador, EmailVerificador });
                    //Verifica se nao possui ja o mesmo registro adicionado.
                    int Verificador = (int)VerficaDublicidade.ExecuteScalar();
                    if (Verificador == 0)
                    {
                        try
                        {

                            SqlCommand Comando = new SqlCommand("Insert into Amigos (Nome, Telefone, Endereço, Bairro, Numero, Email, AmigosId_Cidade, AmigosId_Estado) values (@Nome, @Telefone, @Endereço, @Bairro, @Numero, @Email, @AmigosId_Cidade, @AmigosId_Estado)", FP.Conector.Conexao);

                            //Verifica se no textbox Numero o usuario digite apenas numeros, caso nao. ele mostrará erro.
                            System.Text.RegularExpressions.Regex Num = new System.Text.RegularExpressions.Regex("[^0-9]");
                            if (!Num.IsMatch(this.textBox_Numero.Text) || textBox_Numero.Text == string.Empty)
                            {
                                #region Parametros
                                #region Param_Amigo
                                SqlParameter NomeAmigo = new SqlParameter();
                                NomeAmigo.Value = textBox_NomeAmigo.Text;
                                NomeAmigo.SourceColumn = "Nome";
                                NomeAmigo.ParameterName = "@Nome";
                                NomeAmigo.SqlDbType = SqlDbType.VarChar;
                                NomeAmigo.Size = 50;
                                #endregion

                                #region Param_Telefone
                                SqlParameter Telefone = new SqlParameter();
                                Telefone.SourceColumn = "Telefone";
                                Telefone.Value = maskedTextBox_Telefone.Text;
                                Telefone.ParameterName = "@Telefone";
                                Telefone.SqlDbType = SqlDbType.Char;
                                Telefone.Size = 15;
                                #endregion

                                #region Param_Endereço
                                SqlParameter Endereco = new SqlParameter();
                                Endereco.SourceColumn = "Endereço";
                                Endereco.Value = textBox_Endereco.Text;
                                Endereco.ParameterName = "@Endereço";
                                Endereco.SqlDbType = SqlDbType.VarChar;
                                Endereco.Size = 50;
                                #endregion

                                #region Param_Bairro
                                SqlParameter Bairro = new SqlParameter();
                                Bairro.SourceColumn = "Bairro";
                                Bairro.Value = textBox_Bairro.Text;
                                Bairro.ParameterName = "@Bairro";
                                Bairro.SqlDbType = SqlDbType.VarChar;


                                #endregion

                                #region Param_Numero
                                SqlParameter Numero = new SqlParameter();
                                Numero.SourceColumn = "Numero";
                                Numero.Value = textBox_Numero.Text;
                                Numero.ParameterName = "@Numero";
                                Numero.SqlDbType = SqlDbType.Char;
                                Numero.Size = 10;
                                #endregion

                                #region Param_Email
                                SqlParameter Email = new SqlParameter();
                                Email.SourceColumn = "Email";
                                Email.Value = textBox_Email.Text;
                                Email.ParameterName = "@Email";
                                Email.SqlDbType = SqlDbType.VarChar;
                                Email.Size = 50;
                                #endregion

                                #region Param_Cidade
                                SqlParameter Cidade = new SqlParameter();
                                Cidade.SourceColumn = "AmigosId_Cidade";
                                Cidade.Value = Id_Cidade;
                                Cidade.ParameterName = "@AmigosId_Cidade";
                                Cidade.SqlDbType = SqlDbType.Int;

                                #endregion

                                #region Param_Estado
                                SqlParameter Estado = new SqlParameter();
                                Estado.SourceColumn = "AmigosId_Estado";
                                Estado.Value = comboBox_UF.Text;
                                Estado.ParameterName = "@AmigosId_Estado";
                                Estado.SqlDbType = SqlDbType.Char;
                                Estado.Size = 3;
                                #endregion
                                #endregion

                                Comando.Parameters.AddRange(new SqlParameter[] { NomeAmigo, Telefone, Endereco, Bairro, Numero, Email, Cidade, Estado });
                                Comando.ExecuteNonQuery();

                                #region Adicionar no listview
                                Amigos = new ListViewItem();
                                Amigos.Text = textBox_NomeAmigo.Text;
                                Amigos.SubItems.Add(maskedTextBox_Telefone.Text);
                                Amigos.SubItems.Add(textBox_Endereco.Text);
                                Amigos.SubItems.Add(textBox_Numero.Text);
                                Amigos.SubItems.Add(textBox_Bairro.Text);
                                Amigos.SubItems.Add(textBox_Email.Text);
                                Amigos.SubItems.Add(comboBox_Cidade.Text);
                                Amigos.SubItems.Add(comboBox_UF.Text);
                                listView_CadastroAmigos.Items.Add(Amigos);
                                #endregion

                                label1.Visible = false;
                                Limpar();
                            }
                            else
                            {
                                label1.Visible = true;

                            }
                        }
                        catch
                        {
                            label_Aviso.Visible = true;
                            if (textBox_NomeAmigo.Text == "")
                            {
                                textBox_NomeAmigo.BackColor = Color.OldLace;
                            }
                            if (textBox_Email.Text == "")
                            {
                                textBox_Email.BackColor = Color.OldLace;
                            }
                            if (maskedTextBox_Telefone.Text == "")
                            {
                                maskedTextBox_Telefone.BackColor = Color.OldLace;
                            }
                            if (comboBox_UF.SelectedItem == null)
                            {
                                comboBox_UF.BackColor = Color.OldLace;
                            }
                            if (comboBox_Cidade.SelectedItem == null)
                            {
                                comboBox_Cidade.BackColor = Color.OldLace;
                            }
                        }
                        finally
                        {
                            if (FP.Conector != null)
                                FP.Conector.Conexao.Close();
                        }
                    }
                    else
                    {
                        label_RegistroExistente.Visible = true;
                    }
                }
            }
            else
            {

                try
                {
                    FP.Conector.Conectar();

                    //Comando para pegar o id da cidade selecionada.
                    SqlCommand IdCidades = new SqlCommand("SELECT id_Cidade FROM Cidades WHERE NomeCidade = @Nome", FP.Conector.Conexao);
                    IdCidades.Parameters.Add("@Nome", SqlDbType.VarChar);
                    IdCidades.Parameters["@Nome"].Value = comboBox_Cidade.Text;
                    Id_Cidade = (int)IdCidades.ExecuteScalar();

                    //comando para alterar os valores do amigo
                    SqlCommand CmdUpdate = new SqlCommand("UPDATE Amigos SET Nome = @Nome, Telefone = @Telefone, Endereço = @Endereço, Bairro = @Bairro, Numero = @Numero, Email = @Email, AmigosId_Cidade = @AmigosId_Cidade, AmigosId_Estado = @AmigosId_Estado WHERE (Nome = @NomeAmigo) AND (Telefone = @TelAmigo) AND (Email = @EmailAmigo)", FP.Conector.Conexao);
                    // verificando se quando for dar update ele também digite no textbox numero, valores iguais a numeros caso nao, mostrará um label sinalizando o erro.
                    System.Text.RegularExpressions.Regex Num = new System.Text.RegularExpressions.Regex("[^0-9]");
                    if (!Num.IsMatch(this.textBox_Numero.Text) || textBox_Numero.Text == string.Empty)
                    {
                        #region Parametros Update
                        SqlParameter NomeAmigo = new SqlParameter();
                        NomeAmigo.Value = textBox_NomeAmigo.Text;
                        NomeAmigo.SourceColumn = "Nome";
                        NomeAmigo.ParameterName = "@Nome";
                        NomeAmigo.SqlDbType = SqlDbType.VarChar;
                        NomeAmigo.Size = 50;

                        SqlParameter Telefone = new SqlParameter();
                        Telefone.SourceColumn = "Telefone";
                        Telefone.Value = maskedTextBox_Telefone.Text;
                        Telefone.ParameterName = "@Telefone";
                        Telefone.SqlDbType = SqlDbType.Char;
                        Telefone.Size = 15;
                        SqlParameter Endereco = new SqlParameter();
                        Endereco.SourceColumn = "Endereço";
                        Endereco.Value = textBox_Endereco.Text;
                        Endereco.ParameterName = "@Endereço";
                        Endereco.SqlDbType = SqlDbType.VarChar;
                        Endereco.Size = 50;
                        SqlParameter Bairro = new SqlParameter();
                        Bairro.SourceColumn = "Bairro";
                        Bairro.Value = textBox_Bairro.Text;
                        Bairro.ParameterName = "@Bairro";
                        Bairro.SqlDbType = SqlDbType.VarChar;

                        SqlParameter Numero = new SqlParameter();
                        Numero.SourceColumn = "Numero";
                        Numero.Value = textBox_Numero.Text;
                        Numero.ParameterName = "@Numero";
                        Numero.SqlDbType = SqlDbType.Char;
                        Numero.Size = 10;

                        SqlParameter Email = new SqlParameter();
                        Email.SourceColumn = "Email";
                        Email.Value = textBox_Email.Text;
                        Email.ParameterName = "@Email";
                        Email.SqlDbType = SqlDbType.VarChar;
                        Email.Size = 50;

                        SqlParameter Cidade = new SqlParameter();
                        Cidade.SourceColumn = "AmigosId_Cidade";
                        Cidade.Value = Id_Cidade;
                        Cidade.ParameterName = "@AmigosId_Cidade";
                        Cidade.SqlDbType = SqlDbType.Int;

                        SqlParameter Estado = new SqlParameter();
                        Estado.SourceColumn = "AmigosId_Estado";
                        Estado.Value = comboBox_UF.Text;
                        Estado.ParameterName = "@AmigosId_Estado";
                        Estado.SqlDbType = SqlDbType.Char;
                        Estado.Size = 3;

                        SqlParameter NomeConsulta = new SqlParameter();
                        NomeConsulta.SourceColumn = "Nome";
                        NomeConsulta.Value = listView_CadastroAmigos.SelectedItems[0].Text;
                        NomeConsulta.ParameterName = "@NomeAmigo";
                        NomeConsulta.SqlDbType = SqlDbType.VarChar;
                        NomeConsulta.Size = 50;

                        SqlParameter TelConsulta = new SqlParameter();
                        TelConsulta.SourceColumn = "Telefone";
                        TelConsulta.Value = listView_CadastroAmigos.FocusedItem.SubItems[1].Text;
                        TelConsulta.ParameterName = "@TelAmigo";
                        TelConsulta.SqlDbType = SqlDbType.Char;
                        TelConsulta.Size = 15;

                        SqlParameter EmailConsulta = new SqlParameter();
                        EmailConsulta.Value = listView_CadastroAmigos.FocusedItem.SubItems[5].Text;
                        EmailConsulta.ParameterName = "@EmailAmigo";
                        EmailConsulta.SqlDbType = SqlDbType.VarChar;
                        EmailConsulta.Size = 50;

                        #endregion

                        CmdUpdate.Parameters.AddRange(new SqlParameter[] { NomeAmigo, Telefone, Endereco, Bairro, Numero, Email, Cidade, Estado, NomeConsulta, TelConsulta, EmailConsulta });

                        CmdUpdate.ExecuteNonQuery();

                        #region atualiza o listview depois de alterações
                        for (int i = listView_CadastroAmigos.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem atualiza = listView_CadastroAmigos.SelectedItems[i];
                            atualiza.Text = textBox_NomeAmigo.Text;
                            atualiza.SubItems[1].Text = maskedTextBox_Telefone.Text;
                            atualiza.SubItems[2].Text = textBox_Endereco.Text;
                            atualiza.SubItems[3].Text = textBox_Numero.Text;
                            atualiza.SubItems[4].Text = textBox_Bairro.Text;
                            atualiza.SubItems[5].Text = textBox_Email.Text;
                            atualiza.SubItems[6].Text = comboBox_Cidade.Text;
                            atualiza.SubItems[7].Text = comboBox_UF.Text;
                        }
                        #endregion

                        label1.Visible = false;

                        #region limpar Campos
                        textBox_NomeAmigo.Clear();
                        textBox_Endereco.Clear();
                        textBox_Email.Clear();
                        textBox_Bairro.Clear();
                        textBox_Numero.Clear();
                        textBox_Remover.Clear();
                        comboBox_Cidade.Text = "";
                        comboBox_UF.Text = "";
                        maskedTextBox_Telefone.Clear();
                        #endregion
                    }
                    else
                    {
                        label1.Visible = true;

                    }
                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    FP.Conector.Desconectar();
                }

                if (label1.Visible != true)
                    button_Cadastrar.Text = "Adicionar";
                button_Remover.Enabled = false;
            }
        }

        private void CadastroAmigos_Load(object sender, EventArgs e)
        {
            panel_CadastroAmigos.BackColor = FP.BackColor;

            SqlDataReader LeitorEstados;

            button_Remover.Enabled = false;

            if (FP.Conector.Conectar())
            {
                SqlCommand CmdEstados = new SqlCommand("SELECT * FROM Estados", FP.Conector.Conexao);

                LeitorEstados = CmdEstados.ExecuteReader();

                //enquanto o CmdEstados for verdadeiro, ele vai carrega o combobox com os valores do Estado.
                while (LeitorEstados.Read())
                {
                    comboBox_UF.Items.Add(LeitorEstados["id_Estado"].ToString());
                }

                LeitorEstados.Close();
            }

            #region Situação atual de amigos no Banco de Dados

            DatasetAmigos.PreencheAmigos();

            foreach (DataRow registro in DatasetAmigos.Dados.Tables["AmigosCompletos"].Rows)
            {
                ListViewItem Amigos = new ListViewItem();
                Amigos.Text = registro["Nome"].ToString();
                Amigos.SubItems.Add(registro["Telefone"].ToString());
                Amigos.SubItems.Add(registro["Endereço"].ToString());
                Amigos.SubItems.Add(registro["Numero"].ToString());
                Amigos.SubItems.Add(registro["Bairro"].ToString());
                Amigos.SubItems.Add(registro["Email"].ToString());
                Amigos.SubItems.Add(registro["NomeCidade"].ToString());
                Amigos.SubItems.Add(registro["CidadeId_uf"].ToString());
                listView_CadastroAmigos.Items.Add(Amigos);
            }
            #endregion
        }

        private void comboBox_UF_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Carrega o combobox_Cidade com os valores de cada estado
            comboBox_Cidade.Items.Clear();
            SqlDataReader LeitorCidades;
            if (FP.Conector.Conectar())
            {
                //comando faz a selecao das cidades de acordo com o estado selecionado
                SqlCommand CmdCidades = new SqlCommand("SELECT NomeCidade FROM Cidades WHERE CidadeId_uf = '" + comboBox_UF.Text + "'", FP.Conector.Conexao);

                LeitorCidades = CmdCidades.ExecuteReader();

                while (LeitorCidades.Read())
                {
                    comboBox_Cidade.Items.Add(LeitorCidades["NomeCidade"].ToString());
                }

                LeitorCidades.Close();
            }
        }

        private void comboBox_Cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            FP.Conector.Conectar();

            // comando que procura a id da cidade onde o nome seja igual ao combobox. e passa numa variavel do tipo inteiro o valor da ID de certa cidade com nome tal.
            SqlCommand IdCidades = new SqlCommand("SELECT id_Cidade FROM Cidades WHERE NomeCidade = @Nome", FP.Conector.Conexao);
            IdCidades.Parameters.Add("@Nome", SqlDbType.VarChar);
            IdCidades.Parameters["@Nome"].Value = comboBox_Cidade.Text;

            try
            {

                Id_Cidade = (int)IdCidades.ExecuteScalar();
                NomeCidade = comboBox_Cidade.Text;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                FP.Conector.Desconectar();
            }

        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            if (listView_CadastroAmigos.Items.Count > 0)
            {
                try
                {
                    FP.Conector.Conectar();
                    SqlCommand CmdRemover = new SqlCommand("DELETE FROM Amigos WHERE (Nome = @Nome) AND (Email = @Email) AND (Telefone = @Telefone)", FP.Conector.Conexao);

                    //Parametros do meu comando em sql
                    #region parametros deleção
                    SqlParameter P_Amigo = new SqlParameter();
                    P_Amigo.Value = textBox_NomeAmigo.Text;
                    P_Amigo.SourceColumn = "Nome";
                    P_Amigo.ParameterName = "@Nome";
                    P_Amigo.SqlDbType = SqlDbType.VarChar;
                    P_Amigo.Size = 50;

                    SqlParameter P_Email = new SqlParameter();
                    P_Email.SourceColumn = "Email";
                    P_Email.Value = textBox_Email.Text;
                    P_Email.ParameterName = "@Email";
                    P_Email.SqlDbType = SqlDbType.VarChar;
                    P_Email.Size = 50;

                    SqlParameter P_Telefone = new SqlParameter();
                    P_Telefone.SourceColumn = "Telefone";
                    P_Telefone.Value = maskedTextBox_Telefone.Text;
                    P_Telefone.ParameterName = "@Telefone";
                    P_Telefone.SqlDbType = SqlDbType.Char;
                    P_Telefone.Size = 15;

                    #endregion

                    CmdRemover.Parameters.AddRange(new SqlParameter[] { P_Amigo, P_Email, P_Telefone });
                    CmdRemover.ExecuteNonQuery();

                    //laço que percorre o listview até encontrar o que tiver selecionado e remove-lo do mesmo.
                    for (int i = listView_CadastroAmigos.SelectedItems.Count - 1; i >= 0; --i)
                    {
                        ListViewItem remove = listView_CadastroAmigos.SelectedItems[i];
                        listView_CadastroAmigos.Items.Remove(remove);

                    }
                    button_Remover.Enabled = false;
                    Limpar();
                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    FP.Conector.Desconectar();
                }
            }
        }

        private void listView_CadastroAmigos_Click(object sender, EventArgs e)
        {
            if (listView_CadastroAmigos.SelectedItems != null)
            {
                button_Cadastrar.Text = "Salvar";
                button_Remover.Enabled = true;

                //coloca os itens e subitens nos textbox para edição

                textBox_NomeAmigo.Text = listView_CadastroAmigos.SelectedItems[0].Text;
                textBox_Email.Text = listView_CadastroAmigos.FocusedItem.SubItems[5].Text;
                maskedTextBox_Telefone.Text = listView_CadastroAmigos.FocusedItem.SubItems[1].Text;
                textBox_Endereco.Text = listView_CadastroAmigos.FocusedItem.SubItems[2].Text;
                textBox_Bairro.Text = listView_CadastroAmigos.FocusedItem.SubItems[4].Text;
                textBox_Numero.Text = listView_CadastroAmigos.FocusedItem.SubItems[3].Text;
                comboBox_Cidade.Text = listView_CadastroAmigos.FocusedItem.SubItems[6].Text;
                comboBox_UF.Text = listView_CadastroAmigos.FocusedItem.SubItems[7].Text;
            }
            else
            {
                button_Remover.Enabled = false;
            }
        }

        #region Campos Obrigatórios
        private void textBox_NomeAmigo_Enter(object sender, EventArgs e)
        {
            textBox_NomeAmigo.BackColor = SystemColors.Window;
            label_Aviso.Visible = false;
        }

        private void textBox_Email_Enter(object sender, EventArgs e)
        {
            textBox_Email.BackColor = SystemColors.Window;
            label_Aviso.Visible = false;
        }

        private void maskedTextBox_Telefone_Enter(object sender, EventArgs e)
        {
            maskedTextBox_Telefone.BackColor = SystemColors.Window;
            label_Aviso.Visible = false;
        }

        private void comboBox_UF_Enter(object sender, EventArgs e)
        {
            comboBox_UF.BackColor = SystemColors.Window;
            label_Aviso.Visible = false;
        }

        private void comboBox_Cidade_Enter(object sender, EventArgs e)
        {
            comboBox_Cidade.BackColor = SystemColors.Window;
            label_Aviso.Visible = false;
        }
        #endregion

        private void textBox_Remover_TextChanged(object sender, EventArgs e)
        {
            FP.Conector.Conectar();
            DataSet DataFiltro = new DataSet();
            SqlDataAdapter AdaptadorFiltro = new SqlDataAdapter("Select Amigos.Nome, Amigos.Telefone, Amigos.Endereço, Amigos.Numero, Amigos.Email,Amigos.Bairro, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade", FP.Conector.Conexao);
            AdaptadorFiltro.Fill(DataFiltro, "Amigos");
            DataTable TabelaFiltro = DataFiltro.Tables["Amigos"];

            //Percorre o listview e verifica se ja há items com aqueles valores, se tiver com valores diferente dos que procura, ele deleta para poder apresentar. 
            foreach (DataRow registro in DataFiltro.Tables["Amigos"].Rows)
            {
                if (registro.RowState != DataRowState.Deleted && !registro["Nome"].ToString().ToUpper().Contains(textBox_Remover.Text.ToUpper()))
                {
                    registro.Delete();
                }
            }

            listView_CadastroAmigos.Items.Clear();

            for (int i = 0; i < TabelaFiltro.Rows.Count; i++)
            {
                DataRow RegistroAmigos = TabelaFiltro.Rows[i];
                // Somente as linhas que não foram deletadas
                if (RegistroAmigos.RowState != DataRowState.Deleted)
                {
                    // Define os itens da lista
                    ListViewItem InseriAmigos = new ListViewItem();

                    InseriAmigos.Text = RegistroAmigos["Nome"].ToString();
                    InseriAmigos.SubItems.Add(RegistroAmigos["Telefone"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["Endereço"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["Numero"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["Bairro"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["Email"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["NomeCidade"].ToString());
                    InseriAmigos.SubItems.Add(RegistroAmigos["CidadeId_uf"].ToString());
                    listView_CadastroAmigos.Items.Add(InseriAmigos);
                }
            }
            FP.Conector.Desconectar();
        }
    }
}