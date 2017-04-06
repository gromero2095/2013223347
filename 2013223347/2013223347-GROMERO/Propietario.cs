using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013223347_GROMERO
{
    class Propietario
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Apellidos  { get; set; }
        public string LicenciaConducir { get; set; }

        public Propietario()
        {
        }

        public Propietario(string _dni, string _nombre, string _apellido, string _licenciaconducir)
        {
            Dni = _dni;
            Nombres = _nombre;
            Apellidos = _apellido;
            LicenciaConducir = _licenciaconducir;

        }
    }
}
