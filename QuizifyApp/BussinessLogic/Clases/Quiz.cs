using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    class Quiz
    {
        ICollection<Pregunta> preguntasQuiz;
        ICollection<int> temas;

        public Instructor creadoPor;
        public Asignatura asignatura;
        
        public DateTime fechaDeInicio;
        public DateTime fechaFin;


        public int duracion;
        public string dificultad;
        public string nombreQuiz;



    }
}
