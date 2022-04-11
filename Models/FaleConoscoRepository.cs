using System;
using System.Collections.Generic;
using MySqlConnector;


namespace Projeto_CTPD_Maria_Eduarda.Models
{
    public class FaleConoscoRepository
    {
        private const string DadosConexao = "Database=Projeto_CTPD;Data Source=localhost;User Id=root;";

        public void Cadastrar(FaleConosco fc)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();  //abre a conexao com banco de dados          

            //query em SQL para inserção: insert into TABELA (campos) values (informacao)
            String Query = "Insert into FaleConosco (NomeCompleto,endereco,email,servico) values (@NomeCompleto,@endereco,@email,@servico)";

            //preparando o SQL(Query) para o objeto de conexao(Conexao)
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //tratamento para SQL Injection
            Comando.Parameters.AddWithValue("@NomeCompleto", fc.NomeCompleto);
            Comando.Parameters.AddWithValue("@endereco", fc.endereco);
            Comando.Parameters.AddWithValue("@email", fc.email);
            Comando.Parameters.AddWithValue("@servico", fc.servico);

            Comando.ExecuteNonQuery(); //executa a query no banco de dados

            Conexao.Close(); //fecho a conexao com banco de dados

        }

    }
}