namespace Cronos
{
    partial class frmVentas
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txIdProd = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarVentas = new FontAwesome.Sharp.IconButton();
            this.btnEliminarVentaPro = new FontAwesome.Sharp.IconButton();
            this.btnEditarVentaProd = new FontAwesome.Sharp.IconButton();
            this.btnVenderPro = new FontAwesome.Sharp.IconButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarProductos = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTIpoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(35, 304);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(363, 428);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // dgvVentas
            // 
            this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(428, 304);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(579, 428);
            this.dgvVentas.TabIndex = 1;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            this.ControlBox = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto";
            // 
            // txIdProd
            // 
            this.txIdProd.Enabled = false;
            this.txIdProd.Location = new System.Drawing.Point(38, 63);
            this.txIdProd.Name = "txIdProd";
            this.txIdProd.Size = new System.Drawing.Size(100, 20);
            this.txIdProd.TabIndex = 4;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(164, 63);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(264, 20);
            this.txtProducto.TabIndex = 5;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(449, 63);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(565, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio Total S/.";
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBuscarVentas.FlatAppearance.BorderSize = 0;
            this.btnBuscarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVentas.ForeColor = System.Drawing.Color.White;
            this.btnBuscarVentas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarVentas.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarVentas.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscarVentas.Location = new System.Drawing.Point(853, 229);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarVentas.Size = new System.Drawing.Size(154, 51);
            this.btnBuscarVentas.TabIndex = 42;
            this.btnBuscarVentas.Text = "Buscar";
            this.btnBuscarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarVentas.UseVisualStyleBackColor = false;
            // 
            // btnEliminarVentaPro
            // 
            this.btnEliminarVentaPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(130)))));
            this.btnEliminarVentaPro.FlatAppearance.BorderSize = 0;
            this.btnEliminarVentaPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarVentaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarVentaPro.ForeColor = System.Drawing.Color.White;
            this.btnEliminarVentaPro.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarVentaPro.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminarVentaPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarVentaPro.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEliminarVentaPro.Location = new System.Drawing.Point(396, 154);
            this.btnEliminarVentaPro.Name = "btnEliminarVentaPro";
            this.btnEliminarVentaPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarVentaPro.Size = new System.Drawing.Size(154, 51);
            this.btnEliminarVentaPro.TabIndex = 41;
            this.btnEliminarVentaPro.Text = "Eliminar";
            this.btnEliminarVentaPro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarVentaPro.UseVisualStyleBackColor = false;
            this.btnEliminarVentaPro.Click += new System.EventHandler(this.btnEliminarVentaPro_Click);
            // 
            // btnEditarVentaProd
            // 
            this.btnEditarVentaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.btnEditarVentaProd.FlatAppearance.BorderSize = 0;
            this.btnEditarVentaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarVentaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarVentaProd.ForeColor = System.Drawing.Color.White;
            this.btnEditarVentaProd.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditarVentaProd.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEditarVentaProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarVentaProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarVentaProd.Location = new System.Drawing.Point(217, 154);
            this.btnEditarVentaProd.Name = "btnEditarVentaProd";
            this.btnEditarVentaProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarVentaProd.Size = new System.Drawing.Size(154, 51);
            this.btnEditarVentaProd.TabIndex = 40;
            this.btnEditarVentaProd.Text = "Editar";
            this.btnEditarVentaProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarVentaProd.UseVisualStyleBackColor = false;
            this.btnEditarVentaProd.Click += new System.EventHandler(this.btnEditarVentaProd_Click);
            // 
            // btnVenderPro
            // 
            this.btnVenderPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnVenderPro.FlatAppearance.BorderSize = 0;
            this.btnVenderPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenderPro.ForeColor = System.Drawing.Color.White;
            this.btnVenderPro.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnVenderPro.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnVenderPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVenderPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenderPro.Location = new System.Drawing.Point(38, 154);
            this.btnVenderPro.Name = "btnVenderPro";
            this.btnVenderPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVenderPro.Size = new System.Drawing.Size(154, 51);
            this.btnVenderPro.TabIndex = 39;
            this.btnVenderPro.Text = "Vender";
            this.btnVenderPro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVenderPro.UseVisualStyleBackColor = false;
            this.btnVenderPro.Click += new System.EventHandler(this.btnVenderPro_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(671, 66);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(25, 13);
            this.lblPrecio.TabIndex = 43;
            this.lblPrecio.Text = "000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Precio de Stock S/.";
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBuscarProductos.FlatAppearance.BorderSize = 0;
            this.btnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductos.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProductos.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscarProductos.Location = new System.Drawing.Point(244, 229);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarProductos.Size = new System.Drawing.Size(154, 51);
            this.btnBuscarProductos.TabIndex = 45;
            this.btnBuscarProductos.Text = "Buscar";
            this.btnBuscarProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProductos.UseVisualStyleBackColor = false;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // txtBuscarProd
            // 
            this.txtBuscarProd.Location = new System.Drawing.Point(35, 245);
            this.txtBuscarProd.Name = "txtBuscarProd";
            this.txtBuscarProd.Size = new System.Drawing.Size(203, 20);
            this.txtBuscarProd.TabIndex = 46;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(428, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 20);
            this.textBox2.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Producto";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(38, 107);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(154, 20);
            this.txtCliente.TabIndex = 49;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 91);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 50;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTIpoPago
            // 
            this.lblTIpoPago.AutoSize = true;
            this.lblTIpoPago.Location = new System.Drawing.Point(198, 91);
            this.lblTIpoPago.Name = "lblTIpoPago";
            this.lblTIpoPago.Size = new System.Drawing.Size(71, 13);
            this.lblTIpoPago.TabIndex = 51;
            this.lblTIpoPago.Text = "Tipo de Pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Yape",
            "Plin",
            "Transferencia",
            "Tarjeta"});
            this.cboTipoPago.Location = new System.Drawing.Point(201, 107);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(121, 21);
            this.cboTipoPago.TabIndex = 52;
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Enabled = false;
            this.txtCodigoVenta.Location = new System.Drawing.Point(38, 24);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoVenta.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Codigo de venta";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 776);
            this.Controls.Add(this.txtCodigoVenta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.lblTIpoPago);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBuscarProd);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnBuscarVentas);
            this.Controls.Add(this.btnEliminarVentaPro);
            this.Controls.Add(this.btnEditarVentaProd);
            this.Controls.Add(this.btnVenderPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txIdProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.dgvProductos);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txIdProd;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnBuscarVentas;
        private FontAwesome.Sharp.IconButton btnEliminarVentaPro;
        private FontAwesome.Sharp.IconButton btnEditarVentaProd;
        private FontAwesome.Sharp.IconButton btnVenderPro;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnBuscarProductos;
        private System.Windows.Forms.TextBox txtBuscarProd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTIpoPago;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Label label7;
    }
}