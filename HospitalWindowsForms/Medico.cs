using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPOO
{
    public class Medico : Persona
    {
        List<Paciente> paciente = null;
        string especialidad;
        string rango;
        public Medico(string nombre, string dni, string telefono, string especialidad, string rango, List<Paciente> paciente) : base(nombre, dni, telefono)
        {
            this.especialidad = especialidad;
            this.rango = rango;
            this.paciente = new List<Paciente>();
        }

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Rango { get => rango; set => rango = value; }
        public List<Paciente> Paciente { get => paciente; set => paciente = value; }

        public override string ToString()
        {
            return "Medico - Nombre: "+ Nombre + " - Telefono: " + Telefono + " - DNI: " + Dni + " - Especialidad: " + Especialidad + " - Rango: " + Rango;
        }

    }
}
