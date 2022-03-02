<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyApp.BussinessLogic.Clases
{
    public class Asignatura
    {
        ICollection<Competencia> competencias;
        public Instructor instructor;
        
        public Asignatura(Instructor instructor)
        {
            competencias = new List<Competencia>();
        }
        
        public void AñadirCompetencia(Competencia c) 
        {
            this.competencias.Add(c);
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
    public class Asignatura
    {
        ICollection<Competencia> competencias;
        public Instructor instructor;
        
        public Asignatura(Instructor instructor)
        {
            competencias = new List<Competencia>();
        }
        
        public void AñadirCompetencia(Competencia c) 
        {
            this.competencias.Add(c);
        }


    }
}
>>>>>>> 9e7d67a3ab023b43a1f85e90838ad155338f139c
