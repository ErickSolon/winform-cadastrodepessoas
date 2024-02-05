using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    internal class PessoasCadastroConexao : IDisposable
    {
        private readonly IDbConnection _dbConnection;

        public PessoasCadastroConexao()
        {
            _dbConnection = new MySqlConnection("server=localhost;User Id=root;database=estudowinforms");
        }

        public IDbConnection GetConnection()
        {
            if (_dbConnection.State != ConnectionState.Open)
            {
                _dbConnection.Open();
                Console.WriteLine("Aberta");
            }

            return _dbConnection;
        }

        public void Dispose()
        {
            _dbConnection.Dispose();
        }
    }
}
