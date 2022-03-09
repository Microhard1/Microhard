using MetroSet_UI.Controls;
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

        String tipoQuizSeleccionado="";
        Form FormularioActual = null;
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
            FormularioActual = formularioHijo;
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
            tipoQuizSeleccionado=SelectorTipoQuiz.SelectedItem.ToString();

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

        private void BotonCrearPregunta_Click(object sender, EventArgs e)
        {
            int puntuacion= ConseguirPuntuacion(Puntuacion.Text);
            string descripcion = Descripcion.Text ;

            string enunciado="";
            bool verdaderoOFalso=false;
            

            switch (tipoQuizSeleccionado)
            {
               
                case "Tipo Test":
                   
                    break;
                case "Respuesta Abierta":
                    abrirFormHijo(new RespuestaAbierta());
                    break;
                case "Verdadero/Falso":
                    ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
                    foreach (Control c in objetosDelFormulario)
                    {
                        if (c.GetType() == typeof(RadioButton))
                        {
                            RadioButton aux = (RadioButton)c;
                            if (aux.Name == "BotonFalso")
                            {
                                if (aux.Checked)
                                {
                                    verdaderoOFalso = false;
                                }
                                else
                                {
                                    verdaderoOFalso = true;
                                }
                            }
                        }
                        if (c.GetType() == typeof(MetroSetTextBox))
                        {
                            if(c.Name== "EnunciadoVerdaderoFalso") {
                                enunciado = ((MetroSetTextBox)c).Text;
                            }
                           
                        }
                    }
                    MessageBox.Show("Pregunta creada" + "\n Enunciado " + enunciado + "\n Puntuacion " + puntuacion +
                            "\n Descripcion " + descripcion + "\n Respuesta " + verdaderoOFalso);
                    break;
                default:
                    MessageBox.Show("Seleccione el tipo de pregunta y rellénela antes.");
                    break;

            }

        }

        private int ConseguirPuntuacion(String texto) {
            int puntuacionAux=-1;
            try
            {
                puntuacionAux = int.Parse(texto);
                if(puntuacionAux>10 || puntuacionAux<0) throw new Exception();
            }
            catch{
                MessageBox.Show("Introduce una puntuacion correcta");
            }

            return puntuacionAux;
        }

        private void Puntuacion_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetRichTextBox1_TextChanged(object sender)
        {

        }
    }
}
