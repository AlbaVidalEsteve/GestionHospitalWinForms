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
            this.btn_anadir_persona = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonTodos);
            this.flowLayoutPanel1.Controls.Add(this.buttonPacientes);
            this.flowLayoutPanel1.Controls.Add(this.buttonMedicos);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdmin);
            this.flowLayoutPanel1.Controls.Add(this.btn_anadir_persona);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(911, 421);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(3, 3);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(138, 29);
            this.buttonTodos.TabIndex = 8;
            this.buttonTodos.Text = "Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Location = new System.Drawing.Point(147, 3);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(138, 29);
            this.buttonPacientes.TabIndex = 9;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.UseVisualStyleBackColor = true;
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.Location = new System.Drawing.Point(291, 3);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Size = new System.Drawing.Size(138, 29);
            this.buttonMedicos.TabIndex = 10;
            this.buttonMedicos.Text = "Medicos";
            this.buttonMedicos.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(435, 3);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(138, 29);
            this.buttonAdmin.TabIndex = 11;
            this.buttonAdmin.Text = "Administrativos";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // btn_anadir_persona
            // 
            this.btn_anadir_persona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_anadir_persona.Location = new System.Drawing.Point(579, 3);
            this.btn_anadir_persona.Name = "btn_anadir_persona";
            this.btn_anadir_persona.Size = new System.Drawing.Size(75, 29);
            this.btn_anadir_persona.TabIndex = 7;
            this.btn_anadir_persona.Text = "Añadir";
            this.btn_anadir_persona.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(720, 114);
            this.dataGridView1.TabIndex = 6;
            // 
            // GestionPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "GestionPersonas";
            this.Size = new System.Drawing.Size(911, 421);
            this.Load += new System.EventHandler(this.GestionPersonas_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button btn_anadir_persona;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
