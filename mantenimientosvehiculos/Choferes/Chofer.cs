using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientosvehiculos.Choferes
{
    public class Chofer
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string LicenciaConducir { get; set; }

        public string Categorialicencia { get; set; }
        public DateTime FechaNacimiento { get; set; }
        // Otras propiedades relacionadas con el chofer

        public Chofer()
        {
            // Genera un nuevo ID único para cada chofer
            Id = GenerarNuevoId();
        }

        public Chofer(int id, string nombre, string cedula, string licenciaConducir, string categorialicencia, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            LicenciaConducir = licenciaConducir;
            Categorialicencia = categorialicencia;
            FechaNacimiento = fechaNacimiento;
        }



        // Método para generar un nuevo ID único para cada chofer
        private static int ultimoId = 0;

        private static int GenerarNuevoId()
        {
            return ++ultimoId;
        }
    }
}
