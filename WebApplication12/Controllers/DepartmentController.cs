using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;
using WebApplication12.Services;

namespace WebApplication12.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }
        // GET: EmpolyeeController
        public ActionResult Index()
        {

            return View(departmentRepository.GetALL());
        }


        public ActionResult Details(int id)
        {
            return View(departmentRepository.Details(id));
        }

        // GET: EmpolyeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpolyeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department dep)
        {
            if(ModelState.IsValid)
            {
                departmentRepository.Add(dep);
                departmentRepository.Save();

                return RedirectToAction(nameof(Index));
            }
            else
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
        public ActionResult Edit(int id, Department dep)
        {
            if(ModelState.IsValid)
            {
                departmentRepository.Update(dep);
                departmentRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: EmpolyeeController/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(departmentRepository.Details(id));
        }

        // POST: EmpolyeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if(ModelState.IsValid)
            {
                departmentRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
