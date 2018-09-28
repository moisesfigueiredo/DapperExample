using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace DapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=dapperTest;Integrated Security=True");

            conn.Open();

            var users = conn.Query("select * from Usuario");

            foreach (var usr in users)
            {
                Console.WriteLine("{0} - {1} - {2}", usr.Id, usr.Nome, usr.Idade);
            }

            conn.Close();

            Console.ReadKey();

        }
    }
}
