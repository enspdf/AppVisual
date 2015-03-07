namespace AplicacionEncuestas
{
    partial class InformacionBasica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.dtFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chklbPregrado = new System.Windows.Forms.CheckedListBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos Completos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "¡Seleccione el/los pregrado que esta cursando!";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(138, 96);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(208, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // dtFecha_Nacimiento
            // 
            this.dtFecha_Nacimiento.Location = new System.Drawing.Point(138, 155);
            this.dtFecha_Nacimiento.Name = "dtFecha_Nacimiento";
            this.dtFecha_Nacimiento.Size = new System.Drawing.Size(208, 20);
            this.dtFecha_Nacimiento.TabIndex = 8;
            this.dtFecha_Nacimiento.ValueChanged += new System.EventHandler(this.dtFecha_Nacimiento_ValueChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Medellin",
            "Bogota",
            "Cali",
            "Cartagena",
            "Barranquilla",
            "Pasto"});
            this.cbCiudad.Location = new System.Drawing.Point(138, 190);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(208, 21);
            this.cbCiudad.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Enabled = false;
            this.txtEdad.Location = new System.Drawing.Point(138, 223);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(208, 20);
            this.txtEdad.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "INFORMACIÓN BASICA";
            // 
            // chklbPregrado
            // 
            this.chklbPregrado.FormattingEnabled = true;
            this.chklbPregrado.Items.AddRange(new object[] {
            "Ingenieria de Sistemas ",
            "Licenciatura en Ingles",
            "Psicologia",
            "Gastronomia",
            "Negocios Internacionales"});
            this.chklbPregrado.Location = new System.Drawing.Point(15, 293);
            this.chklbPregrado.Name = "chklbPregrado";
            this.chklbPregrado.Size = new System.Drawing.Size(331, 79);
            this.chklbPregrado.TabIndex = 12;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(146, 381);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Guardar";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nº Identificacón:";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(138, 124);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(208, 20);
            this.txtIdentificacion.TabIndex = 15;
            // 
            // InformacionBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 408);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.chklbPregrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.dtFecha_Nacimiento);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InformacionBasica";
            this.Text = "Información Basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.DateTimePicker dtFecha_Nacimiento;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chklbPregrado;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdentificacion;
    }
}