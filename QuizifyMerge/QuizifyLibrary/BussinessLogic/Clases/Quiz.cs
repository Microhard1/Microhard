using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public abstract class Quiz
    {

        public ICollection<Pregunta> preguntasQuiz;


        public ICollection<Alumno> hechoPor;
        public Instructor creadoPor;
        public Asignatura asignatura;
        
        public DateTime fechaDeInicio;
        public DateTime fechaFin;


        public int duracion;
        public string dificultad;
        public string nombreQuiz;

        public Quiz(string nombreQuiz, Instructor creadoPor, int duracion, string dificultad,
                DateTime inicio, DateTime fin) 
        {
            this.nombreQuiz = nombreQuiz;
            this.creadoPor = creadoPor;
            this.duracion = duracion;
            this.dificultad = dificultad;
            this.fechaDeInicio = inicio;
            this.fechaFin = fin;
        
        }

        public void añadirPregunta(string enunciado, string imagen, double puntuacion, string explicacion)
        {
            Pregunta p = crearPregunta(enunciado, imagen, puntuacion, explicacion);
            preguntasQuiz.Add(p);
        }

        public abstract Pregunta crearPregunta(string enunciado, string imagen, double puntuacion, string explicacion);
        
        public bool PreguntasRepetidas()
        {
            for(int i = 0; i < preguntasQuiz.Count - 1; i++)
            {
                if(preguntasQuiz.ToArray<Pregunta>()[i] == preguntasQuiz.ToArray<Pregunta>()[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
