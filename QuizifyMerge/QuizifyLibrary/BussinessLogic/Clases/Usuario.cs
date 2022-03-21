using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Clases
{
    public class Usuario
    {
        public string Username;
        public string Password;

        public Usuario() 
        { 
        
        }
        public Usuario(string nUsuario, string passUsuario) {

            this.Username = nUsuario;
            this.Password = passUsuario;
            
        }
    }
}
