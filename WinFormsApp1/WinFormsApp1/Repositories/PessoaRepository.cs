using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace WinFormsApp1.Repositories
{
    public class PessoaRepository
    {
        public void Add(Pessoas pessoas)
        {
            using MySqlConnection Conn = (MySqlConnection)new PessoasCadastroConexao().GetConnection();

            string query = "INSERT INTO pessoas (nome, sobrenome, idade) VALUES (@Nome, @Sobrenome, @Idade)";
            Conn.Execute(query, pessoas);
        }


        public void Update(int id, Pessoas pessoas)
        {
            using MySqlConnection Conn = (MySqlConnection)new PessoasCadastroConexao().GetConnection();

            string query = "UPDATE pessoas SET nome = @Nome, sobrenome = @Sobrenome, idade = @Idade WHERE idpessoas = @IdPessoas";
            pessoas.IdPessoas = id;

            Conn.Execute(query, pessoas);
        }


        public void Delete(int id)
        {
            using MySqlConnection Conn = (MySqlConnection)new PessoasCadastroConexao().GetConnection();
            Conn.Execute($"DELETE FROM pessoas WHERE idpessoas = {id}");
        }

        public ICollection<Pessoas> Select()
        {
            using MySqlConnection Conn = (MySqlConnection)new PessoasCadastroConexao().GetConnection();
            return Conn.Query<Pessoas>("SELECT * FROM pessoas").ToList();
        }

        public Pessoas SelectById(int id)
        {
            using MySqlConnection Conn = (MySqlConnection)new PessoasCadastroConexao().GetConnection();
            return Conn.QueryFirstOrDefault<Pessoas>($"SELECT * FROM pessoas WHERE idpessoas = {id}");
        }
    }
}
