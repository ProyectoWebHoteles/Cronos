using System.Windows.Forms;

namespace Cronos
{
    partial class formCliente
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
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lbltipoMembresia = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lbldni = new System.Windows.Forms.Label();
            this.cboTipoMembresia = new System.Windows.Forms.ComboBox();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaVenc = new System.Windows.Forms.Label();
            this.dtpFechaVenc = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimi = new System.Windows.Forms.Label();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblErrorDni = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCli = new FontAwesome.Sharp.IconButton();
            this.btnEditarCli = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCli = new FontAwesome.Sharp.IconButton();
            this.btnCalcularDias = new FontAwesome.Sharp.IconButton();
            this.CheckEditar = new System.Windows.Forms.CheckBox();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.cboTipoDePago = new System.Windows.Forms.ComboBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.toltipMensajes = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(46, 38);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(123, 13);
            this.lblTipoDocumento.TabIndex = 0;
            this.lblTipoDocumento.Text = "TIPO DE DOCUMENTO";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(328, 39);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(61, 13);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "NOMBRES";
            this.lblNombres.Click += new System.EventHandler(this.lblNombres_Click);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(469, 38);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "APELLIDOS";
            // 
            // lbltipoMembresia
            // 
            this.lbltipoMembresia.AutoSize = true;
            this.lbltipoMembresia.Location = new System.Drawing.Point(49, 132);
            this.lbltipoMembresia.Name = "lbltipoMembresia";
            this.lbltipoMembresia.Size = new System.Drawing.Size(117, 13);
            this.lbltipoMembresia.TabIndex = 3;
            this.lbltipoMembresia.Text = "TIPO DE MEMBRESIA";
            this.lbltipoMembresia.Click += new System.EventHandler(this.lbltipo_Click);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(47, 82);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(127, 13);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "TELEFONO O CELULAR";
            this.lbltelefono.Click += new System.EventHandler(this.lbltelefono_Click);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(195, 82);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(66, 13);
            this.lbldireccion.TabIndex = 5;
            this.lbldireccion.Text = "DIRECCION";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(328, 83);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(53, 13);
            this.lblcorreo.TabIndex = 6;
            this.lblcorreo.Text = "CORREO";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(198, 55);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 2;
            this.txtdni.TextChanged += new System.EventHandler(this.txtdni_TextChanged);
            this.txtdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdni_KeyPress);
            this.txtdni.Leave += new System.EventHandler(this.txtdni_Leave);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(331, 54);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(120, 20);
            this.txtnombres.TabIndex = 3;
            this.txtnombres.TextChanged += new System.EventHandler(this.txtnombres_TextChanged);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(472, 54);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(100, 20);
            this.txtapellidos.TabIndex = 4;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(50, 101);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(120, 20);
            this.txttelefono.TabIndex = 6;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(198, 101);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(331, 101);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(120, 20);
            this.txtcorreo.TabIndex = 8;
            this.txtcorreo.TextChanged += new System.EventHandler(this.txtcorreo_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(48, 292);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(960, 383);
            this.dgvCliente.TabIndex = 17;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "CE"});
            this.CboTipoDoc.Location = new System.Drawing.Point(49, 55);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.CboTipoDoc.TabIndex = 1;
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(198, 37);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(110, 13);
            this.lbldni.TabIndex = 19;
            this.lbldni.Text = "N° DE DOCUMENTO";
            // 
            // cboTipoMembresia
            // 
            this.cboTipoMembresia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMembresia.FormattingEnabled = true;
            this.cboTipoMembresia.Items.AddRange(new object[] {
            "Sin Membresia",
            "Socio Black",
            "Socio Normal"});
            this.cboTipoMembresia.Location = new System.Drawing.Point(51, 148);
            this.cboTipoMembresia.Name = "cboTipoMembresia";
            this.cboTipoMembresia.Size = new System.Drawing.Size(121, 21);
            this.cboTipoMembresia.TabIndex = 12;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Location = new System.Drawing.Point(201, 149);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIni.TabIndex = 13;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(201, 133);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(95, 13);
            this.lblFechaInicio.TabIndex = 26;
            this.lblFechaInicio.Text = "FECHA DE INICIO";
            // 
            // lblFechaVenc
            // 
            this.lblFechaVenc.AutoSize = true;
            this.lblFechaVenc.Location = new System.Drawing.Point(421, 133);
            this.lblFechaVenc.Name = "lblFechaVenc";
            this.lblFechaVenc.Size = new System.Drawing.Size(137, 13);
            this.lblFechaVenc.TabIndex = 27;
            this.lblFechaVenc.Text = "FECHA DE VENCIMIENTO";
            // 
            // dtpFechaVenc
            // 
            this.dtpFechaVenc.Enabled = false;
            this.dtpFechaVenc.Location = new System.Drawing.Point(424, 149);
            this.dtpFechaVenc.Name = "dtpFechaVenc";
            this.dtpFechaVenc.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenc.TabIndex = 14;
            // 
            // lblFechaNacimi
            // 
            this.lblFechaNacimi.AutoSize = true;
            this.lblFechaNacimi.Location = new System.Drawing.Point(472, 85);
            this.lblFechaNacimi.Name = "lblFechaNacimi";
            this.lblFechaNacimi.Size = new System.Drawing.Size(130, 13);
            this.lblFechaNacimi.TabIndex = 30;
            this.lblFechaNacimi.Text = "FECHA DE NACIMIENTO";
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Location = new System.Drawing.Point(472, 101);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNaci.TabIndex = 9;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Desactivo",
            "Suspendido"});
            this.cboEstado.Location = new System.Drawing.Point(783, 147);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(780, 132);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(51, 13);
            this.lblEstado.TabIndex = 32;
            this.lblEstado.Text = "ESTADO";
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Indefinido",
            "Prefiere no decir"});
            this.cboGenero.Location = new System.Drawing.Point(597, 53);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(121, 21);
            this.cboGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(594, 36);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 13);
            this.lblGenero.TabIndex = 34;
            this.lblGenero.Text = "GENERO";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblEmpleado.Location = new System.Drawing.Point(728, 9);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(35, 13);
            this.lblEmpleado.TabIndex = 36;
            this.lblEmpleado.Text = "label1";
            // 
            // lblErrorDni
            // 
            this.lblErrorDni.AutoSize = true;
            this.lblErrorDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDni.ForeColor = System.Drawing.Color.White;
            this.lblErrorDni.Location = new System.Drawing.Point(198, 24);
            this.lblErrorDni.Name = "lblErrorDni";
            this.lblErrorDni.Size = new System.Drawing.Size(29, 12);
            this.lblErrorDni.TabIndex = 37;
            this.lblErrorDni.Text = "label1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBuscar.Location = new System.Drawing.Point(578, 235);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBuscar.Size = new System.Drawing.Size(154, 51);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(139)))), ((int)(((byte)(130)))));
            this.btnEliminarCli.FlatAppearance.BorderSize = 0;
            this.btnEliminarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCli.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCli.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarCli.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEliminarCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCli.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEliminarCli.Location = new System.Drawing.Point(401, 235);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarCli.Size = new System.Drawing.Size(154, 51);
            this.btnEliminarCli.TabIndex = 22;
            this.btnEliminarCli.Text = "Eliminar";
            this.btnEliminarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarCli.UseVisualStyleBackColor = false;
            this.btnEliminarCli.Click += new System.EventHandler(this.btnEliminarCli_Click);
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(145)))));
            this.btnEditarCli.FlatAppearance.BorderSize = 0;
            this.btnEditarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCli.ForeColor = System.Drawing.Color.White;
            this.btnEditarCli.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.btnEditarCli.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEditarCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarCli.Location = new System.Drawing.Point(222, 235);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarCli.Size = new System.Drawing.Size(154, 51);
            this.btnEditarCli.TabIndex = 21;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditarCli.UseVisualStyleBackColor = false;
            this.btnEditarCli.Click += new System.EventHandler(this.btnEditarCli_Click);
            // 
            // btnGuardarCli
            // 
            this.btnGuardarCli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnGuardarCli.FlatAppearance.BorderSize = 0;
            this.btnGuardarCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCli.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCli.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardarCli.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGuardarCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCli.Location = new System.Drawing.Point(45, 235);
            this.btnGuardarCli.Name = "btnGuardarCli";
            this.btnGuardarCli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGuardarCli.Size = new System.Drawing.Size(154, 51);
            this.btnGuardarCli.TabIndex = 20;
            this.btnGuardarCli.Text = "Guardar";
            this.btnGuardarCli.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardarCli.UseVisualStyleBackColor = false;
            this.btnGuardarCli.Click += new System.EventHandler(this.btnGuardarCli_Click);
            this.btnGuardarCli.Leave += new System.EventHandler(this.btnGuardarCli_Leave);
            // 
            // btnCalcularDias
            // 
            this.btnCalcularDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalcularDias.FlatAppearance.BorderSize = 0;
            this.btnCalcularDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDias.ForeColor = System.Drawing.Color.White;
            this.btnCalcularDias.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCalcularDias.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCalcularDias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcularDias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularDias.Location = new System.Drawing.Point(45, 178);
            this.btnCalcularDias.Name = "btnCalcularDias";
            this.btnCalcularDias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCalcularDias.Size = new System.Drawing.Size(154, 51);
            this.btnCalcularDias.TabIndex = 19;
            this.btnCalcularDias.Text = "Calcular";
            this.btnCalcularDias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCalcularDias.UseVisualStyleBackColor = false;
            this.btnCalcularDias.Click += new System.EventHandler(this.btnCalcularDias_Click);
            // 
            // CheckEditar
            // 
            this.CheckEditar.AutoSize = true;
            this.CheckEditar.Location = new System.Drawing.Point(424, 175);
            this.CheckEditar.Name = "CheckEditar";
            this.CheckEditar.Size = new System.Drawing.Size(72, 17);
            this.CheckEditar.TabIndex = 15;
            this.CheckEditar.Text = "Editar F.V";
            this.CheckEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckEditar.UseVisualStyleBackColor = true;
            this.CheckEditar.CheckedChanged += new System.EventHandler(this.CheckEditar_CheckedChanged);
            this.CheckEditar.Leave += new System.EventHandler(this.CheckEditar_Leave);
            this.CheckEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckEditar_MouseClick);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(650, 149);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(46, 20);
            this.txtMeses.TabIndex = 16;
            this.txtMeses.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(647, 132);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 40;
            this.lblMeses.Text = "Meses";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(707, 132);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 42;
            this.lblDias.Text = "Dias";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(710, 148);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(46, 20);
            this.txtDia.TabIndex = 17;
            this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // cboTipoDePago
            // 
            this.cboTipoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDePago.FormattingEnabled = true;
            this.cboTipoDePago.Items.AddRange(new object[] {
            "Efectivo",
            "Yape",
            "Plin",
            "Transferencia",
            "Tarjeta"});
            this.cboTipoDePago.Location = new System.Drawing.Point(756, 99);
            this.cboTipoDePago.Name = "cboTipoDePago";
            this.cboTipoDePago.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDePago.TabIndex = 11;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(754, 83);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(71, 13);
            this.lblTipoPago.TabIndex = 44;
            this.lblTipoPago.Text = "Tipo de Pago";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(692, 100);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(46, 20);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(689, 83);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 13);
            this.lblMonto.TabIndex = 46;
            this.lblMonto.Text = "Monto S/.";
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.BackColor = System.Drawing.Color.White;
            this.lblHabilitado.ForeColor = System.Drawing.Color.White;
            this.lblHabilitado.Location = new System.Drawing.Point(565, 132);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(35, 13);
            this.lblHabilitado.TabIndex = 48;
            this.lblHabilitado.Text = "label1";
            // 
            // toltipMensajes
            // 
            this.toltipMensajes.Location = new System.Drawing.Point(0, 0);
            this.toltipMensajes.Name = "toltipMensajes";
            this.toltipMensajes.Size = new System.Drawing.Size(1020, 25);
            this.toltipMensajes.TabIndex = 49;
            this.toltipMensajes.Text = "toolStrip1";
            // 
            // formCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 730);
            this.Controls.Add(this.toltipMensajes);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cboTipoDePago);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.CheckEditar);
            this.Controls.Add(this.btnCalcularDias);
            this.Controls.Add(this.lblErrorDni);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFechaNacimi);
            this.Controls.Add(this.dtpFechaNaci);
            this.Controls.Add(this.dtpFechaVenc);
            this.Controls.Add(this.lblFechaVenc);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.btnEliminarCli);
            this.Controls.Add(this.btnEditarCli);
            this.Controls.Add(this.btnGuardarCli);
            this.Controls.Add(this.cboTipoMembresia);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.CboTipoDoc);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbltipoMembresia);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblTipoDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "formCliente";
            this.ShowIcon = false;
            this.Text = "Registrar Cliente";
            this.Load += new System.EventHandler(this.lblformCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lbltipoMembresia;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ComboBox CboTipoDoc;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.ComboBox cboTipoMembresia;
        private FontAwesome.Sharp.IconButton btnGuardarCli;
        private FontAwesome.Sharp.IconButton btnEditarCli;
        private FontAwesome.Sharp.IconButton btnEliminarCli;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaVenc;
        private System.Windows.Forms.DateTimePicker dtpFechaVenc;
        private System.Windows.Forms.Label lblFechaNacimi;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblErrorDni;
        private FontAwesome.Sharp.IconButton btnCalcularDias;
        private CheckBox CheckEditar;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private TextBox txtMeses;
        private Label lblMeses;
        private Label lblDias;
        private TextBox txtDia;
        private ComboBox cboTipoDePago;
        private Label lblTipoPago;
        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblHabilitado;
        private ToolStrip toltipMensajes;
    }
}

