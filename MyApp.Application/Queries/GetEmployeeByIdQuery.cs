using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interface;


namespace MyApp.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid id) :IRequest<EmployeeEntity>;

    public class GetEmployeeByIdQueryHandler(IEmployeeRepositery employeeRepositery) : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepositery.GetEmployeeById(request.id);
        }
    }

}
