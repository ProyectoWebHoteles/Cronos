using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronos.Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public string ndoc { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string tipoMembresia { get; set; }
        public string genero { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string email { get; set; }
        public string FechaNac { get; set; }

        public string EstadoMembresia { get; set; }
        public string fechaInicio { get; set; }
        public string fechaVencimiento { get; set; }
        public string tipodoc { get; set; }

        public string EmpleadoRegistro { get; set; }

        public string FechaRegistro { get; set; }

        public string dias { get; set; }

        public string Alerta { get; set; }

        public string TipodePago { get; set; }

        public decimal Monto { get; set; }


    }


    public class StockProductos
    {
        public string IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public int StockInicial { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int StockActual { get; set; }
        public string Proveedor { get; set; }
        public string Ubicacion { get; set; }
        public string FechaActualizacion { get; set; }

       


    }

    public class Ventas
    {
        public int IDVentas { get; set; }
        public string fechaVenta { get; set; }
        public string cliente { get; set; }
        public string Vendedor { get; set; }
        public string medioPago { get; set; }
        public decimal TotalVenta { get; set; }
        public string codProducto { get; set; }
        public string NombreProducto { get; set; }

        public int cantidad { get; set; }
    }


    public class Asistencia
    {
        public int idAsistencias { set; get;}

        public string ndoc { set; get; }

        public string nombreCliente { set; get; }

        public string fechaEntrada { set; get; }

        public string fechaSalida { set; get; }

        public string tipoMembresia { set; get; }

        public decimal precio { set; get; }
    }

    }
