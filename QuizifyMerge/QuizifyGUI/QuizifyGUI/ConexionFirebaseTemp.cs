using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QuizifyGUI
{
    public sealed class ConexionFirebaseTemp
    {

        private static ConexionFirebaseTemp instancia;
        public IFirebaseClient client;
        public IFirebaseConfig conexion;
        private ConexionFirebaseTemp()
        {

            conexion = new FirebaseConfig()
            {
                AuthSecret = "G8JyRbxDwLBglP0vwXdm7G0cX1Raa8nXQud4rtgw",
                BasePath = "https://quizify-62e37-default-rtdb.firebaseio.com/"
            };
        }

        public static ConexionFirebaseTemp getInstancia()
        {
            if (instancia == null)
            {
                instancia = new ConexionFirebaseTemp();
            }
            return instancia;
        }

    }
}
