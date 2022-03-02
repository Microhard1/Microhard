using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class Competencia
    {
        public string codigo;
        public string descripcion;
        public Asignatura asignatura;
        public string nivel;

        public Competencia(string cod, string des, Asignatura asig, string niv)
        {
            this.codigo = cod;
            this.descripcion = des;
            this.asignatura = asig;
            this.nivel = niv;
        }

    }
}
