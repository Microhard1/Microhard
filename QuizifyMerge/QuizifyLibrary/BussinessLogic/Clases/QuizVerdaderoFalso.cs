using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class QuizVerdaderoFalso : Quiz
    {
        public QuizVerdaderoFalso(string nombreQuiz, Instructor creadoPor, int duracion, string dificultad, DateTime inicio, DateTime fin) :
            base(nombreQuiz, creadoPor, duracion, dificultad, inicio, fin)
        {

        }

        public override Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaVerdaderoFalso(enunciado, imagen, puntuacion, explicacion);
            this.añadirPregunta(p);
            return p;
        }
    }
}