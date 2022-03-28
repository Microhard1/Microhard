using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public abstract class Respuesta
    {
       
        public string enunciado { get; }
        public Respuesta(string enunciado) {
            this.enunciado = enunciado;
            
        }
        public abstract void inicialize(bool correcta);
    }
}
