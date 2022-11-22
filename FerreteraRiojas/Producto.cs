using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerreteraRiojas
{
    public class Producto
    {
        public Producto()
        {
        }
        public Producto(int id,string nombre,int precio,string descripcion,string codigo,string unidad,string departamento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Codigo = codigo;
            this.Unidad = unidad;
            this.Departamento = departamento;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
        public string Codigo { get; set; }
        public string Unidad { get; set; }
        public string Departamento { get; set; }

    }
}
