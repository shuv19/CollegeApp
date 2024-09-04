using CollegeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
             return CollegeRepository.Students;
        }
        [HttpGet("{id:int}")]
        public Student GetStudentID(int id)
        {
            return CollegeRepository.Students.Where(n=>n.Id==id).FirstOrDefault();
         
        }
        [HttpGet("{name}")]
        public Student GetStudentName(string name)
        {
            return CollegeRepository.Students.Where(n => n.StudentName == name).FirstOrDefault();
        }

        [HttpGet("{email}")]
        public Student GetStudentDeletes(string email)
        {
            return CollegeRepository.Students.Where(n => n.Email == email).FirstOrDefault();
        }


        [HttpDelete]
        public bool  GetStudentDelete(int id)
            
        {
            var student= CollegeRepository.Students.Where(n => n.Id == id).FirstOrDefault();
            CollegeRepository.Students.Remove(student);
            return true;
        }
    }
}
