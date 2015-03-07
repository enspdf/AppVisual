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
    public partial class PreguntasCheckbox : Form
    {
        public PreguntasCheckbox()
        {
            InitializeComponent();
            this.CenterToScreen();
        }     

        private clEncuesta objencuesta_seccion2 = new clEncuesta();
        public int RespuestasCorrectas2 = 0;
        public int RespuestasErroneas2 = 0;

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
            PreguntasRadiobutton rb = new PreguntasRadiobutton();
            if (chk1_1.Checked == true || chk1_2.Checked == true || chk1_1.Checked == true && chk1_2.Checked == true && chk1_3.Checked == false && chk1_4.Checked == false)
            {
                //rb.RC++;
                RespuestasCorrectas2++;
            }
            else if (chk1_3.Checked == true || chk1_4.Checked == true && chk1_1.Checked == false && chk1_2.Checked == false)
            {
                //rb.RE++;
                RespuestasErroneas2++;
            }
            if (chk2_2.Checked == true || chk2_3.Checked == true || chk2_2.Checked == true && chk2_3.Checked == true)
            {
                //rb.RC++;
                RespuestasCorrectas2++;
            }
            else if (chk2_1.Checked == true || chk2_4.Checked == true)
            {
                //rb.RE++;
                RespuestasErroneas2++;
            }
            if (chk3_1.Checked == true || chk3_2.Checked == true || chk3_1.Checked == true && chk3_2.Checked == true)
            {
                //rb.RC++;
                RespuestasCorrectas2++;
            }
            else if (chk3_3.Checked == true || chk3_4.Checked == true)
            {
                //rb.RE++;
                RespuestasErroneas2++;
            }
            if (chk4_1.Checked == true || chk4_2.Checked == true || chk4_1.Checked == true && chk4_2.Checked == true)
            {
                //rb.RC++;
                RespuestasCorrectas2++;
            }
            else if (chk4_3.Checked == true || chk4_4.Checked == true)
            {
                //rb.RE++;
                RespuestasErroneas2++;
            }
            if (RespuestasCorrectas2 >= 0 || RespuestasErroneas2 >= 0 || RespuestasCorrectas2 >= 0 && RespuestasErroneas2 >= 0)
            {
                StreamWriter escritorbuenas = new StreamWriter("buenas2.txt");
                StreamWriter escritormalas = new StreamWriter("malas2.txt");
                

                escritorbuenas.Write(RespuestasCorrectas2 + System.Environment.NewLine);
                escritormalas.Write(RespuestasErroneas2 + System.Environment.NewLine);

                escritorbuenas.Close();
                escritormalas.Close();
            }

            MessageBox.Show("Correctas: " + RespuestasCorrectas2 + " - " + "Erroneas: " + RespuestasErroneas2);
            objencuesta_seccion2.NombreControRptaS2 = misrpta;
            PreguntasLibre preg = new PreguntasLibre(objencuesta_seccion2);
            preg.Show();
            this.Close();
            
        }
    }
}
