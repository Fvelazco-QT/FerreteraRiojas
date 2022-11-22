using FerreteraRiojas;
using Npgsql;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace FerreteraRiojas;

public class CRUD
{
    private static readonly string _connectionString = "Host=localhost;Username=postgres;Password=masterkey;Database=FerreteraRiojas";

    public static int Create(Producto producto)
    {
        if (producto.Id == 0)
        {
            NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO public.\"Producto\"(\"Nombre\", \"Precio\", \"Descripcion\", \"Codigo\", \"Unidad\", \"Departamento\")VALUES ( @Nombre,@Precio,@Descripcion,@Codigo, @Unidad, @Departamento) RETURNING \"idProducto\";";
            command.Parameters.AddWithValue("@Nombre", producto.Nombre);
            command.Parameters.AddWithValue("@Precio", producto.Precio);
            command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("@Codigo", producto.Codigo);
            command.Parameters.AddWithValue("@Unidad", producto.Unidad);
            command.Parameters.AddWithValue("@Departamento", producto.Departamento);
            producto.Id = (int) command.ExecuteScalar();
            connection.Close();
        }
        return producto.Id;
    }
    public static Producto Read(int id)
    {
        NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        NpgsqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM public.\"Producto\" WHERE \"idProducto\" = @Id limit 1;";
        command.Parameters.AddWithValue("@Id", id);
        NpgsqlDataReader reader =  command.ExecuteReader();
        
        if (reader.HasRows)
        {
            reader.Read();
            int idProducto = (int)reader["idProducto"];
            string name = (string)reader["Nombre"];
            int precio = (int)reader["Precio"];
            string descripcion = (string)reader["Descripcion"];
            string codigo = (string)reader["Codigo"];
            string unidad = (string)reader["Unidad"];
            string departamento = (string)reader["Departamento"];
            connection.Close();
            return new Producto(idProducto, name, precio,descripcion,codigo,unidad,departamento);
            
        }
        connection.Close();
        return null;
    }
    public static void ReadAll(DataGridView dgv)
    {
        NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        NpgsqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "SELECT * FROM public.\"Producto\";";
        //NpgsqlDataReader reader = command.ExecuteReader();
        DataSet ds = new DataSet();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
        da.Fill(ds);
        dgv.DataSource = ds.Tables[0];
        connection.Close();
    }
    public static bool Update(Producto producto)
    {
        int result = 0;
        if (producto.Id > 0)
        {
             NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            connection.Open();
             NpgsqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE public.\"Producto\" SET  \"Nombre\"=@Nombre, \"Precio\"=@Precio, \"Descripcion\"=@Descripcion, \"Codigo\"=@Codigo, \"Unidad\"=@Unidad, \"Departamento\"=@Departamento WHERE \"idProducto\" = @Id";
            command.Parameters.AddWithValue("@Id", producto.Id);
            command.Parameters.AddWithValue("@Nombre", producto.Nombre);
            command.Parameters.AddWithValue("@Precio", producto.Precio);
            command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            command.Parameters.AddWithValue("@Codigo", producto.Codigo);
            command.Parameters.AddWithValue("@Unidad", producto.Unidad);
            command.Parameters.AddWithValue("@Departamento", producto.Departamento);
            result =  command.ExecuteNonQuery();
            connection.Close();
        }
        return result > 0;
    }
    public static bool Delete(int id)
    {
        var connection = new NpgsqlConnection(_connectionString);
        connection.Open();
         NpgsqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
        command.CommandText = "DELETE FROM public.\"Producto\" WHERE \"idProducto\" = @Id;";
        command.Parameters.AddWithValue("@Id", id);
        var result = command.ExecuteNonQuery();
        connection.Close();
        return result > 0;
    }
}