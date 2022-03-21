using System;
using System.Collections.Generic;
using System.Text;

namespace Quizify.BussinessLogic.Clases
{
    class RespuestaVerdaderoFalso: Respuesta
    {
        bool correcta;
        public RespuestaVerdaderoFalso(string enunciado):base(enunciado) {
            
        }
    }
}
