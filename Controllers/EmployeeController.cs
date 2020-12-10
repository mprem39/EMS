using EMS.Models;
using EMS.ViewModels;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System;
using System.Net;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeController()
        {
            this._dbContext = new EmployeeDbContext();
        }
        // GET: Employee  
        public ActionResult Index()
        {
            var employeeList = this._dbContext.Employee.Include(c => c.Department).ToList();
            return View(employeeList);
        }


        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_dbContext.Department, "DepartmentId", "DepartmentName");
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Employee.Add(employee);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(_dbContext.Department, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _dbContext.Employee.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(_dbContext.Department, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeId,EmployeeName,EmployeeDesignation,EmployeeAddress,EmployeePassport,EmployeePhone,EmployeeGender,City,Project,CompanyName,PinCode,DepartmentId")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Entry(employee).State = EntityState.Modified;
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(_dbContext.Department, "DepartmentId", "DepartmentName", employee.DepartmentId);
            return View(employee);
        }

      
        public ActionResult Delete(int id)
        {
            var employeeDb = this._dbContext.Employee.FirstOrDefault(x => x.EmployeeId == id);
            this._dbContext.Employee.Remove(employeeDb);
            this._dbContext.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }
    }
}