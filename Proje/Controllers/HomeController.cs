using Microsoft.AspNetCore.Mvc;
using Proje.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        Context c = new Context();

        public IActionResult Index()
        {
            //var ktp = new List<Kitap>(){
            //    new Kitap(){ Id = 1, Name ="Cihan",Description="İlkılıç"},
            //    new Kitap(){ Id = 2, Name ="Cihan2",Description="İlkılıç2"},
            //    new Kitap(){ Id = 3, Name ="Cihan3",Description="İlkılıç3"},
            //    new Kitap(){ Id = 4, Name ="Cihan4",Description="İlkılıç4"},
            //};

            //return View(ktp);
            var degeler = c.departmanlars.ToList();
            return View(degeler);
        }
        [HttpGet]
        public IActionResult YeniDepartman()
        {
           
            return View(); 
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c.departmanlars.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var deps = c.departmanlars.Find(id);
            c.departmanlars.Remove(deps);
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DepartmanGetir(int id)
        {
            var  depart = c.departmanlars.Find(id);
            return View("DepartmanGetir",depart);
        }
        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c.departmanlars.Find(d.Id);
            dep.departmanad = d.departmanad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}