using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPOO
{
    public class Paciente : Persona
    {
        Medico medico;
        string sintomas;
        public Paciente(string nombre, string dni, string telefono, Medico medico, string sintomas): base(nombre, dni, telefono) { 
            this.medico = medico; 
            this.sintomas = sintomas;
            
        }

        public Medico Medico { get => medico; set => medico = value; }
        public string Sintomas { get => sintomas; set => sintomas = value; }

        public override string ToString()
        {
            return "Paciente - Nombre: " + Nombre + " - Telefono: " + Telefono + " - DNI: " + Dni + " - Medico: " + Medico.Nombre + " - Sintomas: " + Sintomas;
        }

    }
}
