using Cronos.Logica;
using Cronos.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cronos
{
    public partial class frmcharts : Form
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static ClienteLogica _instanci = null;
        public class Usuario
        {
            public string Nombre { get; set; }
            public string TipoMembresia { get; set; }
        }


        List<Usuario> usuarios = new List<Usuario>
{


    new Usuario { Nombre = "Ana", TipoMembresia = "Gold" },
    new Usuario { Nombre = "Luis", TipoMembresia = "Silver" },
    new Usuario { Nombre = "Marta", TipoMembresia = "Gold" },
    new Usuario { Nombre = "Juan", TipoMembresia = "Bronze" },
    new Usuario { Nombre = "Pedro", TipoMembresia = "Silver" }




    };


        public frmcharts()
        {
            InitializeComponent();

            chart1.Series.Clear();
            chart1.Series.Add("genero");
            chart1.Series["genero"].ChartType = SeriesChartType.Column;

            var resultado = ClienteLogica.Instancia.Listar()
                .GroupBy(u => u.genero)
                .Select(g => new { genero = g.Key, Cantidad = g.Count() });

            foreach (var item in resultado)
            {
                chart1.Series["genero"].Points.AddXY(item.genero, item.Cantidad);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            mostrar_cliente();

            dgvMembresiaProxAven.Columns["Direccion"].Visible = false;
            dgvMembresiaProxAven.Columns["Telefono"].Visible = false;
            dgvMembresiaProxAven.Columns["genero"].Visible = false;
            dgvMembresiaProxAven.Columns["email"].Visible = false;
            dgvMembresiaProxAven.Columns["FechaNac"].Visible = false;
            dgvMembresiaProxAven.Columns["TipoDoc"].Visible = false;
            dgvMembresiaProxAven.Columns["EmpleadoRegistro"].Visible = false;
            dgvMembresiaProxAven.ReadOnly = false;


            //Cambiar cabecera
            dgvMembresiaProxAven.Columns["tipoMembresia"].HeaderText = "Tipo de Membresia";
            dgvMembresiaProxAven.Columns["ndoc"].HeaderText = "N° Documento";
            dgvMembresiaProxAven.Columns["EstadoMembresia"].HeaderText = "Estado de Membresia";
            dgvMembresiaProxAven.Columns["fechaVencimiento"].HeaderText = "Fecha de Vencimiento";
            dgvMembresiaProxAven.Columns["fechaInicio"].HeaderText = "Fecha de Inicio";
            dgvMembresiaProxAven.Columns["dias"].HeaderText = "Dias";
            //tamaño de cabercera
            dgvMembresiaProxAven.Columns["dias"].Width =35;
        }

        public void mostrar_cliente()
        {
            dgvMembresiaProxAven.DataSource = null;
            dgvMembresiaProxAven.DataSource = ClienteLogica.Instancia.ListarProximosAvencer().Where(x => x.Alerta == "Membresia Vencida" || x.Alerta == "Por Vencer").ToList();

        }

        private void dgvMembresiaProxAven_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembresiaProxAven.Columns[e.ColumnIndex].Name == "Alerta")
            {
                var celda = dgvMembresiaProxAven.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string valor = celda.Value?.ToString() ?? string.Empty;

                if (valor.Contains("Membresia Vencida") || valor.Contains("Vencido"))
                {
                    celda.Style.BackColor = Color.LightCoral;
                    celda.Style.ForeColor = Color.DarkRed;
                }
            }
        }
    }
}