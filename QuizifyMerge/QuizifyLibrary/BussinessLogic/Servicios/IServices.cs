using FireSharp.Response;
using Quizify.BussinessLogic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizify.BussinessLogic.Servicios
{
    interface IServices
    {
         Alumno GetAlumnoById(string username);
         Instructor GetInstructorById(string username);
         void RegistrarInstructor(string nombreInstructor, string primerApellido,
                                        string segundoApellido, string contrasenya, string email);
         void RegistrarAlumno(string nombreAlumno, string primerApellido,
                                        string segundoApellido, string contrasenya, string email);
         Boolean UsuarioExiste(string nombreUsuario);
         Boolean EsAlumno(string nombreUsuario);
         Boolean VerificarCredenciales(string nombreUsuario, string contrasenya);
         void RegistrarPreguntaVerdaderoFalso(PreguntaVerdaderoFalso pregunta);

        int ContarElementosBDD(FirebaseResponse datosBDD);
        int ContarQuizes(FirebaseResponse datosBDD);
        int contarPreguntasQuiz(FirebaseResponse datosBDD);
    }
}
