namespace ETNA.SGI.Presentacion.Formularios.Compras
{
    partial class frmListadoCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindReq = new System.Windows.Forms.Button();
            this.txtRequerimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindProv = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.valida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRequerimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaExpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(9, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(853, 49);
            this.groupBox6.TabIndex = 102;
            this.groupBox6.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(841, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Lista de Cotizaciones";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindReq);
            this.groupBox1.Controls.Add(this.txtRequerimiento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFindProv);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.txtProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(9, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 85);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // btnFindReq
            // 
            this.btnFindReq.Image = global::ETNA.SGI.Presentacion.Properties.Resources.apercu;
            this.btnFindReq.Location = new System.Drawing.Point(243, 34);
            this.btnFindReq.Name = "btnFindReq";
            this.btnFindReq.Size = new System.Drawing.Size(27, 23);
            this.btnFindReq.TabIndex = 137;
            this.btnFindReq.UseVisualStyleBackColor = true;
            // 
            // txtRequerimiento
            // 
            this.txtRequerimiento.Enabled = false;
            this.txtRequerimiento.Location = new System.Drawing.Point(100, 36);
            this.txtRequerimiento.Name = "txtRequerimiento";
            this.txtRequerimiento.Size = new System.Drawing.Size(137, 20);
            this.txtRequerimiento.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Requerimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 134;
            this.label1.Text = "Proveedor:";
            // 
            // btnFindProv
            // 
            this.btnFindProv.Image = global::ETNA.SGI.Presentacion.Properties.Resources.apercu;
            this.btnFindProv.Location = new System.Drawing.Point(519, 34);
            this.btnFindProv.Name = "btnFindProv";
            this.btnFindProv.Size = new System.Drawing.Size(27, 23);
            this.btnFindProv.TabIndex = 133;
            this.btnFindProv.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "GENERADA",
            "ANULADA"});
            this.cboEstado.Location = new System.Drawing.Point(629, 35);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 108;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(375, 37);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(137, 20);
            this.txtProveedor.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Estado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ETNA.SGI.Presentacion.Properties.Resources.Buscar;
            this.btnBuscar.Location = new System.Drawing.Point(792, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 57);
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valida,
            this.codCotizacion,
            this.codRequerimiento,
            this.codProveedor,
            this.descripcion,
            this.telefono,
            this.fechaExpiracion,
            this.codEstado,
            this.editar});
            this.dataGridView1.Location = new System.Drawing.Point(7, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(860, 210);
            this.dataGridView1.TabIndex = 109;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(355, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 81);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ETNA.SGI.Presentacion.Properties.Resources.BO12;
            this.btnNuevo.Location = new System.Drawing.Point(11, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(55, 57);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ETNA.SGI.Presentacion.Properties.Resources.ELIMINA;
            this.btnClose.Location = new System.Drawing.Point(72, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Salir";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // valida
            // 
            this.valida.HeaderText = "";
            this.valida.Name = "valida";
            this.valida.Width = 35;
            // 
            // codCotizacion
            // 
            this.codCotizacion.DataPropertyName = "codCotizacion";
            this.codCotizacion.HeaderText = "Cotización";
            this.codCotizacion.Name = "codCotizacion";
            // 
            // codRequerimiento
            // 
            this.codRequerimiento.DataPropertyName = "codRequerimiento";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codRequerimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.codRequerimiento.HeaderText = "Requerimiento";
            this.codRequerimiento.Name = "codRequerimiento";
            this.codRequerimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codRequerimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codRequerimiento.Width = 120;
            // 
            // codProveedor
            // 
            this.codProveedor.DataPropertyName = "codProveedor";
            this.codProveedor.HeaderText = "Proveedor";
            this.codProveedor.Name = "codProveedor";
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // fechaExpiracion
            // 
            this.fechaExpiracion.DataPropertyName = "fechaExpiracion";
            this.fechaExpiracion.HeaderText = "Fecha de Expiración";
            this.fechaExpiracion.Name = "fechaExpiracion";
            // 
            // codEstado
            // 
            this.codEstado.DataPropertyName = "codEstado";
            this.codEstado.HeaderText = "Estado";
            this.codEstado.Name = "codEstado";
            // 
            // editar
            // 
            this.editar.HeaderText = "";
            this.editar.Image = global::ETNA.SGI.Presentacion.Properties.Resources.Operaciones;
            this.editar.Name = "editar";
            // 
            // frmListadoCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Name = "frmListadoCotizacion";
            this.Text = "Listado de Cotizaciones";
            this.Load += new System.EventHandler(this.frmListadoCotizacion_Load_1);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindProv;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnFindReq;
        private System.Windows.Forms.TextBox txtRequerimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRequerimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaExpiracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEstado;
        private System.Windows.Forms.DataGridViewImageColumn editar;
    }
}