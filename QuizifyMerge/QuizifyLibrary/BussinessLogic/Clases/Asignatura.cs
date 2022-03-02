using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
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
