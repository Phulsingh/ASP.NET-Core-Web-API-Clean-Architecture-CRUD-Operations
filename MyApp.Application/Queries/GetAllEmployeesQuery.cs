using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interface;


namespace MyApp.Application.Queries
{
    public record GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeEntity>>;
   
        public class GetAllEmployeesQueryHandler(IEmployeeRepositery employeeRepositery)
        : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
        {
            public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
            {
                return await employeeRepositery.GetEmployees();
            }
    }
}
