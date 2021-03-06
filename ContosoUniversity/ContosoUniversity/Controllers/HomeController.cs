﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {

		private readonly Data.ApplicationDbContext _context;

		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
			IQueryable<EnrollmentDateGroup> data =
				from student in _context.Students
				group student by student.EnrollmentDate into dateGroup
				select new EnrollmentDateGroup()
				{
					EnrollmentDate = dateGroup.Key,
					StudentCount = dateGroup.Count()
				};

            return View(await data.AsNoTracking().ToListAsync());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
