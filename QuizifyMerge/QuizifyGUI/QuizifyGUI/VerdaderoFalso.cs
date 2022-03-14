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
    public partial class VerdaderoFalso : Form
    {
        public VerdaderoFalso()
        {
            InitializeComponent();
            imagenPregunta.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BotonFalso_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void EnunciadoVerdaderoFalso_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void botonAñadirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                imagenPregunta.Image = new Bitmap(open.FileName);

            }
        }
    }
}
