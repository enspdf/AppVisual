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
    public partial class FrmReporte : Form
    {
        
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void valores ()
        {
            InformacionBasica info = new InformacionBasica();
            //txtNombre.Text = txtNombreI.Text;
        }

        private void txtFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            StreamReader lector = new StreamReader("Guardado.txt");
            txtNombre.Text = lector.ReadLine();
            txtApellido.Text = lector.ReadLine();
            txtIdentificacion.Text = lector.ReadLine();
            txtFecha.Text = lector.ReadLine();
            txtCiudad.Text = lector.ReadLine();
            txtPreguntas.Text = "22 Preguntas Totales, 8 evaluadas";

            StreamReader lec1 = new StreamReader("buenas1.txt");
            int bn1 = int.Parse(lec1.ReadLine());
            StreamReader lec2 = new StreamReader("buenas2.txt");
            int bn2 = int.Parse(lec2.ReadLine());
            StreamReader lec3 = new StreamReader("malas1.txt");
            int ml1 = int.Parse(lec3.ReadLine());
            StreamReader lec4 = new StreamReader("malas2.txt");
            int ml2 = int.Parse(lec4.ReadLine());
            int buenas = bn1 + bn2;
            int malas = ml1 + ml2;
            txtAcertadas.Text = buenas.ToString();
            txtErradas.Text = malas.ToString();
        }
    }
}
