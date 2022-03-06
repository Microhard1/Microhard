using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class Alumno : Usuario
    {
        public ICollection<Asignatura> Asignaturas;
        public ICollection<Quiz> Quizes;


        public Alumno(string nUsuario, string passUsuario) : base(nUsuario, passUsuario) 
        {
            
        }

    }
}
