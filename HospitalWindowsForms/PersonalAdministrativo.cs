using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPOO
{
    public class PersonalAdministrativo: Persona
    {
        public PersonalAdministrativo(string nombre, string dni, string telefono): base(nombre, dni, telefono) { 
        
        }

        public override string ToString()
        {
            return "Personal Administrativo - Nombre: " + Nombre + " - Telefono: " + Telefono + " - DNI: " + Dni;
        }

    }
}
