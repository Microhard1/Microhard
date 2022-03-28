using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public abstract class Pregunta
    {
        public ICollection<Respuesta> respuestas { get; }
        public string enunciado { get; }
        public string imagen { get; }
        public double puntuacion { get; }
        public string explicacion { get; }

        //public string getEnunciado() { return enunciado; }
        public Pregunta(string enunciado, string imagen, double puntuacion, string explicacion) 
        {
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
            this.imagen = imagen;
            respuestas = new List<Respuesta>();
        }

        public Pregunta(string enunciado, double puntuacion, string explicacion)
        {
            this.enunciado = enunciado;
            this.explicacion = explicacion;
            this.puntuacion = puntuacion;
        }

        public void añadirRespuesta(Respuesta r) 
        {
            respuestas.Add(r);
        }

        public abstract Respuesta crearRespuesta(string enunciado);
        
    }
}
