
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
        
        public void BuscarMusicas(string parametro)
       {
            AdaptadorMusicas.SelectCommand = new SqlCommand("Select * from Musicas where (Nome_Musica like '%@par%')", Conector.Conexao);
            SqlParameter ParBusca = new SqlParameter();
            ParBusca.Value = parametro;
            ParBusca.SourceColumn = "Nome_Musica";
            ParBusca.ParameterName = "@par";
            ParBusca.SqlDbType = SqlDbType.VarChar;
            AdaptadorMusicas.SelectCommand.Parameters.Add(ParBusca);
            AdaptadorMusicas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorMusicas.Fill(Dados, "BuscaMusicas");
        }

        public void PreencheAmigos()
        {
            AdaptadorAmigos.SelectCommand = new SqlCommand("Select Amigos.Nome, Amigos.Telefone, Amigos.Endereço, Amigos.Numero, Amigos.Email,Amigos.Bairro, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade", Conector.Conexao);
            AdaptadorAmigos.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorAmigos.Fill(Dados, "AmigosCompletos");
        }

        public void PreencheEmprestimos()
        {
            AdaptadorMusicas.SelectCommand = new SqlCommand("SELECT Amigos.Nome, Musicas.Nome_Album, Emprestimos.Data_Emprestimo FROM Emprestimos INNER JOIN Amigos ON Emprestimos.EmprestimosId_amigo = Amigos.id_amigo INNER JOIN Musicas ON Emprestimos.EmprestimosId_musicas = Musicas.id_musicas", Conector.Conexao);
            AdaptadorMusicas.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            AdaptadorMusicas.Fill(Dados, "EmprestimosCompletos");
        }
    }
}
