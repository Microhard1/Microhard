using System;
using System.Collections.Generic;
using System.Text;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    class RespuestaVerdaderoFalso: Respuesta
    {
        bool correcta;
        public RespuestaVerdaderoFalso(string enunciado, bool correcta):base(enunciado) {
            this.correcta = correcta;
        }
    }
}
