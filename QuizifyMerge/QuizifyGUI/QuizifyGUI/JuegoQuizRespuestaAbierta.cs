using FireSharp.Interfaces;
using FireSharp.Response;
using Quizify.BussinessLogic.Servicios;
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
        QuizifyServices servicio = new QuizifyServices();
        public JuegoQuizRespuestaAbierta(String titulo,int indice)
        {
            InitializeComponent();
            imagenPregunta.SizeMode = PictureBoxSizeMode.StretchImage;

            tituloQuiz.Text = titulo;
            this.indice = indice;
        }

        private void imagenPregunta_Click(object sender, EventArgs e)
        {

        }

        private void JuegoQuizRespuestaAbierta_Load(object sender, EventArgs e)
        {

        }

        private void crearQuiz()
        {
            ConexionFirebaseTemp ConexionFirebase = ConexionFirebaseTemp.getInstancia();
            IFirebaseClient cliente = ConexionFirebase.getCliente();

            FirebaseResponse datosBDD = cliente.Get(@"Quiz/" + indice + "/");

            if (PreguntaActual < servicio.ContarElementosBDD(datosBDD)-2)
            {
                PreguntaActual++;
                FirebaseResponse FBTipoDeQuiz= cliente.Get(@"Quiz/" + indice + "/TipoDeQuiz/");
                //Aqui en vez de un string iria un objeto pregunta, pero antes hay que crear las properties
                string tipoDeQuiz = FBTipoDeQuiz.ResultAs<String>();
                
                FirebaseResponse enunciadoPregunta = cliente.Get(@"Pregunta/" + tipoDeQuiz +"/"+PreguntaActual+ "/Pregunta");
                string enunciadoString = enunciadoPregunta.ResultAs<String>();

                Enunciado.Text = enunciadoString;
            }
        }
    }
}
