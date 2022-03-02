<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 9e7d67a3ab023b43a1f85e90838ad155338f139c
