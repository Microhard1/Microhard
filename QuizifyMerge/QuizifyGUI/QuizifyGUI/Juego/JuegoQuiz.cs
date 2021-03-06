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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizifyLibrary.Persistencia;

namespace QuizifyGUI
{
    public partial class JuegoQuiz : Form
    {
        int count = 0;
        int indice;
        int PreguntaActual = 0;
        int elementosBDD;
        int nota=0;
        
        QuizifyServices servicio = new QuizifyServices();
        ConexionFirebase conexion;

        public JuegoQuiz(String titulo, int indice)
        {
            InitializeComponent();
            tituloQuiz.Text = titulo;
            this.indice = indice;
            conexion = ConexionFirebase.getInstancia();
            FirebaseResponse datosBDD = conexion.client.Get(@"Quiz/" + indice + "/");
            elementosBDD = servicio.contarPreguntasQuiz(datosBDD);
            crearPreguntaVerdaderoFalso();
        }

        private void tituloQuiz_Click(object sender, EventArgs e)
        {

        }

        public void crearPreguntaVerdaderoFalso()
        {
         
                if (PreguntaActual < elementosBDD)
                {
                    PreguntaActual++;
                    FirebaseResponse FBTipoDeQuiz = conexion.client.Get(@"Quiz/" + indice + "/TipoDeQuiz/");
                    string tipoDeQuizResp = FBTipoDeQuiz.Body.ToString();
                    string tipoDeQuiz = tipoDeQuizResp.Substring(1, tipoDeQuizResp.Length - 2);

                    FirebaseResponse enunciadoPregunta = conexion.client.Get(@"Pregunta/" + tipoDeQuiz + "/" + PreguntaActual + "/Pregunta");
                    string enunciadoResp = enunciadoPregunta.Body.ToString();
                    string enunciado = enunciadoResp.Substring(1, enunciadoResp.Length - 2);

                    labelEnunciado.Text = enunciado;
                }
            else
            {
                ProgresoQuiz.Value = 100;
                var result = MessageBox.Show("Enhorabuena, tu nota es un: " + nota, "Nota final del test",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }

            }


        }

        private bool comprobarRespuestaVF()
        {
            FirebaseResponse respuestaFB = conexion.client.Get(@"Pregunta/VerdaderoFalso" + "/" + PreguntaActual + "/Respuesta");
            string respuesta = respuestaFB.Body.ToString();
            if (respuesta == "True")
                return true;
            else return false;
        }

        private void JuegoQuiz_Load(object sender, EventArgs e)
        {

        }

        private void botonSiguiente_Click(object sender, EventArgs e)
        {
            
            Cursor.Current = Cursors.WaitCursor;
            crearPreguntaVerdaderoFalso();
            count++;
            if(count == 2) { this.Close(); }
            ProgresoQuiz.Value += progresoBarra();
            Cursor.Current = Cursors.Default;
        }

        private void ProgresoQuiz_ValueChanged(object sender)
        {

        }
        private int progresoBarra()
        {
            return 100 / elementosBDD;
        }
    }
}
