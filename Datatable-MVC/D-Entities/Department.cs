﻿namespace Datatable_MVC.D_Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
