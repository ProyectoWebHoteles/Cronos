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
using static Cronos.frmcharts;

namespace Cronos
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
            string id = InventarioLogica.Instancia.GenerarIDProducto();
            txtIdProd.Text = id;
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            string id = InventarioLogica.Instancia.GenerarIDProducto();
            txtIdProd.Text = id;
            mostrar_productos();
        }

        public void mostrar_productos()
        {
            dgvProducto.DataSource = null;
            dgvProducto.DataSource = InventarioLogica.Instancia.Listar();

        }
        //GUARDAR
        private void btnGuardarPro_Click(object sender, EventArgs e)
        {
            bool isValid = true;


            if (txtNombreProd.Text != "")
            {




                DialogResult resultado = MessageBox.Show(
                "¿Está seguro que deseas realizar la venta ? ",
                "Confirmar venta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {

                    if (isValid)
                    {
                        StockProductos objeto = new StockProductos()
                        {
                            IDProducto = txtIdProd.Text,
                            NombreProducto = txtNombreProd.Text,
                            Categoria = cboCategoria.Text,
                            StockInicial = Convert.ToInt32(txtStockInicial.Text),
                            Entradas = Convert.ToInt32(txtEntrada.Text),
                            PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text),
                            Proveedor = txtProveedor.Text

                        };

                        bool respuesta = InventarioLogica.Instancia.Guardar_producto(objeto);
                        MessageBox.Show("Producto resgistrado correctamente");
                        if (respuesta)
                        {
                            //limpiar();

                            mostrar_productos();

                            InitializeComponent();


                            //MessageBox.Show("Usuario" + usuario + "Correctamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                        else
                        {
                            MessageBox.Show("Error de Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {

                        MessageBox.Show("Regisro Cancelado");
                    }

                }
                else
                {
                    MessageBox.Show("Regisro Cancelado"); 
                    
                 

                }

            }
            else{
                MessageBox.Show("Registe un nombre de producto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }



          
                //    lblErrorDni.Text = error;
         

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            if (txtNombreProd.Text == "")
            {
                limpiar();
                mostrar_productos();
                //ConfiguracionGriewView();
            }
            else
            {
                StockProductos objeto = new StockProductos()
                {
                    NombreProducto = txtNombreProd.Text,




                };

                if (dgvProducto.DataSource == null)
                {
                    limpiar();
                    mostrar_productos();
                    //ConfiguracionGriewView();
                }
                else
                {
                    dgvProducto.DataSource = null;
                    dgvProducto.DataSource = InventarioLogica.Instancia.BuscarProd(objeto);
                   
                    //ConfiguracionGriewView();

                }
            }
        }
        //EDITAR
        private void btnEditarProd_Click(object sender, EventArgs e)
        {

            StockProductos objeto = new StockProductos()
            {
                IDProducto = txtIdProd.Text,
                NombreProducto = txtNombreProd.Text,
                Categoria = cboCategoria.Text,
                StockInicial = Convert.ToInt32(txtStockInicial.Text),
                Entradas = Convert.ToInt32(txtEntrada.Text),
                PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text),
                Proveedor = txtProveedor.Text





            };
            bool respuesta = InventarioLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_productos();
            }
           // lblErrorDni.Text = "";


        }
        //ELIMINAR
        private void btnEliminarProd_Click(object sender, EventArgs e)
        {


            if(txtIdProd.Text!="" && txtNombreProd.Text != "") { 
            StockProductos objeto = new StockProductos()
            {
                IDProducto = txtIdProd.Text, NombreProducto=txtNombreProd.Text,





            };

            DialogResult resultado = MessageBox.Show(
              "¿Está seguro que deseas eliminar  el Producto " + txtIdProd.Text + ", " + txtNombreProd.Text+ "? ",
              "Confirmar Eliminación",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);



            if (resultado == DialogResult.Yes)
            {
                // Código para eliminar el registro

                bool respuesta = InventarioLogica.Instancia.Eliminar(objeto);
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
                MessageBox.Show("Seleccione un Producto valido o existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }
     
        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvProducto.Rows[e.RowIndex];
        
            DateTime fechaConvertida;
         
           


            if (e.RowIndex >= 0)
            {
                // Aquí declaras la variable correctamente dentro del bloque


                txtIdProd.Text = row.Cells[0].Value?.ToString();
                txtNombreProd.Text = row.Cells[1].Value?.ToString();
                cboCategoria.Text = row.Cells[2].Value?.ToString();
                txtStockInicial.Text = row.Cells[3].Value?.ToString();
                txtEntrada.Text = row.Cells[4].Value?.ToString();
                txtPrecioUnitario.Text = row.Cells[6].Value?.ToString();
                txtProveedor.Text = row.Cells[8].Value?.ToString();



            }
        }

        private void lblPrecioUnitario_Click(object sender, EventArgs e)
        {




        }


        #region "OTROS METODOS"

        public void limpiar()
        {


            txtNombreProd.Text = "";

            cboCategoria.Text = "";
            lblStockInicial.Text = "";
            txtEntrada.Text = "";
            txtProveedor.Text = "";
            txtPrecioUnitario.Text = "";
        }

        #endregion

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
