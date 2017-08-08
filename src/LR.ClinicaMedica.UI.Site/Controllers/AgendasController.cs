using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LR.ClinicaMedica.Application.ViewModels;
using LR.ClinicaMedica.UI.Site.Models;
using LR.ClinicaMedica.Application.Interfaces;
using LR.ClinicaMedica.Application.Services;

namespace LR.ClinicaMedica.UI.Site.Controllers
{
    public class AgendasController : Controller
    {
        private readonly IAgendaAppService _agendaAppService;


        private IAgendaClientService db = new IAgendaClientService();

        public AgendasController()
        {
            _agendaAppService = new AgendaAppService();
        }

        // GET: Agendas
        public ActionResult Index()
        {
            return View(_agendaAppService.ObterPorData(DateTime.Now.Date));
        }

        // GET: Agendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgendaViewModel agendaViewModel)
        {
            if (ModelState.IsValid)
            {
                _agendaAppService.Adicionar(agendaViewModel);
                return RedirectToAction("Index");
            }

            return View(agendaViewModel);
        }

        // GET: Agendas/Delete/5
        //public ActionResult Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var agendaViewModel = _agendaAppService.ObterPorPaciente(id.Value);
            
        //    if (pacienteViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(pacienteViewModel);
        //}

        // POST: Agendas/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(Guid id)
        //{
        //    AgendaViewModel agendaViewModel = db.AgendaViewModels.Find(id);
        //    db.AgendaViewModels.Remove(agendaViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _agendaAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
