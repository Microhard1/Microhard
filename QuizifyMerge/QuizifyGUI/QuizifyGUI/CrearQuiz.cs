using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace QuizifyGUI
{
    public partial class CrearQuiz : Form
    {


        public CrearQuiz()
        {
            
            InitializeComponent();
            
            GridDatosPreguntas.Columns[1].Width = GridDatosPreguntas.Width - GridDatosPreguntas.Columns[0].Width;
        }

        private void metroSetPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectorTipoQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GridDatosPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBuscarPregunta_Click(object sender, EventArgs e)
        {
            GridDatosPreguntas.Rows.Clear();
            ConexionFirebaseTemp ConexionFirebase = ConexionFirebaseTemp.getInstancia();
            IFirebaseClient cliente = ConexionFirebase.getCliente();
            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/Abierta");
            

            Cursor.Current = Cursors.WaitCursor;
            for (int i = 0; i <=ContarElementosBDD(datosBDD) ; i++)
            {
                FirebaseResponse PreguntasBDD = ConexionFirebase.getCliente().Get(@"Pregunta/Abierta/" + i + "/Pregunta");
                //Aqui en vez de un string iria un objeto pregunta, pero antes hay que crear las properties
                string pregunta = PreguntasBDD.ResultAs<String>();

                if (pregunta != "" && pregunta!=" " && pregunta!="\n" && pregunta!=null)
                {
                    GridDatosPreguntas.Rows.Add(false,pregunta);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private int ContarElementosBDD(FirebaseResponse datosBDD)
        {
            string datos = datosBDD.Body;
            return Regex.Matches(datos, ",{").Count;
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
