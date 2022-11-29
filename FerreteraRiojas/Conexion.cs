using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteraRiojas
{
    internal class Conexion
    {
        
        public static string _connectionString = "Host=localhost;Username=postgres;Password=masterkey;Database=FerreteraRiojas";
        static NpgsqlConnection connection = new NpgsqlConnection(_connectionString);

        public static void Conectar()
        {
            
            connection.Open();
        }
        public static void Desconectar()
        {
            connection.Close();
        }

        public static DataTable ConsultaSelect(string consulta)
        {
            Conectar();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = consulta;
            NpgsqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            Desconectar();
            return dt;
        }

    }
}
