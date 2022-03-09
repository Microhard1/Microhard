using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class QuizAbierto : Quiz
    {
<<<<<<< HEAD
        public QuizAbierto(string nombreQuiz, Instructor creadoPor,int duracion,string dificultad,DateTime inicio,DateTime fin) : 
            base(nombreQuiz,creadoPor,duracion,dificultad,inicio,fin) { 
=======
        public QuizAbierto(string nombreQuiz, Instructor creadoPor, int duracion, string dificultad,
                DateTime inicio, DateTime fin) :
                base(nombreQuiz, creadoPor, duracion, dificultad, inicio, fin) { 
>>>>>>> ed8c4ecad23eb1d78c86ee49fb20af12e9c2cf67
        

        }


        public override Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaAbierta(enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}
