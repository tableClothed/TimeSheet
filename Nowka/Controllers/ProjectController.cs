using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nowka.Data;

namespace Nowka.Controllers
{
    public class ProjectController : Controller
    {
        public ApplicationDbContext _context;

        public ProjectController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public IActionResult Index()
        {
            var projects = _context;
            return View();
        }
    }
}