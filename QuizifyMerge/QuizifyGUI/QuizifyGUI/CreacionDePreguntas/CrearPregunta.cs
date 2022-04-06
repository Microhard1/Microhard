using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Exceptions;
using MetroSet_UI.Controls;
using Quizify.BussinessLogic.Clases;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuizifyLibrary.Persistencia;
using Quizify.BussinessLogic.Servicios;
using System.Collections.Generic;

namespace QuizifyGUI
{
    public partial class CrearPregunta : Form
    {

        string tipoQuizSeleccionado="";
        Form FormularioActual = null;
        string enunciado="";
        int puntuacion=0;
        string imagen = "";
        string explicacion = "";

        ConexionFirebase ConexionFirebase;
        IFirebaseClient cliente;
        QuizifyServices servicio;

        
        public CrearPregunta()
        {
            InitializeComponent();
            ConexionFirebase = ConexionFirebase.getInstancia();
            cliente = ConexionFirebase.client;
            servicio = new QuizifyServices();
        }

        private void abrirFormHijo(object formHijo)
        {
            if (this.PanelCentralPreguntas.Controls.Count > 0)
            {
                this.PanelCentralPreguntas.Controls.RemoveAt(0);
            }
            
            Form formularioHijo = formHijo as Form;
            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.PanelCentralPreguntas.Controls.Add(formularioHijo);
            this.PanelCentralPreguntas.Tag = formularioHijo;
            FormularioActual = formularioHijo;
            formularioHijo.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscarPregunta_Click(object sender, EventArgs e)
        {

        }

        private void SelectorTipoQuiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoQuizSeleccionado=SelectorTipoQuiz.SelectedItem.ToString();

            switch (tipoQuizSeleccionado)
            {
                case "Tipo Test":
                    abrirFormHijo(new TipoTest()) ;
                    break;
                case  "Respuesta Abierta":
                    abrirFormHijo(new RespuestaAbierta());
                    break;
                case "Verdadero/Falso":
                    abrirFormHijo(new VerdaderoFalso());
                    break;
                default:
                    Console.WriteLine("No saco nada");
                    break;

            }



        }

        private void PanelCentralPreguntas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonCrearPregunta_Click(object sender, EventArgs e)
        {
            switch (tipoQuizSeleccionado)
            {
               
                case "Tipo Test":
                    CrearPreguntaTipoTest();
                    break;
                case "Respuesta Abierta":
                    CrearPreguntaAbierta();
                    break;
                case "Verdadero/Falso":
                    CrearPreguntaVerdaderoFalso();
                    break;
                default:
                    MessageBox.Show("Seleccione el tipo de pregunta y rellénela antes.");
                    break;

            }

        }

        private int ConseguirPuntuacion(string texto) {
            int puntuacion=-1;
            try
            {
                puntuacion = int.Parse(texto);
                if(puntuacion>10 || puntuacion<0) throw new Exception();
            }
            catch{
                MessageBox.Show("Introduce una puntuacion correcta");
            }

            return puntuacion;
        }

        private void Puntuacion_Click(object sender, EventArgs e)
        {
            
        }

        private void metroSetRichTextBox1_TextChanged(object sender)
        {

        }

