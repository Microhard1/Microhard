﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class PreguntaVerdaderoFalso : Pregunta
    {
        public PreguntaVerdaderoFalso(bool respuesta,string enunciado, string imagen, double puntuacion, string explicacion):base(enunciado,imagen,puntuacion,explicacion)
        {

        }
        public override Respuesta crearRespuesta(string enunciado)
        {
            Respuesta r = new RespuestaVerdaderoFalso(enunciado);
            return r;
        }
    }
}
