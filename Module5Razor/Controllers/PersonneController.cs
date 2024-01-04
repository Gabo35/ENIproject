using Humanizer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Debugger.Contracts.HotReload;
using Module5Razor.Models;

namespace Module5Razor.Controllers
{
    public class PersonneController : Controller
    {
        // GET: PersonneController
        public ActionResult Index()
        {
            var personnes = new List<Personne>()
            {
                new Personne() { Nom="Yann Gaborit", Age=52,Id=1},
                new Personne() { Nom="Emile Louis", Age=80,Id=2},
                new Personne() { Nom="Michel Fourniret", Age=65,Id=3},
                new Personne() { Nom="Dark Vador", Age=800,Id=4},
            };
            return View(personnes);
        }

        // GET: PersonneController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonneController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonneController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonneController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonneController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
