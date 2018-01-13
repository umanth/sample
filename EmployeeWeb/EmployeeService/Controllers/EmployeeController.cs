using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Models;
using EmployeeService.Service;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }


        [HttpGet]
        public IEnumerable<EmployeeViewModel> Get()
        {
            return _service.GetEmployees();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public EmployeeViewModel Get(int id)
        {
            return _service.GetEmployees().FirstOrDefault(e => e.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<EmployeeViewModel> Post([FromBody]EmployeeViewModel value)
        {
            return _service.SaveEmployee(value);
        }
    }
}