        public void CrearPreguntaAbierta()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
            string descripcion = Descripcion.Text;

            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(MetroSetTextBox))
                {
                    if (c.Name == "enunciadoRespuestaAbierta")
                    {
                        enunciado = ((MetroSetTextBox)c).Text;
                    }

                }
            }
        }

        public void CrearPreguntaVerdaderoFalso()
        {
            ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
            string enunciado = "";
            bool verdaderoOFalso = false;
            string descripcion = Descripcion.Text;

            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(RadioButton))
                {
                    RadioButton aux = (RadioButton)c;
                    if (aux.Name == "BotonFalso")
                    {
                        if (aux.Checked)
                        {
                            verdaderoOFalso = false;
                        }
                        else
                        {
                            verdaderoOFalso = true;
                        }
                    }
                }
                if (c.GetType() == typeof(MetroSetTextBox))
                {
                    if (c.Name == "EnunciadoVerdaderoFalso")
                    {
                        enunciado = ((MetroSetTextBox)c).Text;
                    }

                }
            }
            Pregunta pregunta = new PreguntaVerdaderoFalso(enunciado,imagen,puntuacion,explicacion);
            Respuesta r= pregunta.crearRespuesta(verdaderoOFalso.ToString());
            r.inicialize(verdaderoOFalso);
            pregunta.añadirRespuesta(r);

            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/VerdaderoFalso/");
            int indice = ContarElementosBDD(datosBDD)+1;


            cliente.Set("Pregunta/VerdaderoFalso/" + indice,pregunta);

            MessageBox.Show("Se ha insertado una pregunta: " + indice);
        }

        public void CrearPreguntaTipoTest()
        {
            List<TextBox> listaRespuestas = getListaRespuestas();
            ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
            string enunciado = "";
            string descripcion = Descripcion.Text;
            Pregunta pregunta = new PreguntaMultiOpcion(enunciado, imagen, puntuacion, explicacion);
            Respuesta r;
            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(CheckBox))
                {

                    CheckBox aux = (CheckBox)c;

                    
                        if (aux.Name == "ckeckPregunta1")
                        {
                            foreach (TextBox t in listaRespuestas)
                            {
                                if (t.Name== "textPregunta1")
                                {
                                r = new RespuestaMultiOpcion(t.Text);
                                if (aux.Checked) { r.inicialize(true); } else { r.inicialize(false); }
                                    pregunta.añadirRespuesta(r);
                                }
                            }
                        }
                        else if (aux.Name == "ckeckPregunta2")
                        {
                            foreach (TextBox t in listaRespuestas)
                            {
                                if (t.Name == "textPregunta2")
                                {
                                    r = new RespuestaMultiOpcion(t.Text);
                                    if (aux.Checked) { r.inicialize(true); } else { r.inicialize(false); }
                                    pregunta.añadirRespuesta(r);
                                }
                                
                            }
                        }
                        else if(aux.Name == "ckeckPregunta3")
                        {
                            foreach (TextBox t in listaRespuestas)
                            {
                                if (t.Name == "textPregunta3")
                                {
                                     r = new RespuestaMultiOpcion(t.Text);
                                    if (aux.Checked) { r.inicialize(true); } else { r.inicialize(false); }
                                    pregunta.añadirRespuesta(r);
                                }
                            }
                        }
                        else if(aux.Name == "ckeckPregunta4")
                        {
                            foreach (TextBox t in listaRespuestas)
                            {
                                if (t.Name == "textPregunta4")
                                {
                                r = new RespuestaMultiOpcion(t.Text);
                                if (aux.Checked) { r.inicialize(true); } else { r.inicialize(false); }
                                pregunta.añadirRespuesta(r);
                             }
                            }
                        }
                }
                else if (c.GetType() == typeof(MetroSetTextBox))
                {
                    if (c.Name == "enunciadoTipoTest")
                    {
                        enunciado = ((MetroSetTextBox)c).Text;
                    }

                }
            }

            FirebaseResponse datosBDD = cliente.Get(@"Pregunta/Multiopcion/");
            int indice = ContarElementosBDD(datosBDD) + 1;


            cliente.Set("Pregunta/Multiopcion/" + indice, pregunta);

            MessageBox.Show("Se ha insertado una pregunta: " + indice);
        }

        private void asignarDatos()
        {
            explicacion = Descripcion.Text;
        }

        private List<TextBox> getListaRespuestas()
        {
            List<TextBox> respuestas = new List<TextBox>();
            ControlCollection objetosDelFormulario = (ControlCollection)FormularioActual.Controls;
            foreach (Control c in objetosDelFormulario)
            {
                if (c.GetType() == typeof(TextBox)) {
                    TextBox aux= (TextBox)c;
                    respuestas.Add(aux);
                }
            }

            return respuestas;
        }
        private int ContarElementosBDD(FirebaseResponse datosBDD)
        {
            string datos = datosBDD.Body;
            return Regex.Matches(datos, ",{").Count;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
