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
