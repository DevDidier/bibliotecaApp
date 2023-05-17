using BibliotecaApp;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidadDesktop
{
    internal class ControllerBiblioteca
    {
        PostgresConexion postgresConexion = new PostgresConexion();
        NpgsqlConnection cnn;
        public bool InsertarLibro(string nombre, string autor, int paginas, int categoria)
        {
            try
            {
                using (var cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "INSERT INTO catalogo_biblioteca (nombre, autor, paginas, fecha_ingreso, categoria) " +
                                  "VALUES (@nombre, @autor, @paginas, @fecha, @categoria)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("nombre", nombre);
                            cmd.Parameters.AddWithValue("autor", autor);
                            cmd.Parameters.AddWithValue("paginas", paginas);
                            cmd.Parameters.AddWithValue("categoria", categoria);
                            cmd.Parameters.AddWithValue("fecha", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el libro: {ex.Message}");
                return false;
            }
        }

        public DataTable ObtenerCatalogoBiblioteca()
        {
            try
            {
                using (cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "SELECT t1.nombre, t1.autor, t1.paginas, t1.fecha_ingreso, t2.categoria as categoria, " +
                            "t1.estado FROM catalogo_biblioteca t1, categorias t2 WHERE t1.categoria=t2.codigo " +
                            "AND t1.estado != 2";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                            {
                                DataTable dtCatalogo = new DataTable();
                                dtCatalogo.Columns.Add("Nombre", typeof(string));
                                dtCatalogo.Columns.Add("Autor", typeof(string));
                                dtCatalogo.Columns.Add("Páginas", typeof(int));
                                dtCatalogo.Columns.Add("Fecha de ingreso", typeof(DateTime));
                                dtCatalogo.Columns.Add("Categoría", typeof(string));
                                dtCatalogo.Columns.Add("Estado", typeof(string));

                                string fechaIngreso;
                                DateTime fecha;
                                string estado;
                                while (rdr.Read())
                                {
                                    DataRow row = dtCatalogo.NewRow();
                                    row["Nombre"] = rdr.GetString(0);
                                    row["Autor"] = rdr.GetString(1);
                                    row["Páginas"] = rdr.GetInt32(2);

                                    fecha = rdr.GetDateTime(3);
                                    fechaIngreso = fecha.ToString("dd/MM/yyyy");
                                    row["Fecha de ingreso"] = fechaIngreso;
                                    fechaIngreso = null;
                                    
                                    row["Categoría"] = rdr.GetString(4);

                                    estado = rdr.GetInt32(5) == 0 ? "Disponible" : "En prestamo";
                                    row["Estado"] = estado;

                                    dtCatalogo.Rows.Add(row);
                                }
                                return dtCatalogo;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el catálogo de la biblioteca: {ex.Message}");
                return null;
            }
        }
        public bool BuscarLibroPorNombre(string nombre, string columna ,out DataTable resultados)
        {
            resultados = new DataTable();
            try
            {
                using (cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "SELECT t1.nombre, t1.autor, t1.paginas, t1.fecha_ingreso, t2.categoria as categoria " +
                       "FROM catalogo_biblioteca t1, categorias t2 " +
                       "WHERE t1.categoria=t2.codigo AND " + columna + " ILIKE @nombre";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("nombre", "%" + nombre + "%");

                            using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                            {
                                resultados.Load(rdr);
                                return resultados.Rows.Count > 0;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar el libro por nombre: {ex.Message}");
                return false;
            }
        }

        public (int, string)[] listadoLibros()
        {
            try
            {
                using (cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "SELECT t1.id, t1.nombre FROM catalogo_biblioteca t1, categorias t2 WHERE t1.categoria=t2.codigo AND t1.estado != 2";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                            {
                                List<(int, string)> catalogo = new List<(int, string)>();

                                while (rdr.Read())
                                {
                                    int id = rdr.GetInt32(0);
                                    string nombre = rdr.GetString(1);
                                    catalogo.Add((id, nombre));
                                }

                                return catalogo.ToArray();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el catálogo de la biblioteca: {ex.Message}");
                return null;
            }
        }

        public (int, string)[] consultaEstudiantes()
        {
            try
            {
                using (cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "SELECT t1.cedula, t1.nombre as nombre, t2.nombre as carrera " +
                            "FROM estudiantes t1, carreras_regis t2 WHERE t1.carrera=t2.id AND " +
                            " t2.estado = '0' AND t1.estado = '0'";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                            {
                                List<(int, string)> estudiantes = new List<(int, string)>();

                                while (rdr.Read())
                                {
                                    int cedula = rdr.GetInt32(0);
                                    string nombre = rdr.GetString(1);
                                    estudiantes.Add((cedula, nombre));
                                }
                                return estudiantes.ToArray();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el catálogo de la biblioteca: {ex.Message}");
                return null;
            }
        }

        public bool IngresarPrestamo(string libro, int cedula)
        {
            try
            {
                using (var cnn = postgresConexion.Conectar())
                {
                    if (cnn != null)
                    {
                        var sql = "INSERT INTO catalogo_biblioteca (nombre, autor, paginas, fecha_ingreso, categoria) " +
                                  "VALUES (@nombre, @autor, @paginas, @fecha, @categoria)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cnn))
                        {
                            cmd.Parameters.AddWithValue("libro", libro);
                            cmd.Parameters.AddWithValue("cedula", cedula);
                            cmd.Parameters.AddWithValue("fecha", DateTime.Now);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se pudo establecer la conexión con la base de datos");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el libro: {ex.Message}");
                return false;
            }
        }
    }
}
