using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class QuizMultiOpcion : Quiz
    {
        public QuizMultiOpcion(string nombreQuiz) : base(nombreQuiz) { 
        

        }


        public override Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = new PreguntaMultiOpcion(enunciado, imagen, puntuacion, explicacion);
            return p;
        }
    }
}
