using QuizifyLibrary.BussinessLogic.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizifyLibrary.Persistencia;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace QuizifyLibrary.BussinessLogic.Servicios
{
    class QuizifyServices : IServices
    {
        private readonly ConexionFirebase c;
        
        public QuizifyServices(ConexionFirebase c)
        {
            this.c = c;
        }
        public Alumno GetAlumnoById(string username) 
        {
            var result = c.client.Get("Alumnos/" + username);
            Alumno alu = result.ResultAs<Alumno>();
            alu.Username = username;
            return alu;
            
        }
        public Instructor GetInstructorById(string username)
        {
            var result = c.client.Get("Alumnos/" + username);
            Instructor ins = result.ResultAs<Instructor>();
            ins.Username = username;
            return ins;
        }

        public void RegistrarInstructor(string nombreInstructor, string primerApellido,
                                        string segundoApellido, string contrasenya, string email)
        {
            Instructor ins = new Instructor(nombreInstructor, contrasenya);
            SetResponse set = c.client.Set("Instructor/" + nombreInstructor, ins);
        }
        public void RegistrarAlumno(string nombreAlumno, string primerApellido,
                                        string segundoApellido, string contrasenya, string email)
        {
            Instructor alumno = new Instructor(nombreAlumno, contrasenya);
            SetResponse set = c.client.Set("Instructor/" + nombreAlumno, alumno);
        }
        public Boolean UsuarioExiste(string nombreUsuario)
        {
            Alumno alu = GetAlumnoById(nombreUsuario);
            Instructor ins = GetInstructorById(nombreUsuario);
            if(alu == null && ins == null)
            {
                return false;
            }
            return true;
        }
        public Boolean EsAlumno(string nombreUsuario) 
        {
            if(GetAlumnoById(nombreUsuario) == null) { return false; }
            return true;
        }
        public Boolean VerificarCredenciales(string nombreUsuario, string contrasenya) 
        {
                if (EsAlumno(nombreUsuario))
                {
                    Alumno alu = GetAlumnoById(nombreUsuario);
                    return contrasenya == alu.Password;
                }
                else
                {
                    Instructor ins = GetInstructorById(nombreUsuario);
                    return contrasenya == ins.Password;
                }
        }

        public void RegistrarPregunta()
        {

        }

        public void RegistrarPreguntaVerdaderoFalso(PreguntaVerdaderoFalso pregunta)
        {
            c.client.Set(@"Pregunta/VerdaderoFalso",pregunta);
        }
        public void ClonarQuiz(Quiz quiz, Instructor ins)
        {
            ins.addQuiz(quiz);
        }
    }
}
