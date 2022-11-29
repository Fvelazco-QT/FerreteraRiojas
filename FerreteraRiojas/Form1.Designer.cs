namespace FerreteraRiojas
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUpdate = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCrear = new System.Windows.Forms.Button();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnVer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numIdArticulo = new System.Windows.Forms.NumericUpDown();
            this.txtDelete = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(146, 362);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(98, 23);
            this.txtUpdate.TabIndex = 0;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(384, 12);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(404, 477);
            this.dgvProductos.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 185);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(228, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 225);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(228, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(102, 270);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(228, 20);
            this.txtUnidad.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(102, 316);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(228, 20);
            this.txtDepartamento.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Departamento";
            // 
            // txtCrear
            // 
            this.txtCrear.Location = new System.Drawing.Point(19, 362);
            this.txtCrear.Name = "txtCrear";
            this.txtCrear.Size = new System.Drawing.Size(96, 23);
            this.txtCrear.TabIndex = 14;
            this.txtCrear.Text = "Create";
            this.txtCrear.UseVisualStyleBackColor = true;
            this.txtCrear.Click += new System.EventHandler(this.txtCrear_Click);
            // 
            // numPrecio
            // 
            this.numPrecio.Location = new System.Drawing.Point(102, 149);
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(228, 20);
            this.numPrecio.TabIndex = 15;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(288, 27);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 17;
            this.btnVer.Text = "Read";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id del articulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ver";
            // 
            // numIdArticulo
            // 
            this.numIdArticulo.Location = new System.Drawing.Point(98, 28);
            this.numIdArticulo.Name = "numIdArticulo";
            this.numIdArticulo.Size = new System.Drawing.Size(184, 20);
            this.numIdArticulo.TabIndex = 20;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(269, 362);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(98, 23);
            this.txtDelete.TabIndex = 21;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(279, 70);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(90, 23);
            this.btnTodo.TabIndex = 22;
            this.btnTodo.Text = "Read all";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnJson);
            this.groupControl1.Controls.Add(this.btnXml);
            this.groupControl1.Controls.Add(this.btnPdf);
            this.groupControl1.Controls.Add(this.btnCsv);
            this.groupControl1.Controls.Add(this.btnTxt);
            this.groupControl1.Location = new System.Drawing.Point(12, 395);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(357, 94);
            this.groupControl1.TabIndex = 25;
            this.groupControl1.Text = "Exportar";
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(5, 26);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(98, 23);
            this.btnTxt.TabIndex = 26;
            this.btnTxt.Text = ".txt";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(121, 26);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(102, 23);
            this.btnCsv.TabIndex = 27;
            this.btnCsv.Text = ".csv";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(238, 26);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(98, 23);
            this.btnPdf.TabIndex = 28;
            this.btnPdf.Text = ".pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click_1);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(43, 55);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(132, 23);
            this.btnXml.TabIndex = 29;
            this.btnXml.Text = ".xml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(181, 55);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(132, 23);
            this.btnJson.TabIndex = 30;
            this.btnJson.Text = ".json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.numIdArticulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.numPrecio);
            this.Controls.Add(this.txtCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtUpdate);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtCrear;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numIdArticulo;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button btnTodo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnTxt;
    }
}

