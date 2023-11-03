using mantenimientosvehiculos.mantanimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientosvehiculos.Vehiculos
{
    public abstract class Vehiculo
    {
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        private static int ultimoId = 0;
        public List<Mantenimiento> Mantenimientos { get; private set; } = new List<Mantenimiento>();

        public int Id { get; set; }

        public Vehiculo()
        {
            // Generar un nuevo ID único para cada vehículo
            Id = ++ultimoId;
        }
        public double CostoTotal { get;  set; }
        public int Año { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string TipodeVehiculo { get; set; }
        public string Foto { get; set; }
        public void AgregarMantenimiento(Mantenimiento mantenimiento)
        {
            Mantenimientos.Add(mantenimiento);
        }
        public void AgregarGasto(double monto)
        {
            CostoTotal += monto;
        }

        // Método para verificar y enviar alerta de próximo mantenimiento
        public void VerificarAlertaProximoMantenimiento()
        {
            var proximoMantenimiento = Mantenimientos.OrderBy(m => m.FechaProximoMantenimiento).FirstOrDefault();

            if (proximoMantenimiento == null)
            {
                MessageBox.Show("No hay mantenimientos programados.");
                return;
            }

            if (DateTime.Now < proximoMantenimiento.FechaProximoMantenimiento && DateTime.Now.AddDays(7) >= proximoMantenimiento.FechaProximoMantenimiento)
            {
                MessageBox.Show($"ALERTA: El vehículo {this.Placa} tiene programado un {proximoMantenimiento.TipoMantenimiento} para el {proximoMantenimiento.FechaProximoMantenimiento.ToShortDateString()}", "Alerta de Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"No hay alertas próximas. Próximo mantenimiento programado para el {proximoMantenimiento.FechaProximoMantenimiento.ToShortDateString()}.");
            }

        }
        public List<RegistroCombustible> HistorialCombustible { get; private set; } = new List<RegistroCombustible>();

        public void AgregarRegistroCombustible(RegistroCombustible registro)
        {
            HistorialCombustible.Add(registro);
        }

        public double CalcularConsumoPromedio()
        {
            if (HistorialCombustible.Count < 2) return 0; // No hay suficientes registros para calcular consumo

            var ultimoRegistro = HistorialCombustible.Last();
            var penultimoRegistro = HistorialCombustible[HistorialCombustible.Count - 2];

            double distanciaRecorrida = ultimoRegistro.KilometrajeActual - penultimoRegistro.KilometrajeActual;
            double litrosConsumidos = ultimoRegistro.CantidadLitros;

            return distanciaRecorrida / litrosConsumidos; // Retornar km por litro
        }

    }

        public class Automovil : Vehiculo
        {
            public int Puertas { get; set; }
        }

        public class Micorbus : Vehiculo
        {
            public int CargaMaximaKg { get; set; }
        }
    public enum TipoCombustible
    {
        Gasolina,
        Diesel,
        Electricidad,
        Hibrido
        // Puedes agregar otros tipos según sea necesario.
    }

    public class RegistroCombustible
    {
        public DateTime FechaAbastecimiento { get; set; }
        public double CantidadLitros { get; set; }
        public double CostoPorLitro { get; set; }
        public TipoCombustible Tipo { get; set; }
        public string EstacionServicio { get; set; } // Nombre o ubicación de la estación de servicio
        public double KilometrajeActual { get; set; } // Kilometraje del vehículo en el momento de abastecer
    }

}
