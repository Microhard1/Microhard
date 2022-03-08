using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
    public partial class CrearQuiz : Form
    {


        public CrearQuiz()
        {
            IFirebaseConfig fcon = new FirebaseConfig()
            {

                AuthSecret = "G8JyRbxDwLBglP0vwXdm7G0cX1Raa8nXQud4rtgw",
                BasePath = "https://quizify-62e37-default-rtdb.firebaseio.com/"

            };

            FirebaseClient cliente;
            try
            {
                cliente = new FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("Algo ha salido mal");
            }
            
            InitializeComponent();
            GridDatosPreguntas.Rows.Clear();
        }

        private void metroSetPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectorTipoQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
