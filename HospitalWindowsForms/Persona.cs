using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPOO
{
    public class Persona
    {
        string nombre;
        string dni;
        string telefono;
        public Persona(string nombre, string dni, string telefono) { 
            this.nombre = nombre;
            this.dni = dni; 
            this.telefono = telefono;     
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        




    }
}
