using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
namespace FerreteraRiojas
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Producto[] producto = new Producto[2];

            //new Producto{ Nombre = "a",Precio = 1,Descripcion = "a",Departamento = "a",Codigo = "a",Unidad = "a"};
            producto[0] = new Producto { Nombre = "a", Precio = 1, Descripcion = "a", Departamento = "a", Codigo = "a", Unidad = "a" };
            producto[1] = new Producto { Nombre = "b", Precio = 2, Descripcion = "b", Departamento = "b" };

            MessageBox.Show(producto[0].Nombre + producto[1]);
        }

        private void txtCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "") { MessageBox.Show("El campo nombre es obligatorio");return; };
                var ID = CRUD.Create(new Producto { Nombre = txtNombre.Text, Precio = (int)numPrecio.Value, Descripcion = txtDescripcion.Text, Departamento = txtDepartamento.Text, Codigo = txtCodigo.Text, Unidad = txtUnidad.Text });
                MessageBox.Show("Producto agregado correctamente, ID:" + ID );
                txtNombre.Clear();
                numPrecio.Value = 0;
                txtDescripcion.Clear();
                txtDepartamento.Clear();
                txtCodigo.Clear();
                txtUnidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public Producto busqueda;
        private void btnVer_Click(object sender, EventArgs e)
        {
            busqueda = CRUD.Read((int)numIdArticulo.Value);
            if (busqueda==null){MessageBox.Show("No existe"); return; };
            txtNombre.Text = busqueda.Nombre;
            numPrecio.Value = busqueda.Precio;
            txtDescripcion.Text = busqueda.Descripcion;
            txtDepartamento.Text = busqueda.Departamento;
            txtCodigo.Text = busqueda.Codigo;
            txtUnidad.Text = busqueda.Unidad;
            
        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            if (busqueda == null) { MessageBox.Show("No hay producto para actualizar.\nSelecciona uno"); return; };
            busqueda.Nombre = txtNombre.Text ;
            busqueda.Precio = (int)numPrecio.Value ;
            busqueda.Descripcion = txtDescripcion.Text ;
            busqueda.Departamento = txtDepartamento.Text;
            busqueda.Codigo = txtCodigo.Text;
            busqueda.Unidad = txtUnidad.Text;
            CRUD.Update(busqueda);
            MessageBox.Show($"Producto: {busqueda.Id} actualizado");
            busqueda = null;
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (busqueda == null) { MessageBox.Show("No hay producto para borrar.\nSelecciona uno"); return; };
            if (MessageBox.Show("¿Estas segur@ de eliminar este producto?\nSe eliminara permanentemente", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CRUD.Delete((int)numIdArticulo.Value);
                txtNombre.Clear();
                numPrecio.Value = 0;
                txtDescripcion.Clear();
                txtDepartamento.Clear();
                txtCodigo.Clear();
                txtUnidad.Clear();
                MessageBox.Show($"Producto: {(int)numIdArticulo.Value} eliminado");
            }
        }

        private void btnTodo_Click(object sender, EventArgs e)
        {
             CRUD.ReadAll(dgvProductos);
        }
    }
}
