using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    //[Route("/helloworld")]
    public class SkillsController : Controller
    {
        [HttpGet("/skills")]
        public IActionResult Skills()
        {
            string html =
              @"<h1>Skills Tracker</h1>
                <h2>Coding Skills To Learn: </h2>
                <ol>
                    <li>C#</li>
                    <li>JavaScript</li>
                    <li>Python</li>
                </ol>



                <form method='post' action='/skills/form'>

                <label for='date'>Date:</label>
                <input type='date' id='date' name='date'>

                <label for='skill'>C#: </label>
                <select name='cSkillLvl' id='cSkillLvl'>
                    <option value='Learning basics'>Learning basics</option>
                    <option value='Making apps'>Making apps</option>
                    <option value='Master coder'>Master coder</option>
                </select>

                <form method='post' action='/skills/form'>
                <label for='skill'>JavaScript: </label>
                <select name='jSkillLvl' id='jSkillLvl'>
                    <option value='Learning basics'>Learning basics</option>
                    <option value='Making apps'>Making apps</option>
                    <option value='Master coder'>Master coder</option>
                </select>

                <form method='post' action='/skills/form'>
                <label for='skill'>Python: </label>
                <select name='pSkillLvl' id='pSkillLvl'>
                    <option value='Learning basics'>Learning basics</option>
                    <option value='Making apps'>Making apps</option>
                    <option value='Master coder'>Master coder</option>
                </select>
​
                <input type='submit' value='Submit'/>
                </form>";

            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        //[Route("/test")]
        public IActionResult SkillsForm(string date, string cSkillLvl, string jSkillLvl, string pSkillLvl)
        {
            return Content("<h1>" + date + "<h3>1. C#: " + cSkillLvl + "<h3>2. JavaScript: " + jSkillLvl + "<h3>3. Python: " + pSkillLvl + "</h3>", "text/html");
        }
    }
}
