using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace AcervoMusical
{
    public class Class_Conexão
    {
        public const string StringConexao = @"Data Source =RAFAEL\MSQL2008; Initial Catalog =Acervo; Integrated Security = SSPI";

        
        public SqlConnection Conexao;

        public Class_Conexão()
        {
            Conexao = new SqlConnection(StringConexao);
        }

        #region "Metodos para conectar e desconectar o banco de dados"
        public bool Conectar()
        {
            if (Conexao != null && Conexao.State == ConnectionState.Open)
                return true;
            try
            {
                Conexao.Open();
                return true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro " + erro);
                return false;
            }
        }

        public bool Desconectar()
        {
            if (Conexao.State != ConnectionState.Closed)
            {
                Conexao.Close();
                return true;
            }
            return false;
        }
        #endregion
    }
}
