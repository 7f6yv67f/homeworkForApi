using Microsoft.AspNetCore.Mvc;
using MSIT133Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _context;

        public ApiController(DemoContext context)
        {
            _context = context;
        }


        public IActionResult Index(string userName,string age)
        {
            System.Threading.Thread.Sleep(10000);
            if (String.IsNullOrEmpty(userName))
            {
                userName = "Ajax";
            }
            return Content($"Hello {userName}, You are {age} years old.", "text/plain", System.Text.Encoding.UTF8);
        }

        public IActionResult CheckName(string name)
        {
            //DemoContext db = new DemoContext();
            //db.Members.Where(m=>m.Name == name)
           // _context.Members.Where
            return Content("");
        }
    }
}
