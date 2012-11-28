
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AcervoMusical
{
    class Class_DataSet
    {
        public Class_Conexão Conector;
        public DataSet Dados;
        public SqlDataAdapter AdaptadorMusicas;

        public Class_DataSet()
        {
            Dados = new DataSet();
            AdaptadorMusicas = new SqlDataAdapter();
        }

        public void PreencheMusicas()
        {
            AdaptadorMusicas.SelectCommand = new SqlCommand("Select * from Musicas", Conector.Conexao);
            AdaptadorMusicas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorMusicas.Fill(Dados, "MusicasCompletas");
        }           
    }
}
