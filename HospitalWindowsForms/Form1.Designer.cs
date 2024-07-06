namespace HospitalWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuHospitalLabel = new System.Windows.Forms.Label();
            this.butAltaMedico = new System.Windows.Forms.Button();
            this.seleccionaLabel = new System.Windows.Forms.Label();
            this.butAltaPaciente = new System.Windows.Forms.Button();
            this.butAltaPersonalAdministrativo = new System.Windows.Forms.Button();
            this.butListarMedicos = new System.Windows.Forms.Button();
            this.butListarPacientes = new System.Windows.Forms.Button();
            this.butEliminarPaciente = new System.Windows.Forms.Button();
            this.butListarHospital = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuHospitalLabel
            // 
            this.MenuHospitalLabel.AutoSize = true;
            this.MenuHospitalLabel.Location = new System.Drawing.Point(373, 55);
            this.MenuHospitalLabel.Name = "MenuHospitalLabel";
            this.MenuHospitalLabel.Size = new System.Drawing.Size(93, 16);
            this.MenuHospitalLabel.TabIndex = 0;
            this.MenuHospitalLabel.Text = "Menu Hospital";
            // 
            // butAltaMedico
            // 
            this.butAltaMedico.Location = new System.Drawing.Point(55, 173);
            this.butAltaMedico.Name = "butAltaMedico";
            this.butAltaMedico.Size = new System.Drawing.Size(245, 51);
            this.butAltaMedico.TabIndex = 1;
            this.butAltaMedico.Text = "Dar de alta a un medico";
            this.butAltaMedico.UseVisualStyleBackColor = true;
            this.butAltaMedico.Click += new System.EventHandler(this.butAltaMedico_Click);
            // 
            // seleccionaLabel
            // 
            this.seleccionaLabel.AutoSize = true;
            this.seleccionaLabel.Location = new System.Drawing.Point(98, 111);
            this.seleccionaLabel.Name = "seleccionaLabel";
            this.seleccionaLabel.Size = new System.Drawing.Size(202, 16);
            this.seleccionaLabel.TabIndex = 2;
            this.seleccionaLabel.Text = "Selecciona una de las opciones:";
            // 
            // butAltaPaciente
            // 
            this.butAltaPaciente.Location = new System.Drawing.Point(55, 243);
            this.butAltaPaciente.Name = "butAltaPaciente";
            this.butAltaPaciente.Size = new System.Drawing.Size(245, 51);
            this.butAltaPaciente.TabIndex = 3;
            this.butAltaPaciente.Text = "Dar de alta a un paciente";
            this.butAltaPaciente.UseVisualStyleBackColor = true;
            this.butAltaPaciente.Click += new System.EventHandler(this.butAltaPaciente_Click);
            // 
            // butAltaPersonalAdministrativo
            // 
            this.butAltaPersonalAdministrativo.Location = new System.Drawing.Point(55, 318);
            this.butAltaPersonalAdministrativo.Name = "butAltaPersonalAdministrativo";
            this.butAltaPersonalAdministrativo.Size = new System.Drawing.Size(248, 51);
            this.butAltaPersonalAdministrativo.TabIndex = 4;
            this.butAltaPersonalAdministrativo.Text = "Dar de alta a personal administrativo";
            this.butAltaPersonalAdministrativo.UseVisualStyleBackColor = true;
            this.butAltaPersonalAdministrativo.Click += new System.EventHandler(this.butAltaPersonalAdministrativo_Click);
            // 
            // butListarMedicos
            // 
            this.butListarMedicos.Location = new System.Drawing.Point(468, 173);
            this.butListarMedicos.Name = "butListarMedicos";
            this.butListarMedicos.Size = new System.Drawing.Size(228, 51);
            this.butListarMedicos.TabIndex = 5;
            this.butListarMedicos.Text = "Listar medicos";
            this.butListarMedicos.UseVisualStyleBackColor = true;
            this.butListarMedicos.Click += new System.EventHandler(this.butListarMedicos_Click);
            // 
            // butListarPacientes
            // 
            this.butListarPacientes.Location = new System.Drawing.Point(468, 243);
            this.butListarPacientes.Name = "butListarPacientes";
            this.butListarPacientes.Size = new System.Drawing.Size(228, 51);
            this.butListarPacientes.TabIndex = 6;
            this.butListarPacientes.Text = "Listar pacientes de un medico determinado";
            this.butListarPacientes.UseVisualStyleBackColor = true;
            this.butListarPacientes.Click += new System.EventHandler(this.butListarPacientes_Click);
            // 
            // butEliminarPaciente
            // 
            this.butEliminarPaciente.Location = new System.Drawing.Point(468, 318);
            this.butEliminarPaciente.Name = "butEliminarPaciente";
            this.butEliminarPaciente.Size = new System.Drawing.Size(228, 51);
            this.butEliminarPaciente.TabIndex = 7;
            this.butEliminarPaciente.Text = "Eliminar un paciente";
            this.butEliminarPaciente.UseVisualStyleBackColor = true;
            this.butEliminarPaciente.Click += new System.EventHandler(this.butEliminarPaciente_Click);
            // 
            // butListarHospital
            // 
            this.butListarHospital.Location = new System.Drawing.Point(235, 409);
            this.butListarHospital.Name = "butListarHospital";
            this.butListarHospital.Size = new System.Drawing.Size(318, 68);
            this.butListarHospital.TabIndex = 8;
            this.butListarHospital.Text = "Listar todas las personas que hay en el hospital";
            this.butListarHospital.UseVisualStyleBackColor = true;
            this.butListarHospital.Click += new System.EventHandler(this.butListarHospital_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 616);
            this.Controls.Add(this.butListarHospital);
            this.Controls.Add(this.butEliminarPaciente);
            this.Controls.Add(this.butListarPacientes);
            this.Controls.Add(this.butListarMedicos);
            this.Controls.Add(this.butAltaPersonalAdministrativo);
            this.Controls.Add(this.butAltaPaciente);
            this.Controls.Add(this.seleccionaLabel);
            this.Controls.Add(this.butAltaMedico);
            this.Controls.Add(this.MenuHospitalLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuHospitalLabel;
        private System.Windows.Forms.Button butAltaMedico;
        private System.Windows.Forms.Label seleccionaLabel;
        private System.Windows.Forms.Button butAltaPaciente;
        private System.Windows.Forms.Button butAltaPersonalAdministrativo;
        private System.Windows.Forms.Button butListarMedicos;
        private System.Windows.Forms.Button butListarPacientes;
        private System.Windows.Forms.Button butEliminarPaciente;
        private System.Windows.Forms.Button butListarHospital;
    }
}

