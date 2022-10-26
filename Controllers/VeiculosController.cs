﻿using Estacionamento.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Estacionamento.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly Contexto db;

        public VeiculosController(Contexto contexto)
        {
            db = contexto;
        }
        // GET: VeiculosController
        public ActionResult Index()
        {
            return View(db.VEICULOS.ToList());
        }

        // GET: VeiculosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VeiculosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VeiculosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Veiculos collection)
        {
            try
            {
                db.VEICULOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VeiculosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VeiculosController/Edit/5
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

        // GET: VeiculosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VeiculosController/Delete/5
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
