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


    }
}
