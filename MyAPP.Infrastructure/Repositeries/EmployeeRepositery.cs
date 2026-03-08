using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interface;
using MyApp.Infrastructure.Data;


namespace MyApp.Infrastructure.Repositeries
{
    public class EmployeeRepositery(AppDbContext dbContext) : IEmployeeRepositery
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeById(Guid id)
        {
            return await dbContext.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity entity)
        {
            entity.Id = Guid.NewGuid();
            dbContext.Employees.Add(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid employeeId, EmployeeEntity entity)
        {
            var existingEmployee = await dbContext.Employees.FirstOrDefaultAsync(e => e.Id == employeeId);

            if (existingEmployee is not null)
            {
                existingEmployee.Name = entity.Name;
                existingEmployee.Email = entity.Email;
                existingEmployee.Phone = entity.Phone;

                await dbContext.SaveChangesAsync();
                return existingEmployee;
            }
            return entity;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid employeeId)
        {
            employeeId = Guid.NewGuid();
            var existingEmployee = await dbContext.Employees.FirstOrDefaultAsync(e => e.Id == employeeId);
            if( existingEmployee is not null)
            {
                dbContext.Employees.Remove(existingEmployee);
                return await dbContext.SaveChangesAsync() > 0 ;
                
            }
            return false;

        }
    }
}
