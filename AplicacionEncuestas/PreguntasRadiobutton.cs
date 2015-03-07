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
    public partial class PreguntasRadiobutton : Form
    {
        public PreguntasRadiobutton()
        {
            InitializeComponent();
            this.CenterToScreen();
            objEncuesta_seccion1 = new clEncuesta();
        }

        private clEncuesta objEncuesta_seccion1 = new clEncuesta();
        public int RespuestasCorrectas = 0;
        public int RespuestasErroneas = 0;
        public int RE;
        public int RC;

        //public PreguntasRadiobutton(clEncuesta report)
        //{
          //  InitializeComponent();
          //  objEncuesta_seccion1 = report;
          //  List<string> Finalizacion = objEncuesta_seccion1.Info;
            
        //}


        public PreguntasRadiobutton(clEncuesta objEncuesta)
        {
            InitializeComponent();
            objEncuesta_seccion1 = objEncuesta;
            this.CenterToScreen();

            List<string> listaRespuestas = objEncuesta_seccion1.NombresControlesRptaS1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomcontrol = "rb" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomcontrol, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];

                            for (int y = 0; y < listaRespuestas.Count; y++)
                            {
                                if (nomcontrol ==  listaRespuestas[y])
                                {
                                    rd.Checked = true;
                                }
                            }
                            //for (int q = 0; q <= 4; q++)
                            //{
                              //  if (nomcontrol == listaRespuestas[q])
                                //{
                                  //  RespuestasCorrectas++;
                                //}
                                //else
                                //{
                                  //  RespuestasErroneas++;
                                //}
                            //}
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clEncuesta encuesta = new clEncuesta();
            List<string>mirspt=new List<string>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    string nomcontrol = "rb" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomcontrol, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];
                            if (rd.Checked == true)
                            {
                                mirspt.Add(nomcontrol);
                            }
                        }
                    }
                }                
            }
            objEncuesta_seccion1.NombresControlesRptaS1 = mirspt;
            if (rb1_1.Checked == true)
            {
                RespuestasCorrectas++;
            }
            else if (rb1_2.Checked == true || rb1_3.Checked == true || rb1_4.Checked == true)
            {
                RespuestasErroneas++;
            }
            if (rb2_2.Checked == true)
            {
                RespuestasCorrectas++;
            }
            else if (rb2_1.Checked == true || rb2_3.Checked == true || rb2_4.Checked == true)
            {
                RespuestasErroneas++;
            }
            if (rb3_4.Checked == true)
            {
                RespuestasCorrectas++;
            }
            else if (rb3_1.Checked == true || rb3_2.Checked == true || rb3_3.Checked == true)
            {
                RespuestasErroneas++;
            }
            if (rb4_1.Checked == true)
            {
                RespuestasCorrectas++;
            }
            else if (rb4_2.Checked == true || rb4_3.Checked == true || rb4_4.Checked == true)
            {
                RespuestasErroneas++;
            }
            if (RespuestasCorrectas >= 0 || RespuestasErroneas >= 0 || RespuestasCorrectas >= 0 && RespuestasErroneas >= 0)
            {
                StreamWriter escritorbuenas = new StreamWriter("buenas1.txt");
                StreamWriter escritormalas = new StreamWriter("malas1.txt");
                

                escritorbuenas.Write(RespuestasCorrectas + System.Environment.NewLine);
                escritormalas.Write(RespuestasErroneas + System.Environment.NewLine);

                escritorbuenas.Close();
                escritormalas.Close();
            }

            RC = RespuestasCorrectas;
            RE = RespuestasErroneas;

            
            
            
            MessageBox.Show("Correctas: " + RC + " - " + "Erroneas: " + RE);
            PreguntasCheckbox preg = new PreguntasCheckbox(objEncuesta_seccion1);
            preg.Show();
            this.Close();
            

        }

        private void txtSeleccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            InformacionBasica info = new InformacionBasica();
            info.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
    }
}
