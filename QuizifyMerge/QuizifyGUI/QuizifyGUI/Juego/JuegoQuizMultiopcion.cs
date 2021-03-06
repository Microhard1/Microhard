using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class JuegoQuizMultiopcion : Form
    {
        int indice;
        int PreguntaActual = 0;
        int elementosBDD;
        int nota = 0;
        private int tiempo;
        QuizifyServices servicio;
        IFirebaseClient cliente;
        ConexionFirebase ConexionFirebase;
        
        public JuegoQuizMultiopcion(String titulo, int indice)
        {
            InitializeComponent();

            imagenPregunta.SizeMode = PictureBoxSizeMode.StretchImage;
            ProgresoQuiz.BorderColor = Color.Black;
            tituloQuiz.Text = titulo;
            this.indice = indice;
            EnviarTest.Enabled = false;

            servicio = new QuizifyServices();
            ConexionFirebase = ConexionFirebase.getInstancia();
            cliente = ConexionFirebase.client;
            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/Multiopcion/");
            elementosBDD = servicio.contarPreguntasQuiz(datosBDD);

            tiempo = getTiempo();
            CrearPregunta();
            iniciarRespuestas();
        }

        private void ProgresoQuiz_ValueChanged(object sender)
        {

        }

        private int getTiempo()
        {
            FirebaseResponse FBTipoDeQuiz = cliente.Get(@"Quiz/3" + "/Tiempo/");
            string tipoDeQuizResp = FBTipoDeQuiz.Body.ToString();
            string tipoDeQuiz = tipoDeQuizResp.Substring(1, tipoDeQuizResp.Length - 2);
            return int.Parse(tipoDeQuiz);
        }

        private void CrearPregunta()
        {
            if (PreguntaActual < elementosBDD)
            {
                PreguntaActual++;
                //Aqui se usaria el indice, pero no va bien de momento para la demo 
                FirebaseResponse FBTipoDeQuiz = cliente.Get(@"Quiz/3" + "/TipoDeQuiz/");
                string tipoDeQuizResp = FBTipoDeQuiz.Body.ToString();
                string tipoDeQuiz = tipoDeQuizResp.Substring(1, tipoDeQuizResp.Length - 2);

                FirebaseResponse enunciadoPregunta = cliente.Get(@"Pregunta/" + tipoDeQuiz + "/" + PreguntaActual + "/Pregunta");
                string enunciadoResp = enunciadoPregunta.Body.ToString();
                string enunciado = enunciadoResp.Substring(1, enunciadoResp.Length - 2);

                Enunciado.Text = enunciado;
                
            }

            else
            {
                ProgresoQuiz.Value = 100;
                var result = MessageBox.Show("Enhorabuena, tu nota es un: " + nota, "Nota final del test",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                EnviarTest.Enabled = true;

            }
        }

        private void siguientePregunta_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (comprobarRespuestaMultiopcion())
            {
                nota += 10/elementosBDD;
            }
            Opcion1.Checked=false;
            Opcion2.Checked = false;
            Opcion3.Checked = false;
            Opcion4.Checked = false;
            CrearPregunta();
            iniciarRespuestas();

            ProgresoQuiz.Value += progresoBarra();
            Cursor.Current = Cursors.Default;
        }

        public bool comprobarRespuestaMultiopcion()
        {
            FirebaseResponse respuestaFB = cliente.Get(@"Pregunta/Multiopcion" + "/" + PreguntaActual + "/RespuestaVerdadera");
            string respuesta = respuestaFB.Body.ToString();
            string respuestaString = respuesta.Substring(1, respuesta.Length - 2);

            if (Opcion1.Checked == true)
            {
                return respuestaString == Opcion1.Text;
            }
            else if(Opcion2.Checked == true){
                return respuestaString == Opcion2.Text;
            }
            else if(Opcion3.Checked == true)
            {
                return respuestaString == Opcion3.Text;
            }
            else if(Opcion4.Checked == true)
            {
                return respuestaString == Opcion4.Text;
            }
            return false;
        }

        private void Opcion1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void Opcion2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Opcion3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Opcion4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private int progresoBarra()
        {
            return 100 / elementosBDD;
        }

        private void iniciarRespuestas()
        {
            FirebaseResponse respuestaFB = cliente.Get(@"Pregunta/Multiopcion" + "/" + PreguntaActual + "/RespuestaVerdadera");
            string respuesta = respuestaFB.Body.ToString();
            string respuestaString = respuesta.Substring(1, respuesta.Length - 2);

            Opcion1.Text = respuestaString;

            FirebaseResponse respuestasFalsasFB = cliente.Get(@"Pregunta/Multiopcion" + "/" + PreguntaActual + "/RespuestaFalsa");
            string respuestasFalsas = respuestasFalsasFB.Body.ToString();
            string respuestasFalsasString = respuestasFalsas.Substring(1, respuestasFalsas.Length - 2);
            string[] values = respuestasFalsasString.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }
            Opcion2.Text = values[0];
            Opcion3.Text = values[1];
            Opcion4.Text = values[2];
        }

        private void EnviarTest_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Test enviado", "Envio",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void TiempoQuiz_Tick(object sender, EventArgs e)
        {
            tiempo--;
            if (tiempo == 0)
            {
                var result = MessageBox.Show("Se acabó el tiempo, su quiz se enviará automáticamente", "Envio",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                string minutos = tiempo / 60 + "";
                string segundos = tiempo % 60 + "";
                labelTiempo.Text = minutos + " : " + segundos;
            }
        }

        private void labelTiempo_Click(object sender, EventArgs e)
        {

        }

        private void JuegoQuizMultiopcion_Load(object sender, EventArgs e)
        {

        }
    }
}
