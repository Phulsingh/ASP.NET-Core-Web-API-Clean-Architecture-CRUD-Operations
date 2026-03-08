using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.Command;
using MyApp.Application.Queries;
using MyApp.Core.Entities;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddEmployeeAsync(EmployeeEntity employee)
        {
            var result = await sender.Send(new AddEmployeeCommand(employee));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            var result = await sender.Send(new GetAllEmployeesQuery());
            return Ok(result);
        }

        [HttpGet("{employeeId}")]
        public async Task<IActionResult> GetEmployeeByIdAsync(Guid employeeId)
        {
            var result = await sender.Send(new GetEmployeeByIdQuery(employeeId));
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut("{employeeId}")]
        public async Task<IActionResult> UpdateEmployeeAsync( Guid employeeId, [FromBody] EmployeeEntity employee)
        {
            var result = await sender.Send(new UpdateEmployeeCommand(employeeId, employee));
            return Ok(result);

        }

        [HttpDelete("{employeeId}")]
        public async Task<IActionResult> DeleteEmployeeAsync( Guid employeeId)
        {
            var result = await sender.Send(new DeleteEmployeeCommand(employeeId));
            if (result)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
