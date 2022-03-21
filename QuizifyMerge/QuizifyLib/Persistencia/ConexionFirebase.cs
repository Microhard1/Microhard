using System;
using System.Collections.Generic;
using System.Text;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QuizifyLibrary.Persistencia
{
    public class ConexionFirebase
    {
        
        private static ConexionFirebase instancia;
        public IFirebaseClient client;
        public IFirebaseConfig conexion;
        public ConexionFirebase() {
            
            conexion = new FirebaseConfig()
            {
                AuthSecret = "G8JyRbxDwLBglP0vwXdm7G0cX1Raa8nXQud4rtgw",
                BasePath = "https://quizify-62e37-default-rtdb.firebaseio.com/"
            };
        }

        public static ConexionFirebase getInstancia() 
        {
            if (instancia == null) 
            {
                instancia = new ConexionFirebase();
            }
            return instancia;
        }

    }
}
