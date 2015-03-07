using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AplicacionEncuestas
{
    public partial class InformacionBasica : Form
    {
        public InformacionBasica()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtEdad.Text = (DateTime.Today.AddTicks(- dtFecha_Nacimiento.Value.Ticks).Year - 1).ToString();
            }
            catch (Exception)
            {
                
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text == "" && txtApellidos.Text == "" && txtEdad.Text.Length >= 0 && cbCiudad.Text == "" && txtIdentificacion.Text=="")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                StreamWriter archivo = new StreamWriter("Guardado.txt");
                //archivo.Write("Nombre: ");
                archivo.Write(txtNombre.Text + System.Environment.NewLine);
                //archivo.Write("Apellidos: ");
                archivo.Write(txtApellidos.Text + System.Environment.NewLine );
                //archivo.Write("Ciudad: ");
                //archivo.Write("Nº Identificacion: ");
                archivo.Write(txtIdentificacion.Text + System.Environment.NewLine);
                archivo.Write(dtFecha_Nacimiento.Text + System.Environment.NewLine);
                archivo.Write(cbCiudad.Text + System.Environment.NewLine);
                //archivo.Write("Edad: ");
                //archivo.Write(txtEdad.Text + System.Environment.NewLine);
                //archivo.Write("Pregrado: ");
                //archivo.Write(chklbPregrado.Text + System.Environment.NewLine);

                archivo.Close();
                
                MessageBox.Show("Datos Guardados Correctamente");
                PreguntasRadiobutton preguntas = new PreguntasRadiobutton();
                preguntas.Show();
                this.Close();
            }
        }
    }
}
