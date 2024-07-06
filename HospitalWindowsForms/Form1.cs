using HospitalPOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalWindowsForms
{
    public partial class Form1 : Form
    {

        Hospital hospital = new Hospital();
        public Form1()
        {
            InitializeComponent();
        }

        private void butAltaMedico_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(true, false, false, false, hospital);
            f.ShowDialog();
        }

        private void butAltaPaciente_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(false, false, false, false, hospital);
            f.ShowDialog();
        }

        private void butAltaPersonalAdministrativo_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(false, true, false, false, hospital);
            f.ShowDialog();
        }

        private void butListarMedicos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hospital.ListarMedicos());
                 
        }

        private void butListarPacientes_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(false, false, true, false, hospital);
            f.ShowDialog();
        }

        private void butEliminarPaciente_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(false, false, false, true, hospital);
            f.ShowDialog();
        }

        private void butListarHospital_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hospital.ListarGenteHospital());
        }
    }
}
