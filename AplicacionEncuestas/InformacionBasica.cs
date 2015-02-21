using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txtNombre.Text == "" && txtApellidos.Text == "" && txtEdad.Text.Length >= 0 && cbCiudad.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                //PreguntasRadiobutton preguntas = new PreguntasRadiobutton();
                //preguntas.Show();
                MessageBox.Show("Datos Guardados Correctamente");
                this.Close();
            }
        }
    }
}
