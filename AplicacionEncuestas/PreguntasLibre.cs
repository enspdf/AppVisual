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
    public partial class PreguntasLibre : Form
    {
        public PreguntasLibre()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private clEncuesta objEncuesta_seccion3 = new clEncuesta();
        
        public PreguntasLibre(clEncuesta objEncuesta)
        {
            InitializeComponent();
            objEncuesta_seccion3 = objEncuesta;
            List<string> listaRespuestas3 = objEncuesta_seccion3.NombreControlRptasS3;
            if (listaRespuestas3 != null)
            {
                for (int i = 1; i <= 4; i++)
                {
                    string nomControl = "txtRpta" + i.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);
                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is TextBox)
                        {
                            TextBox txt = (TextBox)controles[0];
                            for (int y = 0; y < listaRespuestas3.Count; y++)
                            {
                                //txt.Text == "";
                                
                                
                            }
                        }
                    }
                }
            }
        }

        private void PreguntasLibre_Load(object sender, EventArgs e)
        {

        }

        private void bu1tton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PreguntasCheckbox preg2 = new PreguntasCheckbox(objEncuesta_seccion3);
            preg2.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            List<string> misrpta = new List<string>();
            for (int i = 1; i <=4; i++)
            {
                string nomControl = "txtRpta" + i.ToString();
                Control[] vControl = this.Controls.Find(nomControl, true);

                if (vControl != null && vControl.Count()>0)
                {
                    if (vControl[0] is TextBox)
                    {
                        TextBox text = ((TextBox)vControl[0]);
                        if (text.Text != "")
                        {
                            misrpta.Add(text.Text);
                        }
                    }
                }
            }
            objEncuesta_seccion3.NombreControlRptasS3 = misrpta;
            PreguntasCalificacion preg = new PreguntasCalificacion(objEncuesta_seccion3);
            preg.Show();
            //this.Hide();
            this.Close();
        }
    }
}
