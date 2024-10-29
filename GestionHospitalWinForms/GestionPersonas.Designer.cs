namespace GestionHospitalWinForms
{
    partial class GestionPersonas
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTodos = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.buttonTodos);
            this.flowLayoutPanel1.Controls.Add(this.buttonPacientes);
            this.flowLayoutPanel1.Controls.Add(this.buttonMedicos);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdmin);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1267, 49);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(3, 3);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(138, 46);
            this.buttonTodos.TabIndex = 8;
            this.buttonTodos.Text = "Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            this.buttonTodos.Click += new System.EventHandler(this.buttonTodos_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Location = new System.Drawing.Point(147, 3);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(138, 46);
            this.buttonPacientes.TabIndex = 9;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.Location = new System.Drawing.Point(291, 3);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Size = new System.Drawing.Size(138, 46);
            this.buttonMedicos.TabIndex = 10;
            this.buttonMedicos.Text = "Medicos";
            this.buttonMedicos.UseVisualStyleBackColor = true;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(435, 3);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(138, 46);
            this.buttonAdmin.TabIndex = 11;
            this.buttonAdmin.Text = "Administrativos";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // panelUpdate
            // 
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpdate.Location = new System.Drawing.Point(0, 52);
            this.panelUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(1267, 490);
            this.panelUpdate.TabIndex = 12;
            // 
            // GestionPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelUpdate);
            this.Name = "GestionPersonas";
            this.Size = new System.Drawing.Size(1267, 542);
            this.Load += new System.EventHandler(this.GestionPersonas_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Panel panelUpdate;
    }
}
