using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DI.Models;
using DI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.BuscarPeliculas());
        }

        public IActionResult Detalles(int id)
        {
            return View(this.repo.BuscarPeliculaPorId(id));
        }
    }
}
