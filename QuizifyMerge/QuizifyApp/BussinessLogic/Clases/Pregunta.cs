﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public abstract class Pregunta
    {

        ICollection<Respuesta> respuestas;
        public string enunciado;
        public string imagen;
        public double puntuacion;
        private string explicacion;

        public Pregunta(string enunciado, string imagen, double puntuacion, string explicacion) 
        {
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
            this.imagen = imagen;

        }

        public void añadirRespuesta(Respuesta r) {
            respuestas.Add(r);
        }

        public abstract Respuesta crearRespuesta(string enunciado, bool correcta);

    }
}