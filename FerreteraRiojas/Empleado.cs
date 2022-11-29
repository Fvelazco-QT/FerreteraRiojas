using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteraRiojas
{
    internal class Empleado
    {
        public Empleado(int id, string Usuario, string Contraseña, string Nombre,Boolean bit)
        {
            this.Id = id;
            this.Usuario = Usuario;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;
            this.bit = bit;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public Boolean bit { get; set; }
    }
}
