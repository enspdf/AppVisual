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
    public partial class PreguntasRadiobutton : Form
    {
        public PreguntasRadiobutton()
        {
            InitializeComponent();
            this.CenterToScreen();
            objEncuesta_seccion1 = new clEncuesta();
        }

        private clEncuesta objEncuesta_seccion1 = new clEncuesta();

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
            this.Hide();
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
