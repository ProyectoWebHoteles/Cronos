namespace Cronos
{
    partial class frmAsistencias
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
            this.lblndoc = new System.Windows.Forms.Label();
            this.lblNombreCLi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNdoc = new System.Windows.Forms.TextBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.cboTipoMembre = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.btnEliminarVentaPro = new FontAwesome.Sharp.IconButton();
            this.btnguardarAsistencia = new FontAwesome.Sharp.IconButton();
            this.txtIdAsitencias = new System.Windows.Forms.TextBox();
            this.lblIdAsistencias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblndoc
            // 
            this.lblndoc.AutoSize = true;
            this.lblndoc.Location = new System.Drawing.Point(57, 66);
            this.lblndoc.Name = "lblndoc";
            this.lblndoc.Size = new System.Drawing.Size(42, 13);
            this.lblndoc.TabIndex = 0;
            this.lblndoc.Text = "N° Doc";
            // 
            // lblNombreCLi
            // 
            this.lblNombreCLi.AutoSize = true;
            this.lblNombreCLi.Location = new System.Drawing.Point(180, 66);
            this.lblNombreCLi.Name = "lblNombreCLi";
            this.lblNombreCLi.Size = new System.Drawing.Size(94, 13);
            this.lblNombreCLi.TabIndex = 1;
            this.lblNombreCLi.Text = "Nombre de Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Membresia";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(529, 66);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio S/.";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNdoc
            // 
            this.txtNdoc.Location = new System.Drawing.Point(60, 82);
            this.txtNdoc.Name = "txtNdoc";
            this.txtNdoc.Size = new System.Drawing.Size(100, 20);
            this.txtNdoc.TabIndex = 5;
            this.txtNdoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNdoc_KeyDown);
            this.txtNdoc.Leave += new System.EventHandler(this.txtNdoc_Leave);
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Enabled = false;
            this.txtNombreCli.Location = new System.Drawing.Point(183, 82);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(189, 20);
            this.txtNombreCli.TabIndex = 6;
            // 
            // cboTipoMembre
            // 
            this.cboTipoMembre.Enabled = false;
            this.cboTipoMembre.FormattingEnabled = true;
            this.cboTipoMembre.Location = new System.Drawing.Point(394, 81);
            this.cboTipoMembre.Name = "cboTipoMembre";
            this.cboTipoMembre.Size = new System.Drawing.Size(121, 21);
            this.cboTipoMembre.TabIndex = 7;
            this.cboTipoMembre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboTipoMembre_KeyUp);
            this.cboTipoMembre.Leave += new System.EventHandler(this.cboTipoMembre_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(532, 82);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 8;
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Location = new System.Drawing.Point(61, 207);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.Size = new System.Drawing.Size(762, 462);
            this.dgvAsistencia.TabIndex = 44;
            this.dgvAsistencia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellClick);
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
            this.btnEliminarVentaPro.Location = new System.Drawing.Point(234, 119);
            this.btnEliminarVentaPro.Name = "btnEliminarVentaPro";
            this.btnEliminarVentaPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEliminarVentaPro.Size = new System.Drawing.Size(154, 51);
            this.btnEliminarVentaPro.TabIndex = 43;
            this.btnEliminarVentaPro.Text = "Eliminar";
            this.btnEliminarVentaPro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEliminarVentaPro.UseVisualStyleBackColor = false;
            this.btnEliminarVentaPro.Click += new System.EventHandler(this.btnEliminarVentaPro_Click);
            // 
            // btnguardarAsistencia
            // 
            this.btnguardarAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnguardarAsistencia.FlatAppearance.BorderSize = 0;
            this.btnguardarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnguardarAsistencia.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btnguardarAsistencia.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnguardarAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardarAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarAsistencia.Location = new System.Drawing.Point(60, 119);
            this.btnguardarAsistencia.Name = "btnguardarAsistencia";
            this.btnguardarAsistencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnguardarAsistencia.Size = new System.Drawing.Size(154, 51);
            this.btnguardarAsistencia.TabIndex = 42;
            this.btnguardarAsistencia.Text = "Marcar Asistencia";
            this.btnguardarAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnguardarAsistencia.UseVisualStyleBackColor = false;
            this.btnguardarAsistencia.Click += new System.EventHandler(this.btnguardarAsistencia_Click);
            // 
            // txtIdAsitencias
            // 
            this.txtIdAsitencias.Location = new System.Drawing.Point(60, 43);
            this.txtIdAsitencias.Name = "txtIdAsitencias";
            this.txtIdAsitencias.Size = new System.Drawing.Size(100, 20);
            this.txtIdAsitencias.TabIndex = 45;
            // 
            // lblIdAsistencias
            // 
            this.lblIdAsistencias.AutoSize = true;
            this.lblIdAsistencias.Location = new System.Drawing.Point(60, 24);
            this.lblIdAsistencias.Name = "lblIdAsistencias";
            this.lblIdAsistencias.Size = new System.Drawing.Size(106, 13);
            this.lblIdAsistencias.TabIndex = 46;
            this.lblIdAsistencias.Text = "Codigo de Asistencia";
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 705);
            this.Controls.Add(this.lblIdAsistencias);
            this.Controls.Add(this.txtIdAsitencias);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.btnEliminarVentaPro);
            this.Controls.Add(this.btnguardarAsistencia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cboTipoMembre);
            this.Controls.Add(this.txtNombreCli);
            this.Controls.Add(this.txtNdoc);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreCLi);
            this.Controls.Add(this.lblndoc);
            this.Name = "frmAsistencias";
            this.Text = "frmAsistencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblndoc;
        private System.Windows.Forms.Label lblNombreCLi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNdoc;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.ComboBox cboTipoMembre;
        private System.Windows.Forms.TextBox txtPrecio;
        private FontAwesome.Sharp.IconButton btnEliminarVentaPro;
        private FontAwesome.Sharp.IconButton btnguardarAsistencia;
        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.TextBox txtIdAsitencias;
        private System.Windows.Forms.Label lblIdAsistencias;
    }
}