using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interface;

namespace MyApp.Application.Command
{
    public record AddEmployeeCommand(EmployeeEntity Employee ): IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeRepositery employeeRepositery)
    : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public  async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepositery.AddEmployeeAsync(request.Employee);
        }
    }
}
