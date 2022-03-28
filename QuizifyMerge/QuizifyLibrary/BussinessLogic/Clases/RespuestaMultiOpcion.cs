using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class RespuestaMultiOpcion : Respuesta
    {
        public bool correcta;

        public RespuestaMultiOpcion(string enunciado) : base(enunciado) {

           
        }

        public override void inicialize(bool correcta)
        {
            this.correcta = correcta;
        }
    }
}
