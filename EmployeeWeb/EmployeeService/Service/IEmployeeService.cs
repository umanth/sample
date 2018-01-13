using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Service
{
    public interface IEmployeeService
    {
        List<EmployeeViewModel> GetEmployees();
        List<EmployeeViewModel> SaveEmployee(EmployeeViewModel emp);
    }

    public class EmpService : IEmployeeService
    {
        static List<EmployeeViewModel> List = new List<EmployeeViewModel>
           {
               new EmployeeViewModel
               {
                   Id =1,
                   Name ="Test 1"
               },
               new EmployeeViewModel
               {
                   Id =2,
                   Name ="Test 2"
               }
           };
        public List<EmployeeViewModel> GetEmployees()
        {
            return List;
        }

        public List<EmployeeViewModel> SaveEmployee(EmployeeViewModel emp)
        {
            List.Add(emp);
            return List;

        }
    }
}
