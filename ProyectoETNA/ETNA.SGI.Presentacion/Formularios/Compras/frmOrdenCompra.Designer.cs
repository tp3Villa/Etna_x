namespace ETNA.SGI.Presentacion.Formularios.Compras
{
    partial class frmOrdenCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMoneda = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtLugarEntrega = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequerimiento = new System.Windows.Forms.TextBox();
            this.btnBuscarRequerimiento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.dtGridDetalleOC = new System.Windows.Forms.DataGridView();
            this.valida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalleOC)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moneda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lugar Entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observacion";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(113, 71);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(121, 21);
            this.cboMoneda.TabIndex = 5;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(393, 71);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(98, 20);
            this.dtpFechaEntrega.TabIndex = 6;
            // 
            // txtLugarEntrega
            // 
            this.txtLugarEntrega.Location = new System.Drawing.Point(113, 108);
            this.txtLugarEntrega.Name = "txtLugarEntrega";
            this.txtLugarEntrega.Size = new System.Drawing.Size(291, 20);
            this.txtLugarEntrega.TabIndex = 7;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(113, 144);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(291, 49);
            this.txtObservacion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Requerimiento";
            // 
            // txtRequerimiento
            // 
            this.txtRequerimiento.Enabled = false;
            this.txtRequerimiento.Location = new System.Drawing.Point(113, 208);
            this.txtRequerimiento.Name = "txtRequerimiento";
            this.txtRequerimiento.Size = new System.Drawing.Size(80, 20);
            this.txtRequerimiento.TabIndex = 10;
            // 
            // btnBuscarRequerimiento
            // 
            this.btnBuscarRequerimiento.Image = global::ETNA.SGI.Presentacion.Properties.Resources.apercu;
            this.btnBuscarRequerimiento.Location = new System.Drawing.Point(207, 208);
            this.btnBuscarRequerimiento.Name = "btnBuscarRequerimiento";
            this.btnBuscarRequerimiento.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarRequerimiento.TabIndex = 11;
            this.btnBuscarRequerimiento.UseVisualStyleBackColor = true;
            this.btnBuscarRequerimiento.Click += new System.EventHandler(this.btnBuscarRequerimiento_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cotiz. aprobada";
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Enabled = false;
            this.txtCotizacion.Location = new System.Drawing.Point(113, 239);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(80, 20);
            this.txtCotizacion.TabIndex = 13;
            // 
            // dtGridDetalleOC
            // 
            this.dtGridDetalleOC.AllowUserToAddRows = false;
            this.dtGridDetalleOC.AllowUserToDeleteRows = false;
            this.dtGridDetalleOC.AllowUserToResizeColumns = false;
            this.dtGridDetalleOC.AllowUserToResizeRows = false;
            this.dtGridDetalleOC.BackgroundColor = System.Drawing.Color.White;
            this.dtGridDetalleOC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtGridDetalleOC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtGridDetalleOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDetalleOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valida,
            this.codProducto,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.dtGridDetalleOC.Location = new System.Drawing.Point(32, 274);
            this.dtGridDetalleOC.Name = "dtGridDetalleOC";
            this.dtGridDetalleOC.RowHeadersVisible = false;
            this.dtGridDetalleOC.Size = new System.Drawing.Size(459, 157);
            this.dtGridDetalleOC.TabIndex = 108;
            // 
            // valida
            // 
            this.valida.HeaderText = "";
            this.valida.Name = "valida";
            this.valida.Width = 35;
            // 
            // codProducto
            // 
            this.codProducto.DataPropertyName = "1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codProducto.DefaultCellStyle = dataGridViewCellStyle1;
            this.codProducto.HeaderText = "Producto";
            this.codProducto.Name = "codProducto";
            this.codProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codProducto.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(276, 239);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(215, 20);
            this.txtProveedor.TabIndex = 110;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 109;
            this.label8.Text = "Proveedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "% Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "IGV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 113;
            this.label11.Text = "Total";
            // 
            // txtIgv
            // 
            this.txtIgv.Enabled = false;
            this.txtIgv.Location = new System.Drawing.Point(113, 471);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.Size = new System.Drawing.Size(52, 20);
            this.txtIgv.TabIndex = 114;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(113, 497);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(52, 20);
            this.txtTotal.TabIndex = 115;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(113, 443);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(52, 20);
            this.txtDescuento.TabIndex = 116;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(20, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(503, 49);
            this.groupBox6.TabIndex = 120;
            this.groupBox6.TabStop = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(6, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(486, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Órden de Compra";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNuevo);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(191, 530);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 81);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ETNA.SGI.Presentacion.Properties.Resources.FACTURAR12;
            this.btnNuevo.Location = new System.Drawing.Point(11, 18);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 57);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Generar";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::ETNA.SGI.Presentacion.Properties.Resources.ELIMINA;
            this.btnClose.Location = new System.Drawing.Point(80, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 57);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Salir";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtGridDetalleOC);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarRequerimiento);
            this.Controls.Add(this.txtRequerimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtLugarEntrega);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.cboMoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdenCompra";
            this.Text = "Generar Orden de Compra";
            this.Load += new System.EventHandler(this.frmOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalleOC)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMoneda;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.TextBox txtLugarEntrega;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRequerimiento;
        private System.Windows.Forms.Button btnBuscarRequerimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.DataGridView dtGridDetalleOC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn valida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIgv;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnClose;
    }
}