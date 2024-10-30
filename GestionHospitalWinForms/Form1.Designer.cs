namespace GestionHospitalWinForms
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
            this.buttonCitas = new System.Windows.Forms.Button();
            this.buttonPersonal = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonTodos = new System.Windows.Forms.Button();
            this.buttonPacientes = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCitas
            // 
            this.buttonCitas.Location = new System.Drawing.Point(147, 3);
            this.buttonCitas.Name = "buttonCitas";
            this.buttonCitas.Size = new System.Drawing.Size(138, 56);
            this.buttonCitas.TabIndex = 1;
            this.buttonCitas.Text = "Citas";
            this.buttonCitas.UseVisualStyleBackColor = true;
            this.buttonCitas.Click += new System.EventHandler(this.buttonCitas_Click);
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.Location = new System.Drawing.Point(3, 3);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(138, 56);
            this.buttonPersonal.TabIndex = 0;
            this.buttonPersonal.Text = "Personal";
            this.buttonPersonal.UseVisualStyleBackColor = true;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // panelContainer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panelContainer, 5);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 114);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1782, 724);
            this.panelContainer.TabIndex = 1;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(3, 65);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(138, 46);
            this.buttonTodos.TabIndex = 8;
            this.buttonTodos.Text = "Todos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            this.buttonTodos.Click += new System.EventHandler(this.buttonTodos_Click);
            // 
            // buttonPacientes
            // 
            this.buttonPacientes.Location = new System.Drawing.Point(147, 65);
            this.buttonPacientes.Name = "buttonPacientes";
            this.buttonPacientes.Size = new System.Drawing.Size(138, 46);
            this.buttonPacientes.TabIndex = 9;
            this.buttonPacientes.Text = "Pacientes";
            this.buttonPacientes.UseVisualStyleBackColor = true;
            this.buttonPacientes.Click += new System.EventHandler(this.buttonPacientes_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.Location = new System.Drawing.Point(291, 65);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Size = new System.Drawing.Size(138, 46);
            this.buttonMedicos.TabIndex = 10;
            this.buttonMedicos.Text = "Medicos";
            this.buttonMedicos.UseVisualStyleBackColor = true;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(435, 65);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(138, 46);
            this.buttonAdmin.TabIndex = 11;
            this.buttonAdmin.Text = "Administrativos";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.buttonCitas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdmin, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelContainer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonPersonal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMedicos, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPacientes, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonTodos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1782, 838);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 838);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCitas;
        private System.Windows.Forms.Button buttonPersonal;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.Button buttonPacientes;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

