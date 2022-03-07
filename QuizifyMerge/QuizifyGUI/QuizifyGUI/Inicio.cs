using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizifyGUI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void abrirFormHijo(object formHijo)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(formularioHijo);
            this.PanelPrincipal.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
               this.PanelPrincipal.Controls.RemoveAt(0);
            }
        }

        private void metroSetBadge1_Click(object sender, EventArgs e)
        {

        }

        private void BotonCrearPregunta_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CrearPregunta());
        }

        private void BotonCrearQuiz_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new CrearQuiz());
        }

        private void BotonRealizarQuiz_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new RealizarQuiz());
        }

        private void BotonEstadisticas_Click(object sender, EventArgs e)
        {
            abrirFormHijo(new Estadisticas());
        }

        private void BotonAjustes_Click(object sender, EventArgs e)
        {

        }

        private void NavbarSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NavbarIzquierda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
