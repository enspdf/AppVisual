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
    public partial class PreguntasCheckbox : Form
    {
        public PreguntasCheckbox()
        {
            InitializeComponent();
            this.CenterToScreen();
        }     

        private clEncuesta objencuesta_seccion2 = new clEncuesta();

        public PreguntasCheckbox(clEncuesta encuesta)
        {
            InitializeComponent();
            objencuesta_seccion2 = encuesta;
            this.CenterToScreen();

            List<string> listaRespuestas2 = objencuesta_seccion2.NombreControRptaS2;
            if (listaRespuestas2 != null)
            {
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        string nomcontrol = "chk" + i.ToString() + "_" + j.ToString();
                        Control[] controles = this.Controls.Find(nomcontrol, true);

                        if (null != controles && controles.Count() > 0)
                        {
                            if (controles[0] is CheckBox)
                            {
                                CheckBox chk = (CheckBox)controles[0];


                                for (int a = 0; a < listaRespuestas2.Count; a++)
                                {
                                    if (nomcontrol == listaRespuestas2[a])
                                    {
                                        chk.Checked = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            PreguntasRadiobutton preg1 = new PreguntasRadiobutton(objencuesta_seccion2);
            preg1.Show();
            this.Close();
            
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
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomControl = "chk" + i.ToString() + "_" + j.ToString();
                    Control[] control = this.Controls.Find(nomControl, true);
                    if (control != null && control.Count()>0)
                    {
                        if (control[0] is CheckBox)
                        {
                            CheckBox ch = ((CheckBox)control[0]);
                            if (ch.Checked==true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }
            objencuesta_seccion2.NombreControRptaS2 = misrpta;
            PreguntasLibre preg = new PreguntasLibre(objencuesta_seccion2);
            preg.Show();
            this.Close();
            
        }
    }
}
