using QuizifyLibrary.BussinessLogic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifyLibrary.BussinessLogic.Servicios
{
    interface IServices
    {
        public Alumno GetAlumnoById(string username);
        public Instructor GetInstructorById(string username);
        public void RegistrarInstructor(string nombreInstructor, string primerApellido,
                                        string segundoApellido, string contrasenya, string email);
        public void RegistrarAlumno(string nombreAlumno, string primerApellido,
                                        string segundoApellido, string contrasenya, string email);
        public Boolean UsuarioExiste(string nombreUsuario);
        public Boolean EsAlumno(string nombreUsuario);
        public Boolean VerificarCredenciales(string nombreUsuario, string contrasenya);
        public void RegistrarPreguntaVerdaderoFalso(PreguntaVerdaderoFalso pregunta);
    }
}
