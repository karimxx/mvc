using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using WebApplication12.Services;

namespace WebApplication12.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmpolyeeRepository empolyeeRepository;

        public EmployeeController(IEmpolyeeRepository empolyeeRepository)
        {
            this.empolyeeRepository = empolyeeRepository;
        }
        // GET: EmpolyeeController
        public ActionResult Index()
        {

            return View(empolyeeRepository.GetALL());
        }

        
        public ActionResult Details(int id)
        {
            return View(empolyeeRepository.Details(id));
        }

        // GET: EmpolyeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpolyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            try
            {
                empolyeeRepository.Add(emp);
                empolyeeRepository.Save();
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpolyeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpolyeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                empolyeeRepository.Update(emp);
                empolyeeRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpolyeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpolyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Department dep)
        {
            try
            {
                empolyeeRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
