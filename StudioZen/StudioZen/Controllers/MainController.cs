using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudioZen.Controllers
{
    public class MainController : Controller
    {
        // GET: /<controller>/
		[HttpGet]
        public IActionResult Index()
        {
			
            return View();
        }
		public IActionResult ClassSchedule()
		{
			return View();
		}
		public IActionResult ClassInfo()
		{
			return View();
		}
		public IActionResult DisplayInstructors()
		{
			return View();
		}
			
	}

}
