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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtPassword.Text == "admin")
            {
                //MessageBox.Show("Bienvenido");
                frmPadre info = new frmPadre();
                info.Show();
                this.Hide();
            }
            else if (txtLogin.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Error, debe llenar todos los campos", "Error", MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show("Error al iniciar al iniciar sesión", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
