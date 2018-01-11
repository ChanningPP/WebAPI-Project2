using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project2.Controllers
{
    [Route("api/lecturer")]
    public class LecturerController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(SchoolDataStore.Instance().GetAllLecturers());
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public LecturerDTo Get(int id)
        {
            return SchoolDataStore.Instance().GetLecturerById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]LecturerDTo value)
        {
            SchoolDataStore.Instance().UpdateLecturer(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]LecturerDTo value)
        {
            SchoolDataStore.Instance().AddLecturer(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SchoolDataStore.Instance().DeleteLecturer(id);
        }
    }
}
