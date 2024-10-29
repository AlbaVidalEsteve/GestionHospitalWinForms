namespace GestionHospitalWinForms
{
    partial class UpdateMedico
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMostrarDatos = new System.Windows.Forms.Panel();
            this.labelDatos = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelEspecialidad = new System.Windows.Forms.Label();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPacientes = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelLicencia = new System.Windows.Forms.Label();
            this.dataGridViewMedicos = new System.Windows.Forms.DataGridView();
            this.labelMedicos = new System.Windows.Forms.Label();
            this.comboBoxEspcialidad = new System.Windows.Forms.ComboBox();
            this.textBoxLicencia = new System.Windows.Forms.TextBox();
            this.dataGridViewPacientesAsignados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMostrarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesAsignados)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMostrarDatos
            // 
            this.panelMostrarDatos.Controls.Add(this.dataGridViewPacientesAsignados);
            this.panelMostrarDatos.Controls.Add(this.textBoxLicencia);
            this.panelMostrarDatos.Controls.Add(this.comboBoxEspcialidad);
            this.panelMostrarDatos.Controls.Add(this.labelDatos);
            this.panelMostrarDatos.Controls.Add(this.labelNombre);
            this.panelMostrarDatos.Controls.Add(this.textBoxNombre);
            this.panelMostrarDatos.Controls.Add(this.labelApellido);
            this.panelMostrarDatos.Controls.Add(this.textBoxApellido);
            this.panelMostrarDatos.Controls.Add(this.labelEspecialidad);
            this.panelMostrarDatos.Controls.Add(this.labelTelefono);
            this.panelMostrarDatos.Controls.Add(this.textBoxTelefono);
            this.panelMostrarDatos.Controls.Add(this.labelContacto);
            this.panelMostrarDatos.Controls.Add(this.labelEmail);
            this.panelMostrarDatos.Controls.Add(this.labelPacientes);
            this.panelMostrarDatos.Controls.Add(this.textBoxEmail);
            this.panelMostrarDatos.Controls.Add(this.labelLicencia);
            this.panelMostrarDatos.Controls.Add(this.panel1);
            this.panelMostrarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMostrarDatos.Location = new System.Drawing.Point(0, 237);
            this.panelMostrarDatos.Name = "panelMostrarDatos";
            this.panelMostrarDatos.Size = new System.Drawing.Size(1270, 400);
            this.panelMostrarDatos.TabIndex = 31;
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatos.Location = new System.Drawing.Point(23, 23);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(151, 20);
            this.labelDatos.TabIndex = 13;
            this.labelDatos.Text = "Datos Personales";
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Location = new System.Drawing.Point(1177, 17);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(90, 38);
            this.buttonModificar.TabIndex = 27;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(23, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Location = new System.Drawing.Point(21, 17);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(90, 38);
            this.buttonNuevo.TabIndex = 26;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Location = new System.Drawing.Point(27, 80);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(142, 19);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(192, 57);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 20);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApellido.Location = new System.Drawing.Point(196, 80);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(142, 19);
            this.textBoxApellido.TabIndex = 3;
            // 
            // labelEspecialidad
            // 
            this.labelEspecialidad.AutoSize = true;
            this.labelEspecialidad.Location = new System.Drawing.Point(365, 57);
            this.labelEspecialidad.Name = "labelEspecialidad";
            this.labelEspecialidad.Size = new System.Drawing.Size(99, 20);
            this.labelEspecialidad.TabIndex = 4;
            this.labelEspecialidad.Text = "Especialidad";
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Location = new System.Drawing.Point(1081, 17);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(90, 38);
            this.buttonBorrar.TabIndex = 20;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = false;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(745, 57);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(71, 20);
            this.labelTelefono.TabIndex = 6;
            this.labelTelefono.Text = "Teléfono";
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadir.Location = new System.Drawing.Point(135, 17);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(90, 38);
            this.buttonAñadir.TabIndex = 19;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = false;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelefono.Location = new System.Drawing.Point(749, 80);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(142, 19);
            this.textBoxTelefono.TabIndex = 7;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.Location = new System.Drawing.Point(745, 23);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(82, 20);
            this.labelContacto.TabIndex = 8;
            this.labelContacto.Text = "Contacto";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(929, 57);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelPacientes
            // 
            this.labelPacientes.AutoSize = true;
            this.labelPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacientes.Location = new System.Drawing.Point(23, 119);
            this.labelPacientes.Name = "labelPacientes";
            this.labelPacientes.Size = new System.Drawing.Size(88, 20);
            this.labelPacientes.TabIndex = 14;
            this.labelPacientes.Text = "Pacientes";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Location = new System.Drawing.Point(933, 80);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(142, 19);
            this.textBoxEmail.TabIndex = 10;
            // 
            // labelLicencia
            // 
            this.labelLicencia.AutoSize = true;
            this.labelLicencia.Location = new System.Drawing.Point(504, 57);
            this.labelLicencia.Name = "labelLicencia";
            this.labelLicencia.Size = new System.Drawing.Size(143, 20);
            this.labelLicencia.TabIndex = 11;
            this.labelLicencia.Text = "Número de licencia";
            // 
            // dataGridViewMedicos
            // 
            this.dataGridViewMedicos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMedicos.Location = new System.Drawing.Point(0, 49);
            this.dataGridViewMedicos.Name = "dataGridViewMedicos";
            this.dataGridViewMedicos.RowHeadersWidth = 62;
            this.dataGridViewMedicos.RowTemplate.Height = 28;
            this.dataGridViewMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMedicos.Size = new System.Drawing.Size(1270, 188);
            this.dataGridViewMedicos.TabIndex = 30;
            this.dataGridViewMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicos_CellClick);
            // 
            // labelMedicos
            // 
            this.labelMedicos.AutoSize = true;
            this.labelMedicos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicos.Location = new System.Drawing.Point(0, 0);
            this.labelMedicos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelMedicos.Name = "labelMedicos";
            this.labelMedicos.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.labelMedicos.Size = new System.Drawing.Size(225, 49);
            this.labelMedicos.TabIndex = 29;
            this.labelMedicos.Text = "Portal de médicos";
            // 
            // comboBoxEspcialidad
            // 
            this.comboBoxEspcialidad.AutoCompleteCustomSource.AddRange(new string[] {
            "Cardiología",
            "General",
            "Neumología",
            "Neurología",
            "Dermatología",
            "Pediatría"});
            this.comboBoxEspcialidad.FormattingEnabled = true;
            this.comboBoxEspcialidad.Location = new System.Drawing.Point(369, 80);
            this.comboBoxEspcialidad.Name = "comboBoxEspcialidad";
            this.comboBoxEspcialidad.Size = new System.Drawing.Size(121, 28);
            this.comboBoxEspcialidad.TabIndex = 28;
            // 
            // textBoxLicencia
            // 
            this.textBoxLicencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLicencia.Location = new System.Drawing.Point(505, 83);
            this.textBoxLicencia.Name = "textBoxLicencia";
            this.textBoxLicencia.Size = new System.Drawing.Size(142, 19);
            this.textBoxLicencia.TabIndex = 29;
            // 
            // dataGridViewPacientesAsignados
            // 
            this.dataGridViewPacientesAsignados.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewPacientesAsignados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPacientesAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacientesAsignados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPacientesAsignados.Location = new System.Drawing.Point(0, 164);
            this.dataGridViewPacientesAsignados.Name = "dataGridViewPacientesAsignados";
            this.dataGridViewPacientesAsignados.RowHeadersWidth = 62;
            this.dataGridViewPacientesAsignados.RowTemplate.Height = 28;
            this.dataGridViewPacientesAsignados.Size = new System.Drawing.Size(1270, 169);
            this.dataGridViewPacientesAsignados.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNuevo);
            this.panel1.Controls.Add(this.buttonAñadir);
            this.panel1.Controls.Add(this.buttonBorrar);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 67);
            this.panel1.TabIndex = 31;
            // 
            // UpdateMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panelMostrarDatos);
            this.Controls.Add(this.dataGridViewMedicos);
            this.Controls.Add(this.labelMedicos);
            this.Name = "UpdateMedico";
            this.Size = new System.Drawing.Size(1270, 637);
            this.Load += new System.EventHandler(this.UpdateMedico_Load);
            this.panelMostrarDatos.ResumeLayout(false);
            this.panelMostrarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacientesAsignados)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMostrarDatos;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelEspecialidad;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPacientes;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelLicencia;
        private System.Windows.Forms.DataGridView dataGridViewMedicos;
        private System.Windows.Forms.Label labelMedicos;
        private System.Windows.Forms.ComboBox comboBoxEspcialidad;
        private System.Windows.Forms.TextBox textBoxLicencia;
        private System.Windows.Forms.DataGridView dataGridViewPacientesAsignados;
        private System.Windows.Forms.Panel panel1;
    }
}
