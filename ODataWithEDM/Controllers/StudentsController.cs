using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataWithEDM.Models;

namespace ODataWithEDM.Controllers
{
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Hassan Habib",
                    Score = 100
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Cody Allen",
                    Score = 90
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Sandeep Pal",
                    Score = 120
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "David Pullara",
                    Score = 50
                },
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
