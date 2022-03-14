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
    public partial class RealizarQuiz : Form
    {
        public RealizarQuiz()
        {
            InitializeComponent();
            GridDatosPreguntas.Columns[0].Width = GridDatosPreguntas.Width - GridDatosPreguntas.Columns[1].Width;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroSetProgressBar1_ValueChanged(object sender)
        {

        }

        private void RealizarQuiz_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscarPregunta_Click(object sender, EventArgs e)
        {
            GridDatosPreguntas.Rows.Clear();
            ConexionFirebaseTemp ConexionFirebase = ConexionFirebaseTemp.getInstancia();
            IFirebaseClient cliente = ConexionFirebase.getCliente();
            Cursor.Current = Cursors.WaitCursor;

            añadirPreguntas(cliente, "Quiz");


            Cursor.Current = Cursors.Default;
        }

        private int ContarElementosBDD(FirebaseResponse datosBDD)
        {
            string datos = datosBDD.Body;
            return Regex.Matches(datos, ",{").Count;
        }

        public void añadirPreguntas(IFirebaseClient cliente, String path)
        {
            FirebaseResponse datosBDD = cliente.Get(@""+ path);

            for (int i = 0; i <= ContarElementosBDD(datosBDD); i++)
            {
                FirebaseResponse PreguntasBDD = cliente.Get(@"Quiz/"+i+"/Titulo");
                //Aqui en vez de un string iria un objeto pregunta, pero antes hay que crear las properties
                string pregunta = PreguntasBDD.ResultAs<String>();

                if (pregunta != "" && pregunta != " " && pregunta != "\n" && pregunta != null)
                {
                    GridDatosPreguntas.Rows.Add(pregunta);
                }
            }
        }

        private void GridDatosPreguntas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                String TituloQuiz = GridDatosPreguntas.Rows[e.RowIndex].Cells[0].Value.ToString();

                Form Quiz = new JuegoQuiz(TituloQuiz,e.RowIndex);
                Quiz.Show();
            }
        }
    }
}
