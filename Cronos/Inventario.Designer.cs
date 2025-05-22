namespace Cronos
{
    partial class FrmInventario
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
            this.lbldProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtStockInicial = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblNombrePro = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.Entrada = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.btnBuscarProd = new FontAwesome.Sharp.IconButton();
            this.btnEliminarProd = new FontAwesome.Sharp.IconButton();
            this.btnEditarProd = new FontAwesome.Sharp.IconButton();
            this.btnGuardarPro = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldProd
            // 
            this.lbldProd.AutoSize = true;
            this.lbldProd.Location = new System.Drawing.Point(43, 36);
            this.lbldProd.Name = "lbldProd";
            this.lbldProd.Size = new System.Drawing.Size(75, 13);
            this.lbldProd.TabIndex = 0;
            this.lbldProd.Text = "Cod. Producto";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Enabled = false;
            this.txtIdProd.Location = new System.Drawing.Point(46, 52);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 20);
            this.txtIdProd.TabIndex = 1;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(153, 51);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(278, 20);
            this.txtNombreProd.TabIndex = 23;
            // 
            // txtStockInicial
            // 
            this.txtStockInicial.Location = new System.Drawing.Point(46, 90);
            this.txtStockInicial.Name = "txtStockInicial";
            this.txtStockInicial.Size = new System.Drawing.Size(100, 20);
            this.txtStockInicial.TabIndex = 25;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Suplementos deportivos",
            "Bebidas y alimentos saludables",
            "Ropa y accesorios deportivos",
            "Equipamiento pequeño",
            "Higiene y cuidado personal",
            "Productos promocionales / merch"});
            this.cboCategoria.Location = new System.Drawing.Point(437, 51);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(171, 21);
            this.cboCategoria.TabIndex = 26;
            // 
            // lblNombrePro
            // 
            this.lblNombrePro.AutoSize = true;
            this.lblNombrePro.Location = new System.Drawing.Point(150, 35);
            this.lblNombrePro.Name = "lblNombrePro";
            this.lblNombrePro.Size = new System.Drawing.Size(106, 13);
            this.lblNombrePro.TabIndex = 27;
            this.lblNombrePro.Text = "Nombre del producto";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(434, 35);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(43, 75);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(65, 13);
            this.lblStockInicial.TabIndex = 29;
            this.lblStockInicial.Text = "Stock Inicial";
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Location = new System.Drawing.Point(150, 76);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(44, 13);
            this.Entrada.TabIndex = 30;
            this.Entrada.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(152, 90);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 31;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(258, 90);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnitario.TabIndex = 32;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(255, 74);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(94, 13);
            this.lblPrecioUnitario.TabIndex = 33;
            this.lblPrecioUnitario.Text = "Precio Unitario S/.";
            this.lblPrecioUnitario.Click += new System.EventHandler(this.lblPrecioUnitario_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(46, 129);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(210, 20);
            this.txtProveedor.TabIndex = 34;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(43, 113);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 35;
            this.lblProveedor.Text = "Proveedor";
            // 
            // dgvProducto
            // 
            this.dgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(46, 240);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(742, 412);
            this.dgvProducto.TabIndex = 39;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBuscarProd.FlatAppearance.BorderSize = 0;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProd.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscarProd.Location = new System.Drawing.Point(581, 183);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscarProd.Size = new System.Drawing.Size(154, 51);
            this.btnBuscarProd.TabIndex = 38;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(130)))));
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProd.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarProd.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(404, 183);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarProd.Size = new System.Drawing.Size(154, 51);
            this.btnEliminarProd.TabIndex = 37;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.btnEditarProd.FlatAppearance.BorderSize = 0;
            this.btnEditarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProd.ForeColor = System.Drawing.Color.White;
            this.btnEditarProd.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditarProd.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEditarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarProd.Location = new System.Drawing.Point(225, 183);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarProd.Size = new System.Drawing.Size(154, 51);
            this.btnEditarProd.TabIndex = 36;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarProd.UseVisualStyleBackColor = false;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // btnGuardarPro
            // 
            this.btnGuardarPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarPro.FlatAppearance.BorderSize = 0;
            this.btnGuardarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPro.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPro.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarPro.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGuardarPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPro.Location = new System.Drawing.Point(46, 183);
            this.btnGuardarPro.Name = "btnGuardarPro";
            this.btnGuardarPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardarPro.Size = new System.Drawing.Size(154, 51);
            this.btnGuardarPro.TabIndex = 22;
            this.btnGuardarPro.Text = "Guardar";
            this.btnGuardarPro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardarPro.UseVisualStyleBackColor = false;
            this.btnGuardarPro.Click += new System.EventHandler(this.btnGuardarPro_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 682);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnEditarProd);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombrePro);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.txtStockInicial);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.btnGuardarPro);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lbldProd);
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldProd;
        private System.Windows.Forms.TextBox txtIdProd;
        private FontAwesome.Sharp.IconButton btnGuardarPro;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtStockInicial;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblNombrePro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProd;
        private FontAwesome.Sharp.IconButton btnEliminarProd;
        private FontAwesome.Sharp.IconButton btnEditarProd;
        private System.Windows.Forms.DataGridView dgvProducto;
    }
}