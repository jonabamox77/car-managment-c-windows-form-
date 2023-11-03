using mantenimientosvehiculos.mantanimientos;
using mantenimientosvehiculos.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientosvehiculos.mantanimientos
{

    public class Mantenimiento
    {
        public Mantenimiento(Vehiculo vehiculoSeleccionado, TipoMantenimiento tipoMantenimiento, int kilometrosActuales, int kilometrosProximos, string conductor, string cedulaConductor, int numeroSolicitud, double costo, DateTime fechaVencimiento, DateTime fechaSolicitud, DateTime fechaProximoMantenimiento)
        {
            VehiculoSeleccionado = vehiculoSeleccionado; // Corregir esta línea
            TipoMantenimiento = tipoMantenimiento;
            KilometrosActuales = kilometrosActuales;
            KilometrosProximos = kilometrosProximos;
            Conductor = conductor;
            CedulaConductor = cedulaConductor;
            NumeroSolicitud = numeroSolicitud;
            Costo = costo;
            FechaVencimiento = fechaVencimiento;
            FechaSolicitud = fechaSolicitud;
            FechaProximoMantenimiento = fechaProximoMantenimiento;
        }

        public Vehiculo VehiculoSeleccionado { get; set; }
        public TipoMantenimiento TipoMantenimiento { get; set; }
        public int KilometrosActuales { get; set; }
        public int KilometrosProximos { get; set; }
        public string Conductor { get; set; }
        public string CedulaConductor { get; set; }
        public int NumeroSolicitud { get; set; }
        public double Costo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaProximoMantenimiento { get; set; }
        // Otras propiedades como fecha, descripción, etc.
    }
    public enum TipoMantenimiento
    {
        CambioDeAceite,
        CambioDeLlantas,
        CambioDeBateria,
        Lavado,
        // Agrega otros tipos de mantenimiento según sea necesario
    }
   
    }


    // Propiedad para determinar si es hora de enviar una alerta
 
