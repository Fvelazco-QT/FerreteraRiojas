using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.CommonDialogs;
using System.Text.Json;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FerreteraRiojas
{
    public partial class Menu : Form
    {

        public Menu()
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
        System.Data.DataTable dt = Conexion.ConsultaSelect("SELECT * FROM public.\"Producto\"; ");


        private void btnTxt_Click(object sender, EventArgs e)
        {

            using (StreamWriter file = new StreamWriter("archivo.txt", true))
            {
               
                foreach (DataRow row in dt.Rows)
                {
                    List<string> items = new List<string>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        items.Add(row[col.ColumnName].ToString());


                    }
                    string linea = string.Join("|", items.ToArray());
                    file.WriteLine(linea);
                }
            }
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dtDataTable = dt;
            StreamWriter sw = new StreamWriter("archivo.csv", false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void btnPdf_Click_1(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("archivo.pdf", FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                widths[i] = 4f;

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int h = 0; h < dt.Columns.Count; h++)
                    {
                        table.AddCell(new Phrase(r[h].ToString(), font5));
                    }
                }
            }
            document.Add(table);
            document.Close();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);
            dataSet.WriteXml("archivo.xml");
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            string jsonString = string.Empty;
            jsonString = JsonConvert.SerializeObject(dt);
            
            string json = JsonSerializer.Serialize(jsonString);
            File.WriteAllText("archivo.json", json);
        }
    }
}
