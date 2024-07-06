using HospitalPOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalWindowsForms
{
    public partial class Form2 : Form
    {
        Boolean Medico;
        Boolean PersonalAdminstrativo;
        Hospital hospital;

        public Form2(Boolean Medico, Boolean PersonalAdminstrativo, Hospital hospital)
        {
            this.Medico = Medico;
            this.PersonalAdminstrativo = PersonalAdminstrativo;
            this.hospital = hospital;
            InitializeComponent();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operación Cancelada");
            Close();

        }

        private void butCrear_Click(object sender, EventArgs e)
        {
            if (Medico == true && PersonalAdminstrativo == false)
            {
                if (!ValidacionTextBox(new List<System.Windows.Forms.TextBox> { textBoxNombre, textBoxDni, textBoxTelefono, textBoxEspecialidad, textBoxRango }))
                    return;

                Medico medico = new Medico(textBoxNombre.Text, textBoxDni.Text, textBoxTelefono.Text, textBoxEspecialidad.Text, textBoxRango.Text, null);
                hospital.Medicos.Add(medico);
                MessageBox.Show("Médico Creado Correctamente\n" + medico.ToString());
            }
            else if(Medico == false && PersonalAdminstrativo == false)
            {
                if (!ValidacionTextBox(new List<System.Windows.Forms.TextBox> { textBoxNombre, textBoxDni, textBoxTelefono, textBoxMedico, textBoxSintomas }))
                    return;

                Medico medicoExistente = hospital.Medicos.FirstOrDefault(m => m.Nombre.Equals(textBoxMedico.Text, StringComparison.Ordinal));

                if (medicoExistente == null)
                {
                    MessageBox.Show("El médico introducido no existe.");
                    return;
                }

                Paciente paciente = new Paciente(textBoxNombre.Text, textBoxDni.Text, textBoxTelefono.Text, medicoExistente, textBoxSintomas.Text);
                hospital.Pacientes.Add(paciente);
                MessageBox.Show("Paciente Creado Correctamente\n" + paciente.ToString());
            }
            else
            {
                if (!ValidacionTextBox(new List<System.Windows.Forms.TextBox> { textBoxNombre, textBoxDni, textBoxTelefono }))
                    return;

                PersonalAdministrativo personal = new PersonalAdministrativo(textBoxNombre.Text, textBoxDni.Text, textBoxTelefono.Text);
                hospital.PersonalAdministrativos.Add(personal);
                MessageBox.Show("Personal Administrativo Creado Correctamente\n" + personal.ToString());
            }

            Close();
        }

        private bool ValidacionTextBox(List<System.Windows.Forms.TextBox> textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show($"El campo de texto '{textBox.Name.Substring(7)}' está vacío o contiene solo espacios en blanco.");
                    return false;
                }
            }
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Medico == true && PersonalAdminstrativo == false)
            {
                this.labelAltaPaciente.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
            }
            else if(Medico == false && PersonalAdminstrativo == false) 
            {
                this.labelAltaMedico.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
            }
            else
            {
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
            }

            
        }
    }
}
