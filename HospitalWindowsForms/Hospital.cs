using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalPOO
{
    public class Hospital
    {
        List<Medico> medicos = null;
        List<Paciente> pacientes = null;
        List<PersonalAdministrativo> personalAdministrativos = null;

        public Hospital()
        {
            medicos = new List<Medico>();
            pacientes = new List<Paciente>();
            personalAdministrativos= new List<PersonalAdministrativo>();    
        }

        public List<Medico> Medicos { get => medicos; set => medicos = value; }
        public List<PersonalAdministrativo> PersonalAdministrativos { get => personalAdministrativos; set => personalAdministrativos = value; }
        public List<Paciente> Pacientes { get => pacientes; set => pacientes = value; }

        public string ListarMedicos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in medicos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public string ListarPacientes()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in pacientes)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
            
        }

        public string ListarPersonalAdministrativo()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in PersonalAdministrativos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public string ListarGenteHospital()
        {
            return ListarMedicos() + "\n" + ListarPacientes() + "\n" + ListarPersonalAdministrativo();
        }

    }
}
