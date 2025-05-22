using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Cronos.Modelo;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Diagnostics;


namespace Cronos.Logica
{
    public class ClienteLogica
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static ClienteLogica _instanci = null;

        public ClienteLogica()
        {

        }
        public static ClienteLogica Instancia {
            get {
                if (_instanci == null) {
                    _instanci = new ClienteLogica();
                }

                return _instanci;
            }

        }

        public bool Guardar(Cliente obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"INSERT INTO cliente (
                        ndoc, Nombres, Apellidos, tipoMembresia, Telefono, Direccion, email,
                        genero, EstadoMembria, fechaInicio, fechaVencimiento, tipodoc, FechaNac
                    , EmpleadoRegistro,FechaRegistro) VALUES (
                        @ndoc, @Nombres, @Apellidos, @tipoMembresia, @Telefono, @Direccion, @email,
                        @genero, @EstadoMembria, @fechaInicio, @fechaVencimiento, @tipodoc, @FechaNac
                    ,@EmpleadoRegistro,datetime('now'));";

                SQLiteCommand cmd = new SQLiteCommand(query,conexion);
               
                cmd.Parameters.Add(new SQLiteParameter("@ndoc", obj.ndoc));
                cmd.Parameters.Add(new SQLiteParameter("@Nombres", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@Apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@tipoMembresia", obj.tipoMembresia));
                cmd.Parameters.Add(new SQLiteParameter("@Telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@Direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@email", obj.email));
                cmd.Parameters.Add(new SQLiteParameter("@genero", obj.genero));
                cmd.Parameters.Add(new SQLiteParameter("@EstadoMembria", obj.EstadoMembresia));
                cmd.Parameters.Add(new SQLiteParameter("@fechaInicio", obj.fechaInicio));
                cmd.Parameters.Add(new SQLiteParameter("@fechaVencimiento", obj.fechaVencimiento));
                cmd.Parameters.Add(new SQLiteParameter("@tipodoc", obj.tipodoc));
                cmd.Parameters.Add(new SQLiteParameter("@FechaNac", obj.FechaNac));
                cmd.Parameters.Add(new SQLiteParameter("@EmpleadoRegistro", obj.EmpleadoRegistro));
                

                cmd.CommandType= System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery()<1) {
                    respuesta=false;
                }
            }
            return respuesta;
        }



        public List<Cliente> Listar()
        {
            List<Cliente> oLista = new List<Cliente>();


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT id, ndoc, Nombres, Apellidos, tipoMembresia, Telefono, Direccion, email, 
       genero, EstadoMembria, fechaInicio, fechaVencimiento, tipodoc, FechaNac,EmpleadoRegistro,FechaRegistro
        FROM cliente
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
          
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while( dr.Read())
                    {
                        oLista.Add(new Cliente()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            ndoc = dr["ndoc"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            tipoMembresia =dr["tipoMembresia"].ToString(),
                            EstadoMembresia = dr["EstadoMembria"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            email = dr["email"].ToString(),
                            genero = dr["genero"].ToString(),
                            FechaNac = dr["FechaNac"].ToString(),
                            fechaInicio = dr["fechaInicio"].ToString(),
                            tipodoc = dr["tipodoc"].ToString(),
                            fechaVencimiento = dr["fechaVencimiento"].ToString(),
                            EmpleadoRegistro = dr["EmpleadoRegistro"].ToString(),
                            FechaRegistro = dr["FechaRegistro"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }

        public List<Cliente> ListarProximosAvencer()
        {
            List<Cliente> oLista = new List<Cliente>();


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT id, ndoc, Nombres, Apellidos, tipoMembresia,
       EstadoMembria, fechaInicio, fechaVencimiento, FechaRegistro, CAST(julianday(fechaVencimiento) - julianday( datetime('now')) AS STRING) as Dias
        FROM cliente 
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string fechaHoyStr = DateTime.Today.ToString("dd/MM/yyyy");
                        

                        DateTime fechaHoy = DateTime.ParseExact(fechaHoyStr, "dd/MM/yyyy", null);

                        oLista.Add(new Cliente()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            ndoc = dr["ndoc"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            tipoMembresia = dr["tipoMembresia"].ToString(),
                            EstadoMembresia = dr["EstadoMembria"].ToString(),
                            fechaInicio = dr["fechaInicio"].ToString(),
                            dias = (Convert.ToDateTime(dr["fechaVencimiento"]) - fechaHoy).Days.ToString(),
                            Alerta = (Convert.ToDateTime(dr["fechaVencimiento"]) - fechaHoy).Days == 0 ? "Membresia Vencida" :

                             ((Convert.ToDateTime(dr["fechaVencimiento"]) - fechaHoy).Days < 5 ?
                            "Por Vencer" : ""),




                            fechaVencimiento = dr["fechaVencimiento"].ToString(),
                            //dias = int.Parse(dr["DiasRestantes"].ToString()),

                            FechaRegistro = dr["FechaRegistro"].ToString()
                        }); ; ; ;
                    }
                }
            }
            return oLista;
        }

        public List<Cliente> Buscar(Cliente obj)
        {
            List<Cliente> oLista = new List<Cliente>();



            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT id, ndoc, Nombres, Apellidos, tipoMembresia, Telefono, Direccion, email, 
                               genero, EstadoMembria, fechaInicio, fechaVencimiento, tipodoc, FechaNac,EmpleadoRegistro,FechaRegistro
                                FROM cliente where ndoc=@ndoc
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new SQLiteParameter("@ndoc", obj.ndoc));

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Cliente()
                        {
                            id = int.Parse(dr["id"].ToString()),
                            ndoc = dr["ndoc"].ToString(),
                            Nombres = dr["Nombres"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            tipoMembresia = dr["tipoMembresia"].ToString(),
                            EstadoMembresia = dr["EstadoMembria"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            email = dr["email"].ToString(),
                            genero = dr["genero"].ToString(),
                            FechaNac = dr["FechaNac"].ToString(),
                            fechaInicio = dr["fechaInicio"].ToString(),
                            tipodoc = dr["tipodoc"].ToString(),
                            fechaVencimiento = dr["fechaVencimiento"].ToString(),
                            EmpleadoRegistro = dr["EmpleadoRegistro"].ToString(),
                            FechaRegistro = dr["FechaRegistro"].ToString()
                        });
                    }
                }
            }
            return oLista;
        }
        public bool Editar(Cliente obj)
        {
            bool respuesta = true;
            //Apellidos = @Apellidos, tipoMembresia = @tipoMembresia,
            //        Telefono = @Telefono, Direccion = @Direccion, email = @email, genero = @genero,
            //        EstadoMembria = @EstadoMembria, fechaInicio = @fechaInicio, fechaVencimiento = @fechaVencimiento,
            //        tipodoc = @Tipodoc, FechaNac = @FechaNac,EmpleadoRegistro = @EmpleadoRegistro, FechaRegistro = datetime('now')

          

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"UPDATE cliente SET ndoc = @ndoc, 
                    Nombres = @Nombres, Apellidos = @apellidos, tipoMembresia = @tipoMembresia,
                    Telefono = @telefono, Direccion = @direccion,
                    email = @email, genero = @genero,
                    EstadoMembria = @EstadoMembria, fechaInicio = @fechaInicio, fechaVencimiento = @fechaVencimiento,
                    tipodoc = @tipodoc, FechaNac = @FechaNac,EmpleadoRegistro = @EmpleadoRegistro, FechaRegistro = datetime('now')
                    
                WHERE ndoc = @ndoc";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                
                cmd.Parameters.Add(new SQLiteParameter("@ndoc", obj.ndoc));
                cmd.Parameters.Add(new SQLiteParameter("@Nombres", obj.Nombres));
                cmd.Parameters.Add(new SQLiteParameter("@apellidos", obj.Apellidos));
                cmd.Parameters.Add(new SQLiteParameter("@tipoMembresia", obj.tipoMembresia));
                cmd.Parameters.Add(new SQLiteParameter("@telefono", obj.Telefono));
                cmd.Parameters.Add(new SQLiteParameter("@direccion", obj.Direccion));
                cmd.Parameters.Add(new SQLiteParameter("@email", obj.email));
                cmd.Parameters.Add(new SQLiteParameter("@genero", obj.genero));
                cmd.Parameters.Add(new SQLiteParameter("@EstadoMembria", obj.EstadoMembresia));
                cmd.Parameters.Add(new SQLiteParameter("@fechaInicio", obj.fechaInicio));
                cmd.Parameters.Add(new SQLiteParameter("@fechaVencimiento", obj.fechaVencimiento));
                cmd.Parameters.Add(new SQLiteParameter("@tipodoc", obj.tipodoc));
                cmd.Parameters.Add(new SQLiteParameter("@FechaNac", obj.FechaNac));
                cmd.Parameters.Add(new SQLiteParameter("@EmpleadoRegistro", obj.EmpleadoRegistro));


                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }


        public bool Eliminar(Cliente obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from  cliente  WHERE ndoc = @ndoc;";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@ndoc", obj.ndoc));
              

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }



        public void ConvertFecha()
        {
        
        }
        

  
    }

}

