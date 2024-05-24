using pryInicioSesionLogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Clientes
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        clsUsuario objUsuario = new clsUsuario();

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin")
            {
                if (txtContraseña.Text == "admin")
                {
                    frmReportes Repor = new frmReportes();
                    Repor.ShowDialog();
                }

            }
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRegistroUsuario.Text != null)
            {
                if (txtRegistroContraseña.Text != null)
                {
                    if (cbArea.SelectedIndex != null)
                    {
                        objUsuario.RegistroLogInicioSesion(txtRegistroUsuario, txtRegistroContraseña, cbArea);
                    }
                }
            }
        }
    }
}
