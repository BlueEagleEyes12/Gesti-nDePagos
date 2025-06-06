using System;
using System.Data;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace CapaNegocio
{


    public class Pago
    {
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string MedioPago { get; set; }

        public virtual void ProcesarPago()
        {
            Console.WriteLine($"Procesando pago de {Monto:C} realizado el {Fecha.ToShortDateString()} por {MedioPago}.");
        }
    }

    public class PagoEfectivo : Pago
    {
        public override void ProcesarPago()
        {
            MedioPago = "Efectivo";
            Console.WriteLine($"Pago en efectivo de {Monto:C} registrado el {Fecha.ToShortDateString()}.");
        }
    }

    public class PagoTarjeta : Pago
    {
        public string NumeroTarjeta { get; set; }

        public override void ProcesarPago()
        {
            MedioPago = "Tarjeta";
            Console.WriteLine($"Pago con tarjeta de {Monto:C} registrado el {Fecha.ToShortDateString()} usando tarjeta terminada en {NumeroTarjeta.Substring(NumeroTarjeta.Length - 4)}.");
        }
    }


    public class EmpleadoNegocio
    {

        private readonly Conexion conexion = new Conexion();

        public DataTable ObtenerEmpleados()
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "SELECT * FROM Pagos";
                    SqlCommand comando = new SqlCommand(query, conn);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();

                    conn.Open();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    throw;
                }
            }

        }

        public bool InsertarPago(Pago pago)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                try
                {
                    string query = "INSERT INTO Pagos (MONTO, FECHA, MedioPago) VALUES (@Monto, @Fecha, @MedioPago)";
                    SqlCommand comando = new SqlCommand(query, conn);

                    comando.Parameters.AddWithValue("@Monto", pago.Monto);
                    comando.Parameters.AddWithValue("@Fecha", pago.Fecha);
                    comando.Parameters.AddWithValue("@MedioPago", pago.MedioPago);

                    conn.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();

                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR al insertar pago: " + ex.Message);
                    return false;
                }
            }
        }



    }

}
