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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();
            DataTable tablaUsuarios = objUsuario.getData();
            foreach (DataRow usuario in tablaUsuarios.Rows) 
            {
                dgvReportes.Rows.Add(usuario["Nombre"]);
            }
        }
    }
}
