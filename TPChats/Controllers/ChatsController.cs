﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TPChats.Models;

namespace TPChats.Controllers
{
    public class ChatsController : Controller
    {
        // GET: ChatsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChatsController/Details/5
        public ActionResult Details(int id)
        {
            var chat = id;
            return View(chat);
        }

        // GET: ChatsController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: ChatsController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ChatsController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        // POST: ChatsController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: ChatsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChatsController/Delete/5
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
