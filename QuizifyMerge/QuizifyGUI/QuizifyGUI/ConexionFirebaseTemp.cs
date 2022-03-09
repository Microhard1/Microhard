using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QuizifyGUI
{
    public sealed class ConexionFirebaseTemp
    {

        private static ConexionFirebaseTemp instancia;
        private IFirebaseClient client;
        private IFirebaseConfig conexion;
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
                try
                {
                    instancia.client = new FireSharp.FirebaseClient(instancia.conexion);
                }
                catch
                {
                    Console.WriteLine("Algo ha salido mal");
                }
            }
            return instancia;
        }

        public IFirebaseClient getCliente()
        {
            return client;
        }

    }
}
