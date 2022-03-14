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
    public partial class JuegoQuiz : Form
    {

        public JuegoQuiz(String titulo, int indice)
        {
            InitializeComponent();

            tituloQuiz.Text = titulo;
        }

        private void tituloQuiz_Click(object sender, EventArgs e)
        {

        }
    }
}
