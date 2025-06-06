using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private readonly string cadenaConexion = "Server=.;Database=GESTION;Integrated Security=true;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
