using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    class Alumno : Usuario
    {
        ICollection<Asignatura> Asignaturas;

        public Alumno(string nUsuario, string passUsuario) : base(nUsuario, passUsuario) 
        {
            
            
        }

    }
}
