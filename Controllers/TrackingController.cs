﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VTSWebAPI.Controllers
{
    [Route("TrackingController")]
    [ApiController]
    public class TrackingController : ControllerBase
    {
        // GET: api/<TrackingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TrackingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TrackingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TrackingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrackingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
