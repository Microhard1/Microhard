using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class Instructor : Usuario
    {
        ICollection<Alumno> Alumnos;
        ICollection<Asignatura> imparte;

        public Instructor(string nUsuario, string passUsuario) : base(nUsuario, passUsuario) {

            imparte = new List<Asignatura>();
            Alumnos = new List<Alumno>();

        }
    }
}
