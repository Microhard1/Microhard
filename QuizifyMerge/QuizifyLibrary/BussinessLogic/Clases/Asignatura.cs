using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class Asignatura
    {
        public ICollection<Competencia> competencias;
        public ICollection<Quiz> quizes;
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
