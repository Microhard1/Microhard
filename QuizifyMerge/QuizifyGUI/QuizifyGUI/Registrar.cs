﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QuizifyGUI
{
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NombreUsuario.Text) ||
               string.IsNullOrWhiteSpace(PrimerApellido.Text) ||
               string.IsNullOrWhiteSpace(SegundoApellido.Text) ||
               string.IsNullOrWhiteSpace(Contrasenya.Text) ||
               string.IsNullOrWhiteSpace(Email.Text)) { MessageBox.Show("Porfavor, rellene todos los campos"); }
                else if (true/*QuizifyServices.UsuarioExiste(NombreUsuario.Text)*/)
                {
                    MessageBox.Show("Ese nombre de usuario ya existe");
                }
                else
                {
                    if (radioButtonAlumno.Checked)
                    {
                        //QuizifyServices.RegistrarAlumno();
                        MessageBox.Show("Se registro correctamente");
                    }
                    else
                    {
                        //QuizifyServices.RegistrarInstructor();
                        MessageBox.Show("Se registro correctamente");
                    }
                }
        }
           
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PrimerApellido_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
