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
    public partial class PreguntasCalificacion : Form
    {
        public PreguntasCalificacion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private clEncuesta objEncuesta_seccion4 = new clEncuesta();
        public PreguntasCalificacion(clEncuesta objEncuesta)
        {
            InitializeComponent();
            objEncuesta_seccion4 = objEncuesta;
        }

        private void PreguntasCalificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PreguntasLibre preg = new PreguntasLibre();
            preg.Show();
            this.Hide();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            clEncuesta encuesta = new clEncuesta();
            List<string> misrpta = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomControl = "rbS" + i.ToString() + "_" + j.ToString();
                    Control[] control = this.Controls.Find(nomControl, true);
                    if (control != null && control.Count()>0)
                    {
                        if (control[0] is RadioButton)
                        {
                            RadioButton rd = ((RadioButton)control[0]);
                            if (rd.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }
            objEncuesta_seccion4.NombreControRptasS4 = misrpta;
            //Application.Exit();
        }
    }
}
