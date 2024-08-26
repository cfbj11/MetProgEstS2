using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAPP.clase;

namespace MyApps1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = tbNombre.Text;
            persona.FechaNac = dtpFechaNac.Value;
            MessageBox.Show(persona.EvaluarEdad());

        }
    }
}
