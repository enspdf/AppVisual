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
    public partial class frmPadre : Form
    {
        public frmPadre()
        {
            InitializeComponent();
        }

        private void informacionBasicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformacionBasica preg = new InformacionBasica();
            preg.MdiParent = this;
            preg.Show();
            
            
        }

        private void encuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreguntasRadiobutton preg = new PreguntasRadiobutton();
            preg.MdiParent = this;
            preg.Show();
            this.CenterToScreen();
        }
    }
}
