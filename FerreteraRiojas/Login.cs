using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FerreteraRiojas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
        string _connectionString = "Host=localhost;Username=postgres;Password=masterkey;Database=FerreteraRiojas";
        NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
        connection.Open();
        NpgsqlCommand command = connection.CreateCommand();
        command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT \"Usuario\", \"Contraseña\" FROM public.\"Empleado\" where \"Usuario\" = '{txtUsuario.Text}' and \"Contraseña\" = '{txtContraseña.Text}';";
            NpgsqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows){MessageBox.Show("Contraseña incorrecta o usuario incorrecto"); return; }
            Menu me = new Menu();
            me.ShowDialog();
            connection.Close();
            txtUsuario.Text = "";txtContraseña.Text = "";

        }
    }
}
