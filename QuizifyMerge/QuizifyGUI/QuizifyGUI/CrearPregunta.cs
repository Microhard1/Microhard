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
    public partial class CrearPregunta : Form
    {
        public CrearPregunta()
        {
            InitializeComponent();
        }

        private void abrirFormHijo(object formHijo)
        {
            if (this.PanelCentralPreguntas.Controls.Count > 0)
            {
                this.PanelCentralPreguntas.Controls.RemoveAt(0);
            }
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.PanelCentralPreguntas.Controls.Add(formularioHijo);
            this.PanelCentralPreguntas.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscarPregunta_Click(object sender, EventArgs e)
        {

        }

        private void SelectorTipoQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tipoQuizSeleccionado=SelectorTipoQuiz.SelectedItem.ToString();

            switch (tipoQuizSeleccionado)
            {
                case "Tipo Test":
                    abrirFormHijo(new TipoTest()) ;
                    break;
                case  "Respuesta Abierta":
                    abrirFormHijo(new RespuestaAbierta());
                    break;
                case "Verdadero/Falso":
                    abrirFormHijo(new VerdaderoFalso());
                    break;
                default:
                    Console.WriteLine("No saco nada");
                    break;

            }



        }

        private void PanelCentralPreguntas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
