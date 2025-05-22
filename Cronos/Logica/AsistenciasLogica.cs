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
    public class AsistenciasLogica
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        private static AsistenciasLogica _instanci = null;

        public AsistenciasLogica()
        {

        }
        public static AsistenciasLogica Instancia
        {
            get
            {
                if (_instanci == null)
                {
                    _instanci = new AsistenciasLogica();
                }

                return _instanci;
            }



        }

        //GUARDAR
      

        //BUSCAR
        public List<Cliente> BuscarDoc(Cliente obj)
        {
            List<Cliente> oLista = new List<Cliente>();



            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"SELECT id, ndoc, Nombres, Apellidos, tipoMembresia, Telefono, Direccion, email, 
                               genero, EstadoMembria, fechaInicio, fechaVencimiento, tipodoc, FechaNac,EmpleadoRegistro,FechaRegistro
                                FROM cliente where ndoc=@ndoc";

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


        //guardar
        public bool Guardar(Asistencia obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"INSERT INTO t_Asistencias (
                                        ndoc,
                                        nombreCli,
                                        fechaEntrada,
                                        tipoMembresia,
                                        Precio
                                     
                                    )
                                    VALUES (
                                        @ndoc,
                                        @nombreCli,
                                        @fechaEntrada,
                                        @tipoMembresia,
                                        @Precio
                                    );
                              
                        ";





                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.Parameters.Add(new SQLiteParameter("@ndoc", obj.ndoc));
                cmd.Parameters.Add(new SQLiteParameter("@nombreCli", obj.nombreCliente));
                cmd.Parameters.Add(new SQLiteParameter("@fechaEntrada", obj.fechaEntrada));
                cmd.Parameters.Add(new SQLiteParameter("@tipoMembresia", obj.tipoMembresia));
                cmd.Parameters.Add(new SQLiteParameter("@Precio", obj.precio));
              

                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        public List<Asistencia> Listar()
        {
            List<Asistencia> oLista = new List<Asistencia>();


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = @"Select IdAsistencia, ndoc,
                                        nombreCli,
                                        fechaEntrada,
                                        tipoMembresia,
                                        Precio
        FROM t_Asistencias
        ";

                SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Asistencia()
                        {
                            idAsistencias = int.Parse(dr["IdAsistencia"].ToString()),
                            nombreCliente = dr["nombreCli"].ToString(),
                            ndoc = dr["ndoc"].ToString(),
                            fechaEntrada = dr["fechaEntrada"].ToString(),
              
                            tipoMembresia = dr["tipoMembresia"].ToString(),

                            precio = decimal.Parse(dr["Precio"].ToString()),


                        });
                    }
                }
            }
            return oLista;
        }

        public bool Eliminar(Asistencia obj)
        {
            bool respuesta = true;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "delete from  t_Asistencias  WHERE IdAsistencia = @IdAsistencia;";


                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@IdAsistencia", obj.idAsistencias));


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
