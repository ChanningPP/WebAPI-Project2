using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project2.Controllers
{
    [Route("api/course")]
    public class CourseController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(SchoolDataStore.Instance().GetAllCourses());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(SchoolDataStore.Instance().GetCourseById(id));
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]CourseDTo newCourse)
        {
           SchoolDataStore.Instance().UpdateCourse(newCourse);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CourseDTo newCourse)
        {
            SchoolDataStore.Instance().AddCourse(newCourse);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SchoolDataStore.Instance().DeleteCourse(id);
        }
    }
}
