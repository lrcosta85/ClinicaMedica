using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.Application.Interfaces;
using LR.ClinicaMedica.Application.Services;

namespace LR.ClinicaMedica.UI.Site.Controllers
{
    //[RoutePrefix("Cadastro")]
    public class PacientesController : Controller
    {
        private readonly IPacienteAppService _pacienteAppService;

        public PacientesController()
        {
            _pacienteAppService = new PacienteAppService();
        }

        //[Route("Listar-Todos")]
        // GET: Pacientes
        public ActionResult Index()
        {
            return View(_pacienteAppService.ObterTodos());
        }

        // GET: Pacientes/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pacienteViewModel = _pacienteAppService.ObterPorId(id.Value);

            if (pacienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(pacienteViewModel);
        }

        // GET: Pacientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PacienteViewModel pacienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _pacienteAppService.Adicionar(pacienteViewModel);
                return RedirectToAction("Create", "Agendas");
            }

            return View(pacienteViewModel);
        }

        // GET: Pacientes/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pacienteViewModel = _pacienteAppService.ObterPorId(id.Value);

            if (pacienteViewModel == null)
            {
                return HttpNotFound();
            }

            return View(pacienteViewModel);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PacienteViewModel pacienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _pacienteAppService.Atualizar(pacienteViewModel);
            }
            return View(pacienteViewModel);
        }

        // GET: Pacientes/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pacienteViewModel = _pacienteAppService.ObterPorId(id.Value);

            if (pacienteViewModel == null)
            {
                return HttpNotFound();
            }

            return View(pacienteViewModel);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _pacienteAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _pacienteAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
