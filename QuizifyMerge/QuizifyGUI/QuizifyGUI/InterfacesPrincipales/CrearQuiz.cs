using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Quizify.BussinessLogic.Servicios;
using QuizifyLibrary.Persistencia;




namespace QuizifyGUI
{
    public partial class CrearQuiz : Form
    {

        QuizifyServices servicio = new QuizifyServices();
        ConexionFirebase ConexionFirebase;
        IFirebaseClient cliente;
        public CrearQuiz()
        {
            
            InitializeComponent();
            ConexionFirebase= ConexionFirebase.getInstancia();
            cliente = ConexionFirebase.client;
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
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {
                
                //((CheckBox)GridDatosPreguntas.Rows[e.RowIndex].Cells[0]).Checked = true;
            }
        }

        private void BotonBuscarPregunta_Click(object sender, EventArgs e)
        {
            GridDatosPreguntas.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;

            if (SelectorTipoQuiz.Text== "Tipo Test") {

                añadirPreguntas(cliente, "Multiopcion"); 
            }
            else if (SelectorTipoQuiz.Text == "Respuesta Abierta") {

                añadirPreguntas(cliente, "Abierta");
            }
            else if (SelectorTipoQuiz.Text == "Verdadero/Falso") {

                añadirPreguntas(cliente, "VerdaderoFalso");
            }
            else
            {
                añadirPreguntas(cliente, "Multiopcion");
                añadirPreguntas(cliente, "Abierta");
                añadirPreguntas(cliente, "VerdaderoFalso");
            }
            
           
            Cursor.Current = Cursors.Default;
        }

        

        public void añadirPreguntas(IFirebaseClient cliente, String path)
        {
            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/"+path);

            int elementosBDD = servicio.ContarElementosBDD(datosBDD);
            for (int i = 0; i <=elementosBDD ; i++)
            {
                FirebaseResponse PreguntasBDD = cliente.Get("Pregunta/"+path+"/" + i + "/Pregunta");
                //Aqui en vez de un string iria un objeto pregunta, pero antes hay que crear las properties
                string pregunta = PreguntasBDD.Body.ToString();

                if (pregunta != "null" && pregunta != " " && pregunta != "\n" && pregunta != null)
                {
                    GridDatosPreguntas.Rows.Add(false, pregunta);
                }
            }
        }


        private void BotonCrearPregunta_Click(object sender, EventArgs e)
        {
            FirebaseResponse datosBDD = cliente.Get(@"Quiz");
            int indice = servicio.ContarElementosBDD(datosBDD);
        }
    }
}
