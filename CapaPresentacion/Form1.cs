using CapaNegocio;
using System.Data;
using System.Windows.Forms;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }


        private void CargarDatos()
        {
            try
            {
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                DataTable empleados = negocio.ObtenerEmpleados();
                dataGridView1.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btenviar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(txtMonto.Text);
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                string medio = txtMedio.Text.Trim();

                Pago pago;


                if (medio.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
                {
                    pago = new PagoEfectivo
                    {
                        Monto = monto,
                        Fecha = fecha
                    };
                }
                else if (medio.Equals("Tarjeta", StringComparison.OrdinalIgnoreCase))
                {
                    // Si no tienes un campo para número de tarjeta, puedes poner uno fijo o dejarlo vacío
                    pago = new PagoTarjeta
                    {
                        Monto = monto,
                        Fecha = fecha,
                        NumeroTarjeta = "0000000000000000" // puedes agregar un TextBox si quieres capturarlo
                    };
                }
                else
                {
                    MessageBox.Show("Medio de pago inválido. Usa 'Efectivo' o 'Tarjeta'.");
                    return;
                }

                pago.ProcesarPago();
                EmpleadoNegocio negocio = new EmpleadoNegocio();
                bool insertado = negocio.InsertarPago(pago);

                if (insertado)
                {
                    MessageBox.Show("Pago insertado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el pago.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de monto o fecha inválido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
