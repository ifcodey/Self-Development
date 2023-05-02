using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        HRDatabaseContext dbContext = new HRDatabaseContext();
        public IActionResult Index()
        {
            //List<Employee> employees = dbContext.Employees.ToList();
            var employees = (from employee in dbContext.Employees
                             join department in dbContext.Department on employee.Departmentid equals department.DepartmentId
                             select new Employee
                             {
                                 EmployeeId = employee.EmployeeId,
                                 EmployeeName = employee.EmployeeName,
                                 EmployeeNumber = employee.EmployeeNumber,
                                 DOB = employee.DOB,
                                 HiringDate= employee.HiringDate,
                                 NetSalary= employee.NetSalary,
                                 Departmentid= employee.Departmentid,
                                 DepartmentName = department.DepartmentName,
                             }).ToList();

            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Department = this.dbContext.Department.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            ModelState.Remove("EmployeeId");
            ModelState.Remove("Department");
            ModelState.Remove("DepartmentName");
            if (ModelState.IsValid)
            {
                dbContext.Employees.Add(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Department = this.dbContext.Department.ToList();
            return View();
        }

        public IActionResult Edit(int ID)
        {
            Employee data = this.dbContext.Employees.Where(e => e.EmployeeId == ID).FirstOrDefault();
            ViewBag.Department = this.dbContext.Department.ToList();
            return View("Create", data);
        }

        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            ModelState.Remove("EmployeeId");
            ModelState.Remove("Department");
            ModelState.Remove("DepartmentName");
            if (ModelState.IsValid)
            {
                dbContext.Employees.Update(model);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Department = this.dbContext.Department.ToList();
            return View("Create", model); ;
        }

        public IActionResult Delete(int ID)
        {
            Employee data = this.dbContext.Employees.Where(e => e.EmployeeId==ID).FirstOrDefault();
        if(data != null)
            {
                dbContext.Employees.Remove(data);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
