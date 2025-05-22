using Cronos.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronos.Logica
{
    public class VentasLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static VentasLogica _instanci = null;

        public VentasLogica()
        {

        }
        public static VentasLogica Instancia
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new VentasLogica();
                }

                return _instanci;
            }

        }
        //guardar
        public bool Guardar(Ventas obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"INSERT INTO t_ventas (
                                        fechaVenta,
                                        cliente,
                                        Vendedor,
                                        medioPago,
                                        TotalVenta,
                                        codProducto,
                                        NombreProducto,
                                        cantidad
                                    )
                                    VALUES (
                                        @fechaVenta,
                                        @cliente,
                                        @Vendedor,
                                        @medioPago,
                                        @TotalVenta,
                                        @codProducto,
                                        @NombreProducto,
                                        @cantidad
                                    );


                            UPDATE  t_ProductosStock SET  
                               
                                Salidas = Salidas+@cantidad
                               
                                
                            WHERE 
                                IDProducto = @codProducto;
                                

                        ";





                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@fechaVenta", DateTime.Now.ToString()));
                cmd.Parameters.Add(new SQLiteParameter("@cliente", obj.cliente));
                cmd.Parameters.Add(new SQLiteParameter("@Vendedor", obj.Vendedor));
                cmd.Parameters.Add(new SQLiteParameter("@medioPago", obj.medioPago));
                cmd.Parameters.Add(new SQLiteParameter("@TotalVenta", obj.TotalVenta));
                cmd.Parameters.Add(new SQLiteParameter("@codProducto", obj.codProducto));
                cmd.Parameters.Add(new SQLiteParameter("@NombreProducto", obj.NombreProducto));
                cmd.Parameters.Add(new SQLiteParameter("@cantidad", obj.cantidad));


                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        //LISTAR VENTAS
        public List<Ventas> Listar()
        {
            List<Ventas> oLista = new List<Ventas>();


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"  select IDVentas,
                                        fechaVenta,
                                        cliente,
                                        Vendedor,
                                        medioPago,
                                        TotalVenta,
                                        codProducto,
                                        NombreProducto,
                                        cantidad
                            from t_ventas
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Ventas()
                        {
                            IDVentas = int.Parse(dr["IDVentas"].ToString()),
                            codProducto = dr["codProducto"].ToString(),
                            NombreProducto = dr["NombreProducto"].ToString(),
                            cantidad = int.Parse(dr["cantidad"].ToString()),
                            medioPago = dr["medioPago"].ToString(),
                            TotalVenta = decimal.Parse(dr["TotalVenta"].ToString()),
                            cliente = dr["cliente"].ToString(),
                            fechaVenta = dr["fechaVenta"].ToString()


                        }); ;
                    }
                }
            }
            return oLista;
        }
        //ELIMINAR
        public bool Eliminar(Ventas obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"delete from  t_ventas  WHERE IDVentas = @IDVentas;

                            UPDATE t_ProductosStock SET Salidas = Salidas-@cantidad WHERE IDProducto = @codProducto;
                        
                    ";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@IDVentas", obj.IDVentas));
                cmd.Parameters.Add(new SQLiteParameter("@cantidad", obj.cantidad));
                cmd.Parameters.Add(new SQLiteParameter("@codProducto", obj.codProducto));

           
                


                cmd.CommandType = System.Data.CommandType.Text;
            
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
    }
}
