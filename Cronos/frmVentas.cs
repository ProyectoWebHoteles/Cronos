using Cronos.Logica;
using Cronos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronos
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            mostrar_productos();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //Ocultar columnas
            ConfiguracionGriewView();
        }

        public void mostrar_productos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = InventarioLogica.Instancia.Listar().Where(x => x.StockActual>0).ToList();
            dgvVentas.DataSource = VentasLogica.Instancia.Listar();

            ConfiguracionGriewView();




    }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
            CultureInfo cultura = new CultureInfo("es-PE");

            string fechaTexto = row.Cells[10].Value.ToString();
            

            if (e.RowIndex >= 0)
            {
                // Aquí declaras la variable correctamente dentro del bloque

                int cantidad = 0;
                txIdProd.Text = row.Cells[0].Value?.ToString();
                txtProducto.Text = row.Cells[1].Value?.ToString();
                lblPrecio.Text = row.Cells[6].Value?.ToString();
                txtCodigoVenta.Text = "";

                if (txtCantidad.Text == "") {

                    txtCantidad.Text = "1";
                }
                else { 
                    
                     cantidad = int.Parse(txtCantidad.Text); }
               


                decimal precio = decimal.Parse(lblPrecio.Text);


                decimal resultado = cantidad * precio;

                txtPrecio.Text = resultado.ToString();

            }
        }

        private void btnEditarVentaProd_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCantidad.Text);
            decimal precio = decimal.Parse(lblPrecio.Text);


            decimal resultado = cantidad * precio;

            txtPrecio.Text = resultado.ToString();

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVenderPro_Click(object sender, EventArgs e)
        {
            bool isValid = true;


            if (txtCodigoVenta.Text =="" && txIdProd.Text!="") {

                DialogResult resultado = MessageBox.Show(
                "¿Está seguro que deseas realizar la venta ? ",
                "Confirmar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Código para eliminar el registro

                    if (isValid)
                    {
                        MessageBox.Show("Venta registrada correctamente");
                        Ventas objeto = new Ventas()
                        {
                            codProducto = txIdProd.Text,
                            NombreProducto = txtProducto.Text,
                            cliente = txtCliente.Text,
                            cantidad = Convert.ToInt32(txtCantidad.Text),
                            TotalVenta = decimal.Parse(txtPrecio.Text),
                            medioPago = cboTipoPago.Text





                        };
                        bool respuesta = VentasLogica.Instancia.Guardar(objeto);

                        if (respuesta)
                        {
                            limpiar();

                            mostrar_productos();

                            InitializeComponent();


                            //MessageBox.Show("Usuario" + usuario + "Correctamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                    }




                }
                else
                {
                    MessageBox.Show("Venta cancelada");
                }
            }
            else {

                MessageBox.Show("Id Existente, Seleccione una nueva venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            if (txtBuscarProd.Text == "")
            {
                limpiar();
                mostrar_productos();
                ConfiguracionGriewView();
            }
            else
            {
                StockProductos objeto = new StockProductos()
                {
                    NombreProducto = txtBuscarProd.Text,




                };

                if (dgvProductos.DataSource == null)
                {
                   limpiar();
                    mostrar_productos();
                    ConfiguracionGriewView();
                }
                else
                {
                    dgvProductos.DataSource = null;
                    dgvProductos.DataSource = InventarioLogica.Instancia.BuscarProd(objeto);
                   
                    ConfiguracionGriewView();

                }
            }
        }

        public void ConfiguracionGriewView()
        {

            dgvProductos.Columns["StockInicial"].Visible = false;
            dgvProductos.Columns["Entradas"].Visible = false;
            dgvProductos.Columns["Salidas"].Visible = false;
            dgvProductos.Columns["StockActual"].Visible = false;
            dgvProductos.Columns["Proveedor"].Visible = false;
            dgvProductos.Columns["Ubicacion"].Visible = false;
            dgvProductos.Columns["FechaActualizacion"].Visible = false;

            //tamaño de cabercera
            dgvProductos.Columns["IDProducto"].Width = 60;
            dgvProductos.Columns["Entradas"].Width = 50;
            dgvProductos.Columns["PrecioUnitario"].Width = 50;
            txtCantidad.Text = "1";
        }


        //ELIMINAR
        private void btnEliminarVentaPro_Click(object sender, EventArgs e)
        {


            if (txtCodigoVenta.Text != "")
            {
                Ventas objeto = new Ventas()
                {
                    IDVentas = int.Parse(txtCodigoVenta.Text),
                    NombreProducto= txtProducto.Text,
                    codProducto= txIdProd.Text,
                    cantidad= int.Parse(txtCantidad.Text)





                };

                DialogResult resultado = MessageBox.Show(
                  "¿Está seguro que deseas eliminar la venta " + int.Parse(txtCodigoVenta.Text) + ", " + txtProducto.Text + "? ",
                  "Confirmar Eliminación",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);



                if (resultado == DialogResult.Yes)
                {
                    // Código para eliminar el registro

                    bool respuesta = VentasLogica.Instancia.Eliminar(objeto);
                    MessageBox.Show("Registro eliminado correctamente");
                    if (respuesta)
                    {
                        limpiar();
                        mostrar_productos();

                    }
                }
                else
                {
                    MessageBox.Show("Eliminación cancelada");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta valida o existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void limpiar()
        {

            txtCantidad.Text = "";
            txtCliente.Text = "";
            lblPrecio.Text = "";
            txtPrecio.Text = "";
            txIdProd.Text = "";
            txtPrecio.Text = "";
            txtProducto.Text = "";
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();




            if (e.RowIndex >= 0 && e.RowIndex < dgvVentas.Rows.Count)
            {
                DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
                MessageBox.Show("Encabezado de fila clickeado: " + e.RowIndex);


                if (e.RowIndex >= 0)
                {
                    // Aquí declaras la variable correctamente dentro del bloque

               
                    txIdProd.Text = row.Cells[6].Value?.ToString();
                    txtProducto.Text = row.Cells[7].Value?.ToString();
                    txtPrecio.Text = row.Cells[5].Value?.ToString();
                    txtCantidad.Text = row.Cells[8].Value?.ToString();
                    txtCodigoVenta.Text = row.Cells[0].Value?.ToString();
                    txtCliente.Text = row.Cells[2].Value?.ToString();
                    cboTipoPago.Text = row.Cells[4].Value?.ToString();



                    //decimal precio = decimal.Parse(lblPrecio.Text);


                    //decimal resultado = cantidad * precio;

                    //txtPrecio.Text = resultado.ToString();

                }
            }

            //DataGridViewRow row = dgvVentas.Rows[e.RowIndex]
                    
                    
                    ;
        
         


            
        }
    }   }
    

