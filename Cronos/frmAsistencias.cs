using Cronos.Logica;
using Cronos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronos
{
    public partial class frmAsistencias : Form
    {

        bool cliente = false;
        public frmAsistencias()
        {
            InitializeComponent();
            if (cboTipoMembre.Text == "Sin Membresia")
            {

                txtPrecio.Enabled = true;

            }
            btnguardarAsistencia.Enabled = false;
            mostrar_productos();

        }

        private void txtNdoc_Leave(object sender, EventArgs e)
        {
            
        }

        private void cboTipoMembre_Leave(object sender, EventArgs e)
        {
            

        }

        private void txtNdoc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNdoc_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) // Verifica si se presionó Enter
            {

                if (txtNdoc.Text == "")
                {
                    //limpiar();
                    //mostrar_productos();
                    //ConfiguracionGriewView();
                }
                else
                {
                    Cliente objeto = new Cliente()
                    {
                        ndoc = txtNdoc.Text,




                    };


                    List<Cliente> oLista = AsistenciasLogica.Instancia.BuscarDoc(objeto);

                    if (oLista.Count != 0)
                    {
                        txtNombreCli.Text = oLista.Select(x => x.Nombres).FirstOrDefault();
                        cboTipoMembre.Text = oLista.Select(x => x.tipoMembresia).FirstOrDefault();
                        
                        if (cboTipoMembre.Text == "Sin Membresia")
                        {

                            txtPrecio.Enabled = true;
                            txtPrecio.Text = "";
                        }
                        else
                        {
                            txtPrecio.Enabled = false;
                            txtPrecio.Text = "0.0";
                        }
                        btnguardarAsistencia.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    //if (dgvProductos.DataSource == null)
                    //{
                    //    //limpiar();
                    //    //mostrar_productos();
                    //    //ConfiguracionGriewView();
                    //}
                    //else
                    //{
                    //    //dgvProductos.DataSource = null;
                    //    //dgvProductos.DataSource = InventarioLogica.Instancia.BuscarProd(objeto);

                    //    //ConfiguracionGriewView();

                    //}
                }
            }
        }

        private void cboTipoMembre_KeyUp(object sender, KeyEventArgs e)
        {
           if( cboTipoMembre.Text=="Sin Membresia")
            {

                txtPrecio.Enabled = true;
            }


           
        }

        private void btnguardarAsistencia_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            btnguardarAsistencia.Enabled = false;
            Cliente objetoCod = new Cliente()
            {
                ndoc = txtNdoc.Text,




            };

            List<Cliente> oLista = AsistenciasLogica.Instancia.BuscarDoc(objetoCod);

            if (oLista.Count != 0)
            { if (txtNdoc.Text != "" & txtNombreCli.Text != "")
                {

                    DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que deseas registrar la asistencia ? ",
                    "Confirmar Asistencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        // Código para eliminar el registro

                        if (isValid)
                        {

                            Asistencia objeto = new Asistencia()
                            {
                                ndoc = txtNdoc.Text,
                                nombreCliente = txtNombreCli.Text,
                                tipoMembresia = cboTipoMembre.Text,
                                precio = decimal.Parse(txtPrecio.Text),
                                fechaEntrada = DateTime.Now.ToString()





                            };

                            MessageBox.Show("Asistencia registrada correctamente");
                            bool respuesta = AsistenciasLogica.Instancia.Guardar(objeto);

                            if (respuesta)
                            {
                                //limpiar();

                                mostrar_productos();

                                //InitializeComponent();


                                //MessageBox.Show("Usuario" + usuario + "Correctamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.None);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Venta cancelada");
                    }
                }
                else
                {

                    MessageBox.Show("Ingrese un N° de documento valido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void mostrar_productos()
        {
            dgvAsistencia.DataSource = null;
            dgvAsistencia.DataSource = AsistenciasLogica.Instancia.Listar();
            
               //ConfiguracionGriewView();




        }

        private void btnEliminarVentaPro_Click(object sender, EventArgs e)
        {

            if (txtIdAsitencias.Text != "")
            {
                Asistencia objeto = new Asistencia()
                {
                    idAsistencias = int.Parse(txtIdAsitencias.Text),
                    nombreCliente = txtNombreCli.Text,





                };

                DialogResult resultado = MessageBox.Show(
                  "¿Está seguro que deseas eliminar  esta asistencia " + int.Parse(txtIdAsitencias.Text) + ", " + txtNombreCli.Text + "? ",
                  "Confirmar Eliminación",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Warning);



                if (resultado == DialogResult.Yes)
                {
                    // Código para eliminar el registro

                    bool respuesta = AsistenciasLogica.Instancia.Eliminar(objeto);
                    MessageBox.Show("Registro eliminado correctamente");
                    if (respuesta)
                    {
                        //limpiar();
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
                MessageBox.Show("Seleccione un registro valido o existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dgvAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAsistencia.Rows[e.RowIndex];

            DateTime fechaConvertida;




            if (e.RowIndex >= 0)
            {
                // Aquí declaras la variable correctamente dentro del bloque


               txtIdAsitencias.Text = row.Cells[0].Value?.ToString();
                txtNdoc.Text = row.Cells[1].Value?.ToString();
                txtNombreCli.Text = row.Cells[2].Value?.ToString();
                cboTipoMembre.Text = row.Cells[5].Value?.ToString();
                txtPrecio.Text = row.Cells[6].Value?.ToString();
              



            }
        }
    }
    }

