﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class PreguntaAbierta : Pregunta 
    {
        public PreguntaAbierta(string enunciado, string imagen, double puntuacion, string explicacion) :
                base(enunciado, imagen, puntuacion, explicacion){

            
        }

        public override Respuesta crearRespuesta(string enunciado, bool correcta)
        {
            Respuesta r = new RespuestaAbierta(enunciado, correcta);
            return r;
        }
    }
}