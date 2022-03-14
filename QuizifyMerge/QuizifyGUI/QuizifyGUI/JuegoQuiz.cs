using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace QuizifyGUI
{
    public partial class JuegoQuiz : Form
    {
        int indice;
        int PreguntaActual = 0;
        public JuegoQuiz(String titulo, int indice)
        {
            InitializeComponent();
            tituloQuiz.Text = titulo;
            this.indice = indice;
            crearQuiz();
        }

        private void tituloQuiz_Click(object sender, EventArgs e)
        {

        }

        private int ContarElementosBDD(FirebaseResponse datosBDD)
        {
            string datos = datosBDD.Body;
            return Regex.Matches(datos, ",{").Count;
        }

        public void crearQuiz()
        {
            ConexionFirebaseTemp ConexionFirebase = ConexionFirebaseTemp.getInstancia();
            IFirebaseClient cliente = ConexionFirebase.getCliente();

            FirebaseResponse datosBDD = cliente.Get(@"Quiz/"+indice+"/");

           if(PreguntaActual <= ContarElementosBDD(datosBDD))
            {
                PreguntaActual++;
                FirebaseResponse PreguntaQuiz = cliente.Get(@"Quiz/" + indice + "/" + PreguntaActual + "/");
                //Aqui en vez de un string iria un objeto pregunta, pero antes hay que crear las properties
                string PreguntaConIndice = PreguntaQuiz.ResultAs<String>();
                FirebaseResponse  enunciadoPregunta= cliente.Get(@"Pregunta/" + PreguntaConIndice + "/Pregunta");
                string enunciadoString = enunciadoPregunta.ResultAs<String>();

                labelEnunciado.Text = enunciadoString;
            }
        }

        public void crearPreguntaVerdaderoFalso()
        {

        }
    }
}
