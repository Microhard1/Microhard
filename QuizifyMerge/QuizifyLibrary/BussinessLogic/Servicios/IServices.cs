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
        public void RegistrarPreguntaVerdaderoFalso(PreguntaVerdaderoFalso pregunta);
    }
}
