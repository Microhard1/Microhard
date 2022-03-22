using QuizifyGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizify
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreUsuario.Text) ||
              string.IsNullOrWhiteSpace(Contrasenya.Text)) { MessageBox.Show("Porfavor, rellene todos los campos"); }
                else if(true/*QuizifyServices.UsuarioExiste(NombreUsuario.Text)*/)
                {
                    if(true/*QuizifServices.VerificarCredenciales(NombreUsuario.Text, Contrasenya.Text);*/)
                    {
                        this.Hide();
                        Inicio sistema = new Inicio();
                        sistema.ShowDialog();
                        this.Close();
                }
                    else
                    {
                        MessageBox.Show("nombre de usuario o contraseña incorrectos");
                    }
                }
                else
                {
                    MessageBox.Show("este nombre de usuario no existe");
                }
        }
        private void olvidarContrasenya_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
