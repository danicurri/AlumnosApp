using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vueling.Common.Logic.Model;

namespace Vueling.Presentation.WinSite
{
    public partial class AlumnoForm : Form
    {
        private Alumno alumno;
        private IAlumnoBL alumnoBL;

        public AlumnoForm()
        {
            InitializeComponent();
            alumno = new Alumno();
            alumnoBL = new AlumnoBL();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Text);
        }

        private void btnJson_Click(object sender, EventArgs e)

        private void LoadAlumnoData()
        {
            alumno.IdAlumno = Convert.ToInt32(txtId.text);
            alumno.Nombre = txtNombre.text;
        }
    }
}
