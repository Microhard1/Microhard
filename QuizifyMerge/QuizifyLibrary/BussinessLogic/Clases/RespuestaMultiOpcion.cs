using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Clases
{
    public class RespuestaMultiOpcion : Respuesta
    {
        public bool correcta;

        public RespuestaMultiOpcion(string enunciado) : base(enunciado) {

           
        }
    }
}
