using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cronos.Modelo;
using Cronos.Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Media;
using System.Globalization;
using System.Threading;

namespace Cronos
{
    public partial class formCliente : Form
    {

        private ToolTip toolTip = new ToolTip();
        private string usuario;
        public formCliente(string usuarioLogueado)
        {
            InitializeComponent();
            usuario = usuarioLogueado;
            lblEmpleado.Text = "Bienvenido, " + usuario;
            MessageTooltips();
            ControlsDefaultsFrm();
        }


      


        private void lblformCliente_Load(object sender, EventArgs e)
        {
            mostrar_cliente();
            ControlsDefaultsFrm();
        }



        //seleccion DataGriew
        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
            CultureInfo cultura = new CultureInfo("es-PE");
            
            string fechaTexto = row.Cells[10].Value.ToString();
              //id = int.Parse(dr["id"].ToString()),
            //                1 ndoc = int.Parse(dr["ndoc"].ToString()),
            //                2 Nombres = dr["Nombres"].ToString(),
            //                3 Apellidos = dr["Apellidos"].ToString(),
            //                4 tipoMembresia = dr["tipoMembresia"].ToString(),
            //                5 EstadoMembresia = dr["EstadoMembria"].ToString(),
            //                6Telefono = int.Parse(dr["Telefono"].ToString()),
            //                7 Direccion = dr["Direccion"].ToString(),
            //                8 email = dr["email"].ToString(),
            //                9 genero = dr["genero"].ToString(),
            //                10 FechaNac = dr["FechaNac"].ToString(),
            //                11 fechaInicio = dr["fechaInicio"].ToString(),
            //                12 tipodoc = dr["tipodoc"].ToString(),
            //                13fechaVencimiento = dr["fechaVencimiento"].ToString(),
            //                14 EmpleadoRegistro = dr["EmpleadoRegistro"].ToString(),
            //                15 FechaRegistro = dr["FechaRegistro"].ToString()

            if (e.RowIndex >= 0)
            {
                // Aquí declaras la variable correctamente dentro del bloque
                
               
                txtdni.Text = row.Cells[1].Value?.ToString();
                txtnombres.Text = row.Cells[2].Value?.ToString();
                txtapellidos.Text = row.Cells[3].Value?.ToString();
                cboTipoMembresia.Text = row.Cells[4].Value?.ToString();
                txttelefono.Text = row.Cells[6].Value?.ToString();
                txtDireccion.Text = row.Cells[7].Value?.ToString();
                txtcorreo.Text = row.Cells[8].Value?.ToString();
                cboGenero.Text = row.Cells[5].Value?.ToString();
                dtpFechaNaci.Text = row.Cells[9].Value?.ToString();
                cboEstado.Text = row.Cells[10].Value?.ToString();

                //  dtpFechaNaci.Text =  DateTime.Parse(row.Cells[10].Value?.ToString());
                dtpFechaIni.Text= row.Cells[11].Value?.ToString();
                dtpFechaVenc.Text= row.Cells[12].Value?.ToString();
                CboTipoDoc.Text = row.Cells[13].Value?.ToString();
                // txtCategoria.Text = row.Cells[4].Value?.ToString();


            }
        }

        
        //GUARDAR
        private void btnGuardarCli_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string error = "";

            if (CboTipoDoc.Text=="DNI" && txtdni.Text.Length != 8 || !txtdni.Text.All(char.IsDigit))
            {
                error = "Debe ingresar un DNI válido de 8 dígitos.";
                lblErrorDni.Text = error;
                lblErrorDni.ForeColor = System.Drawing.Color.Red;
                 isValid = false;
                
               
            } else
            {
                if (CboTipoDoc.Text == "CE" && txtdni.Text.Length != 9 || !txtdni.Text.All(char.IsDigit))
                {
                    error = "Debe ingresar CE válido de 9 dígitos.";
                    lblErrorDni.Text = error;
                    lblErrorDni.ForeColor = System.Drawing.Color.Red;
                    isValid = false;


                }
                else
                {
                    lblErrorDni.Text = "";
                }
            }

            



