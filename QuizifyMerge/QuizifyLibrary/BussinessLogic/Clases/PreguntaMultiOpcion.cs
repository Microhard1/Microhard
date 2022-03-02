﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
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