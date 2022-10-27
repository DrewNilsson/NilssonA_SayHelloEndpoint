//Andrew Nilsson
//10/25/22
//Say Hello
//This is a webapi that takes a string input and returns a string including the input
//Peer reviewed by: Jessie Lamzon - Code is working great and runs with no errors.  Does the required assignment.  Good Job!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_SayHelloEndpoint.Controllers
{
    [Route("[controller]")]

    public class SayHelloController : Controller
    {
        [HttpGet]
        [Route("Hello/{name}")]

        public string Hello(string name)
        {
            return $"Hello {name}";
        }
    }
}