using EcoleBusiness.Services;
using EcoleBusiness.Services.IServices;
using EcoleMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcoleMVC.Controllers
{
    public class EleveController : Controller
    {
        private readonly IElevesService eleveService;

        public EleveController(IElevesService elService)
        {
            eleveService = elService;
        }

        // GET: EleveController
        public ActionResult Index()
        {
            var eleves = eleveService.GetEleves();
            var vms = eleves.Select(e => new EleveViewModel(e));
            return View(vms);
        }

        // GET: EleveController/Details/5
        public ActionResult Details(int id)
        {
            var eleve = eleveService.GetEleveById(id);
            var vm = new EleveViewModel(eleve);
            vm.IsDetail = true;
            return View(vm);
        }

        // GET: EleveController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EleveController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EleveViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    eleveService.InsertOrUpdateEleve(vm.MonModel);
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(vm);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }

        // GET: EleveController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EleveController/Edit/5
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

        // GET: EleveController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EleveController/Delete/5
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
