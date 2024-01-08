using BO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using TPPizza.Models;

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
            new Pizza{ Id=2,Nom="Ocean",
                Pate=Pizza.PatesDisponibles[1],
                Ingredients=new List<Ingredient>
                {
                    Pizza.IngredientsDisponibles[0],
                    Pizza.IngredientsDisponibles[5],
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
            Pizza? pizza = menu.FirstOrDefault(c => c.Id == id);
            if (pizza == null) return NotFound();
            return View(pizza);
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
            Pizza? pizza = menu.FirstOrDefault(c => c.Id == id);
            if (pizza == null) return NotFound();

            ViewBag.PateList = Pizza.PatesDisponibles.ToList();
            ViewBag.SelectedPate = pizza.Pate.Nom;

            return View(pizza);
        }

        // POST: PizzaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Pizza pizzaForm)
        {
            try
            {
                int pizzaBddIndex = menu.FindIndex(x => x.Id == id);
                if (pizzaBddIndex == -1) return NotFound();
                menu[pizzaBddIndex].Nom = pizzaForm.Nom;
                menu[pizzaBddIndex].Pate = pizzaForm.Pate;
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
            Pizza? pizza = menu.FirstOrDefault(c => c.Id == id);
            if (pizza == null) return NotFound();
            return View(pizza);
        }

        // POST: PizzaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Pizza? pizza = menu.FirstOrDefault(c => c.Id == id);
                if (pizza == null) return NotFound();
                menu.Remove(pizza);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
