﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace AcervoMusical
{
    class Class_Conexão
    {
        private const string StringConexao = @"Data Source =(local); Initial Catalog=Acervo;Integrated Security =SSPI";

        public SqlConnection Conexao = null;

        #region "Metodos para conectar e desconectar o banco de dados"

        public bool conectar()
        {
            if (Conexao != null && Conexao.State == ConnectionState.Open)
            {
                return true;
            }
            Conexao = new SqlConnection(StringConexao);
            try
            {

                Conexao.Open();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            }
        }

        public bool desconectar()
        {
            if (Conexao.State != ConnectionState.Closed)
            {
                Conexao.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
