using Datatable_MVC.D_Entities;
using Datatable_MVC.D_Entities.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Datatable_MVC.Controllers
{
    public class DatatableBreakupController : Controller
    {
        private readonly Datatable _dbContext;
        public DatatableBreakupController(Datatable dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var departments = _dbContext.Departments.ToList();
            return View(departments);
        }

        [HttpGet("{id}")]
        public ActionResult<Department> GetDepartmentById(int id)
        {
            var department = _dbContext.Departments.Include(d => d.Employees).FirstOrDefault(d => d.DepartmentId == id);
            if (department == null)
            {
                return NotFound();
            }
            return department;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployeesByDepartmentId(int departmentId)
        {
            try
            {
                var employees = _dbContext.Employees.Where(e => e.DepartmentId == departmentId).ToList();
                return Json(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
