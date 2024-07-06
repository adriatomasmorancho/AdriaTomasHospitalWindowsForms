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
        Boolean FiltarPacientes;
        Boolean EliminarPacientes;
        Hospital hospital;

        public Form2(Boolean Medico, Boolean PersonalAdminstrativo, Boolean FiltarPacientes, Boolean EliminarPacientes, Hospital hospital)
        {
            this.Medico = Medico;
            this.PersonalAdminstrativo = PersonalAdminstrativo;
            this.FiltarPacientes = FiltarPacientes;
            this.EliminarPacientes=EliminarPacientes;
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
                medicoExistente.Paciente.Add(paciente); 
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

        private void butBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreMedico.Text))
            {
                MessageBox.Show($"El campo de texto '{textBoxNombreMedico.Name.Substring(7)}' está vacío o contiene solo espacios en blanco.");
                return;
            }

            Medico medicoExistente = hospital.Medicos.FirstOrDefault(m => m.Nombre.Equals(textBoxNombreMedico.Text, StringComparison.Ordinal));

            if (medicoExistente == null)
            {
                MessageBox.Show("El médico introducido no existe.");
                return;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var item in medicoExistente.Paciente)
            {
                sb.AppendLine(item.ToString());
            }

            MessageBox.Show(sb.ToString());

            Close();

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show($"El campo de texto '{textBoxNombre.Name.Substring(7)}' está vacío o contiene solo espacios en blanco.");
                return;
            }

            Paciente comprovacionPacienteExistente = hospital.Pacientes.Find(m => m.Nombre.Equals(textBoxNombre.Text, StringComparison.Ordinal));

            if (comprovacionPacienteExistente == null)
            {
                MessageBox.Show("El paciente introducido no existe.");
                return;
            }

            hospital.Pacientes.Remove(comprovacionPacienteExistente);

            foreach (var item in hospital.Medicos)
            {
                item.Paciente.Remove(comprovacionPacienteExistente);
            }

            MessageBox.Show("Paciente " + textBoxNombre.Text + " eliminado correctamente");

            Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Medico == true && PersonalAdminstrativo == false && FiltarPacientes == false && EliminarPacientes == false)
            {
                this.labelAltaPaciente.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
                this.labelEliminarPaciente.Visible = false;
                this.labelNombreMedico.Visible = false;
                this.labelBuscarPacientes.Visible = false;
                this.textBoxNombreMedico.Visible = false;
                this.butEliminar.Visible = false;
                this.butBuscar.Visible = false;
            }
            else if(Medico == false && PersonalAdminstrativo == false && FiltarPacientes == false && EliminarPacientes == false) 
            {
                this.labelAltaMedico.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelEliminarPaciente.Visible = false;
                this.labelNombreMedico.Visible = false;
                this.labelBuscarPacientes.Visible = false;
                this.textBoxNombreMedico.Visible = false;
                this.butEliminar.Visible = false;
                this.butBuscar.Visible = false;
            }
            else if(Medico == false && PersonalAdminstrativo == false && FiltarPacientes == true && EliminarPacientes == false)
            {

                this.labelAltaMedico.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
                this.labelAltaPaciente.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
                this.labelDni.Visible = false;
                this.textBoxDni.Visible = false;
                this.labelTelefono.Visible = false;
                this.textBoxTelefono.Visible = false;
                this.butCrear.Visible = false;
                this.butEliminar.Visible = false;
                this.labelEliminarPaciente.Visible = false;
                this.textBoxNombre.Visible = false;

            }
            else if(Medico == false && PersonalAdminstrativo == false && FiltarPacientes == false && EliminarPacientes == true)
            {
                this.labelAltaMedico.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelEspecialidad.Visible = false;
                this.labelRango.Visible = false;
                this.textBoxEspecialidad.Visible = false;
                this.textBoxRango.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
                this.labelAltaPaciente.Visible = false;
                this.labelAltaPersonalAdministrativo.Visible = false;
                this.labelMedico.Visible = false;
                this.labelSintomas.Visible = false;
                this.textBoxMedico.Visible = false;
                this.textBoxSintomas.Visible = false;
                this.labelDni.Visible = false;
                this.textBoxDni.Visible = false;
                this.labelTelefono.Visible = false;
                this.textBoxTelefono.Visible = false;
                this.butCrear.Visible = false;
                this.butBuscar.Visible = false;
                this.labelBuscarPacientes.Visible = false;
                this.textBoxNombreMedico.Visible = false;
                this.labelNombreMedico.Visible=false;
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
                this.labelEliminarPaciente.Visible=false;
                this.labelNombreMedico.Visible = false;
                this.labelBuscarPacientes.Visible = false;
                this.textBoxNombreMedico.Visible= false;
                this.butEliminar.Visible= false;
                this.butBuscar.Visible = false;
            }

            
        }

       
    }
}
