using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project2.Controllers
{
    [Route("api/student")]
    public class StudentController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(SchoolDataStore.Instance().GetAllStudents());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public StudentDTo Get(int id)
        {
            return SchoolDataStore.Instance().GetStudentById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]StudentDTo value)
        {
           SchoolDataStore.Instance().UpdateStudent(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]StudentDTo value)
        {
            SchoolDataStore.Instance().AddStudent(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SchoolDataStore.Instance().DeleteStudent(id);
        }
    }
}
