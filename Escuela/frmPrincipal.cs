using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestiònDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos Alumnos = new frmAlumnos();
            Alumnos.ShowDialog();
        }

        private void gestiònDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas Notas = new frmNotas();
            Notas.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudades = new frmCiudades();
            ciudades.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignaturas asignaturas = new frmAsignaturas();
            asignaturas.Show();
        }

        private void tiposDeExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTiposExamen tiposExamen = new frmTiposExamen();
            tiposExamen.Show();
        }

        private void listadoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnosLista frmAlumnosLista = new frmAlumnosLista();
            frmAlumnosLista.Show();
        }

        private void notasDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotasAlumno frmNotasAlumno = new frmNotasAlumno();
            frmNotasAlumno.Show();
        }

        private void listaDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotasLista frmNotasLista = new frmNotasLista();
            frmNotasLista.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