            if (isValid)
            {
                string fechaVencFormateada = dtpFechaVenc.Value.ToString("dd/MM/yyyy");
                string fechaInicoFormateada = dtpFechaIni.Value.ToString("dd/MM/yyyy");
                string fechanacFormateada = dtpFechaIni.Value.ToString("dd/MM/yyyy");
                
                int meses = 1;

                DateTime fechaRegistro = dtpFechaIni.Value.Date;



                //DateTime fechaExpiracion = CalcularFechaExpiracion(fechaRegistro, meses, feriados);

                Cliente objeto = new Cliente()
                {


                    ndoc = txtdni.Text,
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    tipodoc = CboTipoDoc.Text,
                    tipoMembresia = cboTipoMembresia.Text,
                    genero = cboGenero.Text,
                    fechaInicio = fechaInicoFormateada,
                    fechaVencimiento = fechaVencFormateada,
                    FechaNac = fechanacFormateada,
                    EstadoMembresia = cboEstado.Text,
                    Telefono = txttelefono.Text,
                    Direccion = txtDireccion.Text,
                    email = txtcorreo.Text,
                    EmpleadoRegistro = lblEmpleado.Text





                };
                bool respuesta = ClienteLogica.Instancia.Guardar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_cliente();
                    ControlsDefaultsFrm();
                    MessageBox.Show("Usuario" + usuario + "Correctamente", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else {
                    MessageBox.Show("Error de Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                ControlsDefaultsFrm();
                lblErrorDni.Text = error;
                lblErrorDni.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Verifique los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //EDITAR
        private void btnEditarCli_Click(object sender, EventArgs e)
        {
           
          
               
                string fechaVencFormateada = dtpFechaVenc.Value.ToString("dd/MM/yyyy");
                string fechaInicoFormateada = dtpFechaIni.Value.ToString("dd/MM/yyyy");
                string fechanacFormateada = dtpFechaIni.Value.ToString("dd/MM/yyyy");
                Cliente objeto = new Cliente()
                {
                    ndoc = txtdni.Text,
                    Nombres = txtnombres.Text,
                    Apellidos = txtapellidos.Text,
                    tipodoc = CboTipoDoc.Text,
                    tipoMembresia = cboTipoMembresia.Text,
                    genero = cboGenero.Text,
                    fechaInicio = fechaInicoFormateada,
                    fechaVencimiento = fechaVencFormateada,
                    FechaNac = fechanacFormateada,
                    EstadoMembresia = cboEstado.Text,
                    Telefono = txttelefono.Text,
                    Direccion = txtDireccion.Text,
                    email = txtcorreo.Text,
                    EmpleadoRegistro = lblEmpleado.Text




                };
                bool respuesta = ClienteLogica.Instancia.Editar(objeto);

                if (respuesta)
                {
                    limpiar();
                    mostrar_cliente();
                }
                lblErrorDni.Text = "";
            
            


        }


        //ELIMINAR
        private void btnEliminarCli_Click(object sender, EventArgs e)
        {

            if (txtdni.Text != "") { 

            Cliente objeto = new Cliente()
            {
                ndoc = txtdni.Text
                ,Nombres=txtnombres.Text
                                                       
            };


            DialogResult resultado = MessageBox.Show(
                 "¿Está seguro que deseas eliminar  al cliente " + txtdni.Text +", " + txtnombres.Text + "? ",
                 "Confirmar Eliminación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning);


            if (resultado == DialogResult.Yes)
            {
                // Código para eliminar el registro

                bool respuesta = ClienteLogica.Instancia.Eliminar(objeto);
                MessageBox.Show("Registro eliminado correctamente");
                if (respuesta)
                {
                    limpiar();
                    mostrar_cliente();

                }
            }
            else {
                MessageBox.Show("Eliminación cancelada");
            }

            }
            else
            {
                MessageBox.Show("Seleccione un DNI Valido", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }
        //BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtdni.Text == "") {
                limpiar();
                mostrar_cliente();
            }
            else { 
            Cliente objeto = new Cliente()
            {
                ndoc = txtdni.Text,
                



            };

                if (dgvCliente.DataSource == null) {
                    limpiar();
                    mostrar_cliente();
                }
                else { 
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = ClienteLogica.Instancia.Buscar(objeto);

                }
            }
        }
        //Validar DNI
        private void txtdni_Leave(object sender, EventArgs e)
        {
            if (CboTipoDoc.Text == "DNI") { 

                if (txtdni.Text.Length != 8 || !txtdni.Text.All(char.IsDigit))
                {
                    lblErrorDni.Text = "Debe ingresar un DNI válido de 8 dígitos.";
                    lblErrorDni.ForeColor=System.Drawing.Color.Red;
                }
                else
                {
                    lblErrorDni.Text = "";
                }

            }
            else
            {


                if (txtdni.Text.Length != 9 || !txtdni.Text.All(char.IsDigit))
                {
                    lblErrorDni.Text = "Debe ingresar un CE de 9 dígitos.";
                    lblErrorDni.ForeColor = System.Drawing.Color.Red;
               
                }
                else
                {
                    lblErrorDni.Text = "";
                }

            }
        }

        

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite dígitos y control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela la tecla
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // cancela la tecla
            }
        }

       


        List<DateTime> feriados = new List<DateTime>
        {
            // Año 2025
            new DateTime(2025, 1, 1),    // Miércoles - Año Nuevo
            new DateTime(2025, 4, 17),   // Jueves - Jueves Santo
            new DateTime(2025, 4, 18),   // Viernes - Viernes Santo
            new DateTime(2025, 4, 20),   // Domingo - Domingo de Resurrección (no laborable igual)
            new DateTime(2025, 5, 1),    // Jueves - Día del Trabajo
            new DateTime(2025, 6, 7),    // Sábado - Batalla de Arica / Día de la Bandera
            new DateTime(2025, 6, 29),   // Domingo - San Pedro y San Pablo
            new DateTime(2025, 7, 23),   // Miércoles - Día de la Fuerza Aérea del Perú
            new DateTime(2025, 7, 28),   // Lunes - Independencia del Perú
            new DateTime(2025, 7, 29),   // Martes - Celebración por Independencia
            new DateTime(2025, 8, 6),    // Miércoles - Batalla de Junín
            new DateTime(2025, 8, 30),   // Sábado - Santa Rosa de Lima
            new DateTime(2025, 10, 8),   // Miércoles - Combate de Angamos
            new DateTime(2025, 11, 1),   // Sábado - Día de Todos los Santos
            new DateTime(2025, 12, 8),   // Lunes - Inmaculada Concepción
            new DateTime(2025, 12, 9),   // Martes - Batalla de Ayacucho
            new DateTime(2025, 12, 25),  // Jueves - Navidad

            // Año 2026
            new DateTime(2026, 1, 1),    // Jueves - Año Nuevo
            new DateTime(2026, 4, 2),    // Jueves - Jueves Santo
            new DateTime(2026, 4, 3),    // Viernes - Viernes Santo
            new DateTime(2026, 4, 5),    // Domingo - Domingo de Resurrección
            new DateTime(2026, 5, 1),    // Viernes - Día del Trabajo
            new DateTime(2026, 6, 7),    // Domingo - Batalla de Arica / Día de la Bandera
            new DateTime(2026, 6, 29),   // Lunes - San Pedro y San Pablo
            new DateTime(2026, 7, 23),   // Jueves - Día de la Fuerza Aérea del Perú
            new DateTime(2026, 7, 28),   // Martes - Independencia del Perú
            new DateTime(2026, 7, 29),   // Miércoles - Celebración por Independencia
            new DateTime(2026, 8, 6),    // Jueves - Batalla de Junín
            new DateTime(2026, 8, 30),   // Domingo - Santa Rosa de Lima
            new DateTime(2026, 10, 8),   // Jueves - Combate de Angamos
            new DateTime(2026, 11, 1),   // Domingo - Día de Todos los Santos
            new DateTime(2026, 12, 8),   // Martes - Inmaculada Concepción
            new DateTime(2026, 12, 25),  // Viernes - Navidad
        };

        #region "Otras Funciones"

        DateTime CalcularFechaExpiracion(DateTime fechaInicio, int meses, List<DateTime> feriados, int daysExtra)
        {
            // Calcular fecha futura considerando meses calendario
            DateTime fechaFutura = fechaInicio.AddMonths(meses);
            fechaFutura = fechaFutura.AddDays(daysExtra);
            // Contar días hábiles entre inicio y fecha futura
            int diasHabiles = 0;
            for (DateTime dia = fechaInicio; dia < fechaFutura; dia = dia.AddDays(1))
            {

                if (
                    //dia.DayOfWeek != DayOfWeek.Saturday &&
                    //dia.DayOfWeek != DayOfWeek.Sunday &&
                    !feriados.Contains(dia.Date))
                {
                    diasHabiles++;
                }
            }

            // Avanzar esa misma cantidad de días hábiles desde la fecha de inicio
            DateTime fechaExpiracion = fechaInicio;
            int acumulado = 0;
            while (acumulado < diasHabiles)
            {
                fechaExpiracion = fechaExpiracion.AddDays(1);
                if (
                //fechaExpiracion.DayOfWeek != DayOfWeek.Saturday &&
                //    fechaExpiracion.DayOfWeek != DayOfWeek.Sunday &&
                    !feriados.Contains(fechaExpiracion.Date))
                {
                    acumulado++;
                }
            }

            return fechaExpiracion;
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            int meses = int.Parse(txtMeses.Text);
            int dias = int.Parse(txtDia.Text);
            DateTime fechaRegistro = dtpFechaIni.Value.Date;
            DateTime fechaExpiracion = CalcularFechaExpiracion(fechaRegistro, meses, feriados, dias);
            dtpFechaVenc.Value = CalcularFechaExpiracion(fechaRegistro, meses, feriados, dias);

            //ControlsDefaultsFrm();
        }
        public void mostrar_cliente()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = ClienteLogica.Instancia.Listar();
        }

        public void limpiar()
        {

            txtdni.Text = "";
            txtnombres.Text = "";

            txttelefono.Text = "";
            txtDireccion.Text = "";
            txtcorreo.Text = "";


        }

        public void ControlsDefaultsFrm()
        {
            cboEstado.Text = "Activo";
            cboTipoDePago.Text = "Efectivo";
            CboTipoDoc.Text = "DNI";
            cboEstado.Text = "Activo";
            cboGenero.Text = "Masculino";
            cboTipoMembresia.Text = "Socio Normal";
            txtDia.Text = "0";
            txtMeses.Text = "0";

            if (CheckEditar.Checked == true)

            {
                dtpFechaVenc.Enabled = true;

                lblHabilitado.Text = "Habilitado";

                lblHabilitado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                dtpFechaVenc.Enabled = false;
                lblHabilitado.Text = "Desabilitado";

                lblHabilitado.ForeColor = System.Drawing.Color.Red;
            }

        }

        public void MessageTooltips()
        {


            toolTip.SetToolTip(lbldni, "Ingrese su número de DNI o documento de identidad sin espacios, guiones o puntos. Ejemplo: 87654321");
            toolTip.SetToolTip(lblMonto, "Ingrese el valor numérico sin símbolos de moneda. Use punto para decimales. Ejemplo: 150.50");
            toolTip.SetToolTip(lblDias, "Ingrese un número entero. Ejemplo: 30");
            toolTip.SetToolTip(lblMeses, "Ingrese un número entero. Ejemplo: 12");
            toolTip.SetToolTip(lbltelefono, "Ingrese su número de celular o telefono sin espacios, guiones o puntos. Ejemplo: 9361684123");
        }



        #endregion


        //Funciones de Controles sin definir o vacios--No borrarlos por que se malogra el diseño o el proyecto
        private void btnGuardarCli_Leave(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CheckEditar_MouseClick(object sender, MouseEventArgs e)
        {
          


        }

        private void CheckEditar_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckEditar.Checked == true)

            {
                dtpFechaVenc.Enabled = true;

                lblHabilitado.Text = "Habilitado";

                lblHabilitado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                dtpFechaVenc.Enabled = false;
                lblHabilitado.Text = "Desabilitado";

                lblHabilitado.ForeColor = System.Drawing.Color.Red;
            }
        }


   


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckEditar_Leave(object sender, EventArgs e)
        {
           
        }

        private void lbltelefono_Click(object sender, EventArgs e)
        {

        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }

        private void txtnombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombres_Click(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

