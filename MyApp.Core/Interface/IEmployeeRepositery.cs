using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interface
{
    public interface IEmployeeRepositery
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();

        Task<EmployeeEntity> GetEmployeeById(Guid id);

        Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity);

        Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity);

        Task<bool> DeleteEmployeeAsync(Guid employeeId);
    }
}
