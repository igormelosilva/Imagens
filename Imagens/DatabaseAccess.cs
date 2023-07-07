using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Imagens
{
    public class DatabaseAccess
    {
        public NpgsqlConnection OpenConnection()
        {
            string connectionString = String.Format(
            "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};",
                Config.dbHost, Config.dbUser, Config.dbName, Config.dbPort, Config.dbPass);

            NpgsqlConnection con = new NpgsqlConnection(connectionString);

            con.Open();

            return con;
        }
    }
}
