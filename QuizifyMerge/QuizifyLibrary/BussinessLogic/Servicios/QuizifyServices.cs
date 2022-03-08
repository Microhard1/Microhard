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

        
    }
}
