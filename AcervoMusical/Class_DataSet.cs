
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
        public SqlDataAdapter Adaptador;


        public Class_DataSet()
        {
            Dados = new DataSet();
            Adaptador = new SqlDataAdapter();
        }

        public void PreencheMusicas()
        {
            Adaptador.SelectCommand = new SqlCommand("SELECT * FROM Musicas", Conector.Conexao);
            Adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Adaptador.Fill(Dados, "MusicasCompletas");
        }
        
        public void PreencheAmigos()
        {
            Adaptador.SelectCommand = new SqlCommand("SELECT Amigos.Nome, Amigos.Telefone, Amigos.Endereço, Amigos.Numero, Amigos.Email,Amigos.Bairro, Cidades.NomeCidade, Cidades.CidadeId_uf FROM Amigos INNER JOIN Cidades ON Amigos.AmigosId_Cidade = Cidades.id_Cidade", Conector.Conexao);
            Adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Adaptador.Fill(Dados, "AmigosCompletos");
        }

        public void PreencheEmprestimos()
        {
            Adaptador.SelectCommand = new SqlCommand("SELECT Amigos.Nome, Amigos.Email, Amigos.Telefone, Musicas.Status,Musicas.Nome_Album, Emprestimos.Data_Emprestimo, Emprestimos.Data_Devolucao, EmprestimosTipo_Midia FROM Emprestimos INNER JOIN Amigos ON Emprestimos.EmprestimosId_amigo = Amigos.id_amigo INNER JOIN Musicas ON Emprestimos.EmprestimosId_musicas = Musicas.id_musicas", Conector.Conexao);
            Adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Adaptador.Fill(Dados, "EmprestimosCompletos");
        }

        public void ConsultarEmprestimos(string NomeAmigo)
        {
            Adaptador.SelectCommand = new SqlCommand("SELECT Amigos.Nome, Musicas.Nome_Album, Emprestimos.Data_Emprestimo FROM Emprestimos INNER JOIN Amigos ON Emprestimos.EmprestimosId_amigo = Amigos.id_amigo INNER JOIN Musicas ON Emprestimos.EmprestimosId_musicas = Musicas.id_musicas WHERE (Nome LIKE '%"+NomeAmigo+"%')", Conector.Conexao);

            //SqlParameter ParametroNomeAmigo = new SqlParameter();
            //ParametroNomeAmigo.Value = NomeAmigo;
            //ParametroNomeAmigo.SourceColumn = "Nome";
            //ParametroNomeAmigo.ParameterName = "@NomeAmigo";
            //ParametroNomeAmigo.SqlDbType = SqlDbType.VarChar;

            //Adaptador.SelectCommand.Parameters.Add(ParametroNomeAmigo);

            Adaptador.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            Adaptador.Fill(Dados, "ConsultarEmprestimos");
        }
    }
}
