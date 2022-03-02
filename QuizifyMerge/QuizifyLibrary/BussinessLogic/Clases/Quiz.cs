﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public abstract class Quiz
    {

        ICollection<Pregunta> preguntasQuiz;
        ICollection<int> temas;

        public Alumno hechoPor;
        public Instructor creadoPor;
        public Asignatura asignatura;
        
        public DateTime fechaDeInicio;
        public DateTime fechaFin;


        public int duracion;
        public string dificultad;
        public string nombreQuiz;

        public Quiz(string nombreQuiz) 
        {
            this.nombreQuiz = nombreQuiz;
        
        }

        public void añadirPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = crearPregunta(enunciado, imagen, puntuacion, explicacion);
            preguntasQuiz.Add(p);
        }

        public abstract Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion);
        
    }
}
