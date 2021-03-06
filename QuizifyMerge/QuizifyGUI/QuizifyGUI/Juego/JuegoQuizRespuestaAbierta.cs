using FireSharp.Interfaces;
using FireSharp.Response;
using Quizify.BussinessLogic.Clases;
using Quizify.BussinessLogic.Servicios;
using QuizifyLibrary.Persistencia;
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
    public partial class JuegoQuizRespuestaAbierta : Form
    {
        int indice;
        int PreguntaActual = 0;
        int elementosBDD;
        int nota=0;
        QuizifyServices servicio;
        ConexionFirebase ConexionFirebase;
        IFirebaseClient cliente;
        Alumno alumno = new Alumno("Paco", "1234");
        Quiz quizActual;
        public JuegoQuizRespuestaAbierta(String titulo,int indice)
        {
            InitializeComponent();
            imagenPregunta.SizeMode = PictureBoxSizeMode.StretchImage;
            ProgresoQuiz.BorderColor = Color.Black;
            tituloQuiz.Text = titulo;
            this.indice = indice;

            ConexionFirebase = ConexionFirebase.getInstancia();
            cliente = ConexionFirebase.client;
            servicio = new QuizifyServices();
            FirebaseResponse datosBDD = cliente.Get(@"Quiz/" + indice + "/");
            elementosBDD = servicio.contarPreguntasQuiz(datosBDD);

            CrearPregunta();
        }

        private void imagenPregunta_Click(object sender, EventArgs e)
        {

        }

        private void JuegoQuizRespuestaAbierta_Load(object sender, EventArgs e)
        {

        }

        private void CrearPregunta()
        {
            if (PreguntaActual < elementosBDD)
            {
                PreguntaActual++;
                FirebaseResponse FBTipoDeQuiz= cliente.Get(@"Quiz/" + indice + "/TipoDeQuiz/");
                string tipoDeQuizResp = FBTipoDeQuiz.Body.ToString();
                string tipoDeQuiz = tipoDeQuizResp.Substring(1,tipoDeQuizResp.Length-2);

                FirebaseResponse enunciadoPregunta = cliente.Get(@"Pregunta/" + tipoDeQuiz +"/"+PreguntaActual+ "/Pregunta");
                string enunciadoResp = enunciadoPregunta.Body.ToString();
                string enunciado = enunciadoResp.Substring(1, enunciadoResp.Length - 2);

                
                Enunciado.Text = enunciado;
            }

            else
            {
                ProgresoQuiz.Value = 100;
                var result = MessageBox.Show("Enhorabuena, tu nota es un: "+ nota, "Nota final del test",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                Calificacion c;
                if(result==DialogResult.OK)
                {
                    this.Close();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (comprobarRespuestaAbierta()) {
                nota += 5;
            }
            textBoxRespuesta.Clear();
            CrearPregunta();

            ProgresoQuiz.Value += progresoBarra();
            Cursor.Current = Cursors.Default;
        }

        private bool comprobarRespuestaAbierta() {
            FirebaseResponse respuestaFB = cliente.Get(@"Pregunta/Abierta"+ "/" + PreguntaActual + "/Respuesta");
            string respuesta = respuestaFB.Body.ToString();
            string respuestaString = respuesta.Substring(1, respuesta.Length - 2);

            return textBoxRespuesta.Text.Contains(respuestaString);
        }

        private void ProgresoQuiz_ValueChanged(object sender)
        {

        }

        public int progresoBarra()
        {
            return 100 / elementosBDD;
        }
    }
}
