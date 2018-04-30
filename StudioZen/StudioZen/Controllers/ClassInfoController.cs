using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using StudioZen.Models;
using StudioZen.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudioZen.Controllers
{
    public class ClassInfoController : Controller
    {
		
        // GET: /<controller>/
        public IActionResult Index()
        {
			List<ClassInfo> classinfo = ClassInfoData.GetAll();

            return View(classinfo);
        }

		public IActionResult Add()

		{
			AddClassInfoViewModel addClassInfoViewModel = new AddClassInfoViewModel();
			return View(addClassInfoViewModel);
		}

		[HttpPost]
		[Route("ClassInfo/Add")]
		public IActionResult Add(AddClassInfoViewModel addClassInfoViewModel)
		{
			if (ModelState.IsValid)
			{
				ClassInfo classInfo = new ClassInfo
				{
					Name = addClassInfoViewModel.Name,
					StartDate = addClassInfoViewModel.StartDate,
					EndDate = addClassInfoViewModel.EndDate,
					MaximumSpots = addClassInfoViewModel.MaximumSpots
				};
				ClassInfoData.Add(classInfo);
				return Redirect("/ClassInfo");
			}
			return View(addClassInfoViewModel);
			
		}

	}
}
