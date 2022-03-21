using FireSharp.Interfaces;
using FireSharp.Response;
using MetroSet_UI.Controls;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace QuizifyGUI
{
    public partial class CrearPregunta : Form
    {

        string tipoQuizSeleccionado="";
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
            switch (tipoQuizSeleccionado)
            {
               
                case "Tipo Test":
                   
                    break;
                case "Respuesta Abierta":
                    abrirFormHijo(new RespuestaAbierta());
                    break;
                case "Verdadero/Falso":
                    CrearPreguntaVerdaderoFalso();
                    break;
                default:
                    MessageBox.Show("Seleccione el tipo de pregunta y rellénela antes.");
                    break;

            }

        }

        private int ConseguirPuntuacion(string texto) {
            int puntuacion=-1;
            try
            {
                puntuacion = int.Parse(texto);
                if(puntuacion>10 || puntuacion<0) throw new Exception();
            }
            catch{
                MessageBox.Show("Introduce una puntuacion correcta");
            }

            return puntuacion;
        }

        private void Puntuacion_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetRichTextBox1_TextChanged(object sender)
        {

        }

        public void CrearPreguntaVerdaderoFalso()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
            string enunciado = "";
            bool verdaderoOFalso = false;
            int puntuacion = ConseguirPuntuacion(Puntuacion.Text);
            string descripcion = Descripcion.Text;

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
                    if (c.Name == "EnunciadoVerdaderoFalso")
                    {
                        enunciado = ((MetroSetTextBox)c).Text;
                    }

                }
            }

            ConexionFirebaseTemp ConexionFirebase = ConexionFirebaseTemp.getInstancia();
            IFirebaseClient cliente = ConexionFirebase.getCliente();
            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/VerdaderoFalso/");
            int indice = ContarElementosBDD(datosBDD)+1;

            PreguntaVF pregunta = new PreguntaVF("saxdasds", enunciado, "True");


            cliente.Set("Pregunta/VerdaderoFalso/" + indice,pregunta);

            MessageBox.Show("Se ha insertado una pregunta: " + indice);
        }


        private int ContarElementosBDD(FirebaseResponse datosBDD)
        {
            string datos = datosBDD.Body;
            return Regex.Matches(datos, ",{").Count;
        }

        private class PreguntaVF
        {
            private string PathImagen, Pregunta, Respuesta;

            public PreguntaVF(string pathImagen, string pregunta, string respuesta)
            {
                this.PathImagen = pathImagen;
                this.Pregunta = pregunta;
                this.Respuesta = respuesta;
            }
        }
    }
}
