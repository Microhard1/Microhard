<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class PreguntaMultiOpcion : Pregunta
    {

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
    public class PreguntaMultiOpcion : Pregunta
    {

        public PreguntaMultiOpcion(string enunciado, string imagen, double puntuacion, string explicacion) : 
                base(enunciado, imagen, puntuacion, explicacion) 
        {
        
        }
            
        public override Respuesta crearRespuesta(string enunciado, bool correcta)
        {
            Respuesta r = new RespuestaMultiOpcion(enunciado, correcta);
            return r;
        }
    }
}
>>>>>>> 9e7d67a3ab023b43a1f85e90838ad155338f139c
