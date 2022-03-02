<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class Calificacion
    {
        public int puntuacion;
        public Alumno alumno;
        public Quiz quiz;

        public Calificacion(int puntuacion, Alumno alumno, Quiz quiz)
        {
            this.puntuacion = puntuacion;
            this.alumno = alumno;
            this.quiz = quiz;       
        }

        public Calificacion(int puntuacion, Alumno alumno)
        {
            this.puntuacion = puntuacion;
            this.alumno = alumno;
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
    public class Calificacion
    {
        public int puntuacion;
        public Alumno alumno;
        public Quiz quiz;

        public Calificacion(int puntuacion, Alumno alumno, Quiz quiz)
        {
            this.puntuacion = puntuacion;
            this.alumno = alumno;
            this.quiz = quiz;       
        }

        public Calificacion(int puntuacion, Alumno alumno)
        {
            this.puntuacion = puntuacion;
            this.alumno = alumno;
        }

    }
}
>>>>>>> 9e7d67a3ab023b43a1f85e90838ad155338f139c
