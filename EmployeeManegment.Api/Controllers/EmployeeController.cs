using EmployeeManegment.Api.Models;
using EmployeeMenagment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManegment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Employee>>> SearchEmployees(string name,Gender? gender)
        {
            try
            {
               var results=  await this.employeeRepository.SearchEmployees(name,gender);
                if (results.Any())
                    return Ok(results);
                return NotFound();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "canot fount the data resourses");
            }
        }
        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return Ok(await this.employeeRepository.GetEmployees());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "canot fount the data resourses");
            }
        }
        [HttpGet("{id:int}",Name ="GET")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var result= await employeeRepository.GetEmployee(id);
                if (result == null)
                    return NotFound();
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "canot fount the data resourses");

            }
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee([FromBody]Employee employee)
        {
            try
            {if (employee == null)
                    return BadRequest();
                var empemail = await employeeRepository.GetByEmail(employee.Email);
                if(empemail!=null)
                {
                    ModelState.AddModelError("email", "employee email in use");
                    return BadRequest(ModelState);
                }
             var emp=await   employeeRepository.AddEmployee(employee);
                //return CreatedAtAction(nameof(GetEmployee),emp.EmployeeId,emp);
                return emp;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "error by creating new employee");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id,[FromBody] Employee employee)
        {
            if (employee.EmployeeId != id)
            {
                return BadRequest("employee id mismach");
            }
            var emp =await employeeRepository.GetEmployee(id);
            if (emp == null)
                return NotFound($"employee with id: {id} not found");
            return await employeeRepository.UpdateEmployee(employee);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            var emp =await employeeRepository.GetEmployee(id);
            if (emp == null)
                return NotFound($"not found the employee with id :{id}");
           return await employeeRepository.DeleteEmployee(id);
        }
    }
}
