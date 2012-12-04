
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcervoMusical
{
    class Class_DataSet
    {
        public Class_Conexão Conector = new Class_Conexão();
        public DataSet Dados;
        public SqlDataAdapter AdaptadorMusicas, AdaptadorAmigos;

        public Class_DataSet()
        {
            Dados = new DataSet();
            AdaptadorMusicas = new SqlDataAdapter();
            AdaptadorAmigos = new SqlDataAdapter();
        }

        public void PreencheMusicas()
        {
            AdaptadorMusicas.SelectCommand = new SqlCommand("Select * from Musicas", Conector.Conexao);
            AdaptadorMusicas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorMusicas.Fill(Dados, "MusicasCompletas");
        }

        public void PreencheAmigos()
        {
            AdaptadorAmigos.SelectCommand = new SqlCommand("Select * from Amigos", Conector.Conexao);
            AdaptadorAmigos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorAmigos.Fill(Dados, "AmigosCompletos");
        }
    }
}
