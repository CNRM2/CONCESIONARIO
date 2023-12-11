using System.Data;
using System.Data.SqlClient;

namespace CONCESIONARIO.DAL
{
    class Conexion
    {
        private const string connectionString = "Data Source=LAPTOP-IHH9I2JJ;Initial Catalog=CONCESIONARIO;Integrated Security=True";

        public bool Conectar()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM VENDEDOR", connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InsertarVendedor(int INE, string nombre, string domicilio, string lugarTrabajo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO VENDEDOR (INE, NOMBRE, DOMICILIO, LUGARTRABAJO) " +
                                    "VALUES (@INE, @NOMBRE, @DOMICILIO, @LUGARTRABAJO)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@INE", INE);
                    command.Parameters.AddWithValue("@NOMBRE", nombre);
                    command.Parameters.AddWithValue("@DOMICILIO", domicilio);
                    command.Parameters.AddWithValue("@LUGARTRABAJO", lugarTrabajo);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message);
                return false;
            }
        }

        public DataTable BuscarAutoPorMarca(string marca)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM AUTOMOVIL WHERE MARCA = @Marca";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Marca", marca);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente según tu lógica
                Console.WriteLine("Error al buscar el auto por marca: " + ex.Message);
            }

            return dataTable;
        }

        public DataTable BuscarAutoPorBastidor(string numeroBastidor)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM AUTOMOVIL WHERE BASTIDOR = @NumeroBastidor";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NumeroBastidor", numeroBastidor);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente según tu lógica
                Console.WriteLine("Error al buscar el auto por número de bastidor: " + ex.Message);
            }

            return dataTable;
        }

        public DataTable BuscarAutoPorINE(string numINE)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM VENDEDOR WHERE INE = @NumINE";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NumINE", numINE);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente según tu lógica
                Console.WriteLine("Error al buscar el Vendedor por INE: " + ex.Message);
            }

            return dataTable;
        }

        public class Automovil
        {
            public int BASTIDOR { get; set; }
            public string MARCA { get; set; }
            public decimal PRECIO { get; set; }
            public string MODELO { get; set; }
            public string CARACTERISTICAS { get; set; }
            public int VENDEDOR { get; set; }
            // Otras propiedades del automóvil
        }

        public class Extra
        {
            public int IDEXTRA { get; set; }
            public string NOMBREEXTRA { get; set; }
            public decimal PRECIOEXTRA { get; set; }
            // Otras propiedades del extra
        }

        public class Vendedor
        {
            public int INE { get; set; }
            public string NOMBRE { get; set; }
            public string DOMICILIO { get; set; }
            public string LUGARTRABAJO { get; set; }
        }

        public List<Automovil> ObtenerAutomoviles()
        {
            List<Automovil> automoviles = new List<Automovil>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT BASTIDOR, MODELO, MARCA, PRECIO, CARACTERISTICAS, VENDEDORINE FROM AUTOMOVIL";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Automovil automovil = new Automovil
                        {
                            BASTIDOR = Convert.ToInt32(reader["BASTIDOR"]),
                            MARCA = reader["MARCA"].ToString(),
                            MODELO = reader["MODELO"].ToString(),
                            PRECIO = Convert.ToDecimal(reader["PRECIO"]),
                            CARACTERISTICAS = reader["CARACTERISTICAS"].ToString(),
                            VENDEDOR = Convert.ToInt32(reader["VENDEDORINE"])
                        };
                        automoviles.Add(automovil);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener automóviles: " + ex.Message);
            }

            return automoviles;
        }

        public List<Extra> ObtenerExtras()
        {
            List<Extra> extras = new List<Extra>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDEXTRA, NOMBREEXTRA, PRECIOEXTRA FROM EXTRA";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Extra extra = new Extra
                        {
                            IDEXTRA = Convert.ToInt32(reader["IDEXTRA"]),
                            NOMBREEXTRA = reader["NOMBREEXTRA"].ToString(),
                            PRECIOEXTRA = Convert.ToDecimal(reader["PRECIOEXTRA"])
                            // Otras propiedades del extra, si las hay
                        };
                        extras.Add(extra);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener extras: " + ex.Message);
            }

            return extras;
        }

        public List<Automovil> ObtenerAutosDisponibles()
        {
            List<Automovil> autosDisponibles = new List<Automovil>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM AUTOS_DISPONIBLES"; // Query para obtener los autos disponibles
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Automovil auto = new Automovil
                        {
                            // Asigna los valores de la base de datos a las propiedades del objeto Automovil
                            // Ejemplo: auto.Marca = reader["Marca"].ToString();
                        };
                        autosDisponibles.Add(auto);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener autos disponibles: " + ex.Message);
            }

            return autosDisponibles;
        }

        public bool ActualizarAutomovil(Automovil automovil)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE AUTOMOVIL SET MARCA = @NuevaMarca, MODELO = @NuevoModelo, PRECIO = @NuevoPrecio,CARACTERISTICAS = @Caracteristicas, VENDEDORINE = @Vendedor WHERE BASTIDOR = @Bastidor";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NuevaMarca", automovil.MARCA);
                    command.Parameters.AddWithValue("@NuevoModelo", automovil.MODELO);
                    command.Parameters.AddWithValue("@NuevoPrecio", automovil.PRECIO);
                    command.Parameters.AddWithValue("@Bastidor", automovil.BASTIDOR);
                    command.Parameters.AddWithValue("@Caracteristicas", automovil.CARACTERISTICAS);
                    command.Parameters.AddWithValue("@Vendedor", automovil.VENDEDOR);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el automóvil: " + ex.Message);
                return false;
            }
        }

        public bool EliminarAutoPorBastidor(int numeroBastidor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Eliminar registros relacionados en AUTOMOVIL_EXTRA
                    string deleteExtrasQuery = "DELETE FROM AUTOMOVIL_EXTRA WHERE BASTIDOR = @NumeroBastidor";
                    SqlCommand extrasCommand = new SqlCommand(deleteExtrasQuery, connection);
                    extrasCommand.Parameters.AddWithValue("@NumeroBastidor", numeroBastidor);
                    extrasCommand.ExecuteNonQuery();

                    // Una vez eliminados los registros relacionados, eliminar el auto de la tabla AUTOMOVIL
                    string deleteAutoQuery = "DELETE FROM AUTOMOVIL WHERE BASTIDOR = @NumeroBastidor";
                    SqlCommand autoCommand = new SqlCommand(deleteAutoQuery, connection);
                    autoCommand.Parameters.AddWithValue("@NumeroBastidor", numeroBastidor);

                    int rowsAffected = autoCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el auto: " + ex.Message);
                return false;
            }
        }

        public bool InsertarAuto(int bastidor, string marca, string modelo, decimal precio, string caracteristicas, string vendedor)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO AUTOMOVIL (BASTIDOR, MARCA, MODELO, CARACTERISTICAS, PRECIO, VENDEDORINE) " +
                                   "VALUES (@Bastidor, @Marca, @Modelo, @Caracteristicas, @Precio, @Vendedor)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Bastidor", bastidor);
                    command.Parameters.AddWithValue("@Marca", marca);
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@Caracteristicas", caracteristicas);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Vendedor", vendedor);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el auto: " + ex.Message);
                return false;
            }
        }

        public bool ActualizarVendedor(int INE, string nuevoNombre, string nuevoDomicilio, string nuevoLugarTrabajo)
        {
            bool actualizado = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE VENDEDOR SET NOMBRE = @Nombre, DOMICILIO = @Domicilio, LUGARTRABAJO = @LugarTrabajo WHERE INE = @INE";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                    command.Parameters.AddWithValue("@Domicilio", nuevoDomicilio);
                    command.Parameters.AddWithValue("@LugarTrabajo", nuevoLugarTrabajo);
                    command.Parameters.AddWithValue("@INE", INE);

                    int filasActualizadas = command.ExecuteNonQuery();

                    if (filasActualizadas > 0)
                    {
                        actualizado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al actualizar el vendedor: " + ex.Message);
            }
            return actualizado;
        }

        public List<Vendedor> ObtenerVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT INE, NOMBRE, DOMICILIO, LUGARTRABAJO FROM VENDEDOR";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Vendedor vendedor = new Vendedor
                        {
                            INE = Convert.ToInt32(reader["INE"]),
                            NOMBRE = reader["NOMBRE"].ToString(),
                            DOMICILIO = reader["DOMICILIO"].ToString(),
                            LUGARTRABAJO = reader["LUGARTRABAJO"].ToString()
                        };
                        vendedores.Add(vendedor);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener vendedores: " + ex.Message);
            }

            return vendedores;
        }

        public DataTable BuscarVendedor(string INE)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM VENDEDOR WHERE INE = @INE";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@INE", INE);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente según tu lógica
                Console.WriteLine("Error al buscar al vendedor por su INE: " + ex.Message);
            }

            return dataTable;
        }

        public bool EliminarVendedor(int INE)
        {
            bool eliminado = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM VENDEDOR WHERE INE = @INE";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@INE", INE);

                    int rowsAffected = command.ExecuteNonQuery();
                    eliminado = rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar vendedor: " + ex.Message);
            }

            return eliminado;
        }

        public DataTable CargarVentas(string IDVENTA)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT V.IDVENTA, V.FECHA, V.METODOPAGO, V.STOCK, " +
                        "(SELECT NOMBRE FROM VENDEDOR WHERE INE = V.VENDEDORINE) AS NOMBRE_VENDEDOR,V.BASTIDOR," +
                        "(SELECT MODELO FROM AUTOMOVIL WHERE BASTIDOR = V.BASTIDOR) AS MODELO," +
                        "(SELECT PRECIO FROM AUTOMOVIL WHERE BASTIDOR = V.BASTIDOR) AS PRECIO_MODELO," +
                        "V.IDEXTRA," +
                        "(SELECT PRECIOEXTRA FROM EXTRA WHERE IDEXTRA = V.IDEXTRA) AS PRECIO_EXTRA FROM VENTA V WHERE V.IDVENTA = @IDVENTA;";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDVENTA", IDVENTA);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente según tu lógica
                Console.WriteLine("Error al buscar al vendedor por su INE: " + ex.Message);
            }

            return dataTable;
        }
    }
}