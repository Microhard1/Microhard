<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class QuizMultiOpcion : Quiz
    {
        public QuizMultiOpcion(string nombreQuiz) : base(nombreQuiz) { 
        

        }
            
        
        public override Pregunta crearPregunta(string enunciado, string imagen, double puntuacion)
        {

            Pregunta p = new PreguntaMultiOpcion();
            return p;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
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
>>>>>>> 9e7d67a3ab023b43a1f85e90838ad155338f139c
