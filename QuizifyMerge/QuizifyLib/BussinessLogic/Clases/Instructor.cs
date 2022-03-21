using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class Instructor : Usuario
    {
        public ICollection<Alumno> Alumnos;
        public ICollection<Asignatura> imparte;
        public ICollection<Quiz> quizesCreados;
        public ICollection<Pregunta> preguntasCreadas;


        public Instructor(string nUsuario, string passUsuario) : base(nUsuario, passUsuario) {

            imparte = new List<Asignatura>();
            Alumnos = new List<Alumno>();
            quizesCreados = new List<Quiz>();
            preguntasCreadas = new List<Pregunta>();

        }

        public void addPregunta(Pregunta p) 
        {
            preguntasCreadas.Add(p);
        }
        public void addQuiz(Quiz q)
        {
            quizesCreados.Add(q);
        }

    }
}
