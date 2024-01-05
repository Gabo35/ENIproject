using BO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TPPizza.Controllers
{
    public class PizzaController : Controller
    {

        private static List<Pizza> menu = new List<Pizza>()
        {
            new Pizza{ Id=1,Nom="Veggie",
                Pate=Pizza.PatesDisponibles[2],
                Ingredients=new List<Ingredient>
                {
                    Pizza.IngredientsDisponibles[0],
                    Pizza.IngredientsDisponibles[3],
                    Pizza.IngredientsDisponibles[5],
                    Pizza.IngredientsDisponibles[7]
                }
            },
            new Pizza{ Id=1,Nom="Ocean",
                Pate=Pizza.PatesDisponibles[1],
                Ingredients=new List<Ingredient>
                {
                    Pizza.IngredientsDisponibles[0],
                    Pizza.IngredientsDisponibles[5],
                    Pizza.IngredientsDisponibles[7]
                }
            }
        };


        // GET: PizzaController
        public ActionResult Index()
        {
            return View(menu);
        }

        // GET: PizzaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PizzaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaController/Create
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

        // GET: PizzaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaController/Edit/5
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

        // GET: PizzaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaController/Delete/5
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
