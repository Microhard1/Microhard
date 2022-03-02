using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class PreguntaVerdaderoFalso : Pregunta
    {
        public PreguntaVerdaderoFalso(string enunciado, string imagen, double puntuacion, string explicacion):base(enunciado,imagen,puntuacion,explicacion)
        {

        }
        public override Respuesta crearRespuesta(string enunciado, bool correcta)
        {
            Respuesta r = new RespuestaVerdaderoFalso(enunciado,correcta);
            return r;
        }
    }
}
