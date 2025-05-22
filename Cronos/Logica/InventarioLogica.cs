using Cronos.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Cronos.Logica
{
    public class InventarioLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static InventarioLogica _instanci = null;
        public static InventarioLogica Instancia
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new InventarioLogica();
                }

                return _instanci;
            }

        }

        //LISTAR
        public List<StockProductos> Listar()
        {
            List<StockProductos> oLista = new List<StockProductos>();


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"Select IDProducto,NombreProducto,Categoria,StockInicial,Entradas,
                               Salidas, Entradas-Salidas as StockActual,PrecioUnitario,Ubicacion,Proveedor,FechaActualizacion
        FROM t_ProductosStock
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new StockProductos()
                        {
                            IDProducto = dr["IDProducto"].ToString(),
                            NombreProducto = dr["NombreProducto"].ToString(),
                            Categoria = dr["Categoria"].ToString(),
                            StockInicial = Convert.ToInt32(dr["StockInicial"].ToString()),
                            Entradas = Convert.ToInt32(dr["Entradas"].ToString()),
                            Salidas = Convert.ToInt32(dr["Salidas"].ToString()),
                            StockActual = Convert.ToInt32(dr["StockActual"].ToString()),
                            PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"].ToString()),
                            Proveedor = dr["Proveedor"].ToString(),
                            
                            FechaActualizacion = dr["FechaActualizacion"].ToString(),

                           
                        });
                    }
                }
            }
            return oLista;
        }
       

        public string GenerarIDProducto()
        {
            string nuevoID = "PRD001";
            bool respuesta = true;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                string query = "SELECT IDProducto FROM t_ProductosStock ORDER BY IDProducto DESC LIMIT 1";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object ultimoID = cmd.ExecuteScalar();

                    if (ultimoID != null && ultimoID.ToString().StartsWith("PRD"))
                    {
                        int numero = int.Parse(ultimoID.ToString().Substring(3));
                        numero += 1;
                        nuevoID = "PRD" + numero.ToString("D3");
                    }

                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }

                conn.Close();
            }

            return nuevoID;
        }

        public bool Guardar_producto(StockProductos obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"insert INTO t_ProductosStock (IDProducto,NombreProducto,Categoria,StockInicial,Entradas,
                                Salidas,PrecioUnitario,Ubicacion,Proveedor,FechaActualizacion) 
                                VALUES (@IDProducto,@NombreProducto,@Categoria, @StockInicial,@Entradas,@Salidas,@PrecioUnitario,@Ubicacion, @Proveedor,@FechaActualizacion);";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDProducto", obj.IDProducto));
                cmd.Parameters.Add(new SQLiteParameter("@NombreProducto", obj.NombreProducto));
                cmd.Parameters.Add(new SQLiteParameter("@Categoria", obj.Categoria));
                cmd.Parameters.Add(new SQLiteParameter("@StockInicial", obj.StockInicial));
                cmd.Parameters.Add(new SQLiteParameter("@Entradas", obj.Entradas));
                cmd.Parameters.Add(new SQLiteParameter("@Salidas", obj.Salidas));
                cmd.Parameters.Add(new SQLiteParameter("@PrecioUnitario", obj.PrecioUnitario));
                cmd.Parameters.Add(new SQLiteParameter("@Ubicacion", obj.Ubicacion));
                cmd.Parameters.Add(new SQLiteParameter("@Proveedor", obj.Proveedor));
                cmd.Parameters.Add(new SQLiteParameter("@FechaActualizacion", DateTime.Now.ToString()));


                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public bool Eliminar(StockProductos obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from  t_ProductosStock  WHERE IDProducto = @IDProducto;";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@IDProducto", obj.IDProducto));


                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Editar(StockProductos obj)
        {
            bool respuesta = true;
            //Apellidos = @Apellidos, tipoMembresia = @tipoMembresia,
            //        Telefono = @Telefono, Direccion = @Direccion, email = @email, genero = @genero,
            //        EstadoMembria = @EstadoMembria, fechaInicio = @fechaInicio, fechaVencimiento = @fechaVencimiento,
            //        tipodoc = @Tipodoc, FechaNac = @FechaNac,EmpleadoRegistro = @EmpleadoRegistro, FechaRegistro = datetime('now')



            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"UPDATE  t_ProductosStock SET  
                                NombreProducto = @NombreProducto,
                                Categoria = @Categoria,
                                StockInicial = @StockInicial,
                                Entradas = @Entradas,
                                
                                PrecioUnitario = @PrecioUnitario,
                                Ubicacion = @Ubicacion,
                                Proveedor = @Proveedor,
                                FechaActualizacion = @FechaActualizacion
                            WHERE 
                                IDProducto = @IDProducto;";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@IDProducto", obj.IDProducto));
                cmd.Parameters.Add(new SQLiteParameter("@NombreProducto", obj.NombreProducto));
                cmd.Parameters.Add(new SQLiteParameter("@Categoria", obj.Categoria));
                cmd.Parameters.Add(new SQLiteParameter("@StockInicial", obj.StockInicial));
                cmd.Parameters.Add(new SQLiteParameter("@Entradas", obj.Entradas));
               
                cmd.Parameters.Add(new SQLiteParameter("@PrecioUnitario", obj.PrecioUnitario));
                cmd.Parameters.Add(new SQLiteParameter("@Ubicacion", obj.Ubicacion));
                cmd.Parameters.Add(new SQLiteParameter("@Proveedor", obj.Proveedor));
                cmd.Parameters.Add(new SQLiteParameter("@FechaActualizacion", DateTime.Now.ToString()));

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }



        public List<StockProductos> BuscarProd(StockProductos obj)
        {
            List<StockProductos> oLista = new List<StockProductos>();



            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"Select IDProducto,NombreProducto,Categoria,StockInicial,Entradas,
                               Salidas, Entradas-Salidas as StockActual,PrecioUnitario,Ubicacion,Proveedor,FechaActualizacion
                                 FROM t_ProductosStock where NombreProducto like @NombreProducto;";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new SQLiteParameter("@NombreProducto", $"{obj.NombreProducto}%" ));

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new StockProductos()
                        {
                            IDProducto = dr["IDProducto"].ToString(),
                            NombreProducto = dr["NombreProducto"].ToString(),
                            Categoria = dr["Categoria"].ToString(),
                            StockInicial = Convert.ToInt32(dr["StockInicial"].ToString()),
                            Entradas = Convert.ToInt32(dr["Entradas"].ToString()),
                            Salidas = Convert.ToInt32(dr["Salidas"].ToString()),
                            StockActual = Convert.ToInt32(dr["StockActual"].ToString()),
                            PrecioUnitario = Convert.ToDecimal(dr["PrecioUnitario"].ToString()),
                            Proveedor = dr["Proveedor"].ToString(),

                            FechaActualizacion = dr["FechaActualizacion"].ToString(),

                        });
                    }
                }
            }
            return oLista;
        }
    }
}
