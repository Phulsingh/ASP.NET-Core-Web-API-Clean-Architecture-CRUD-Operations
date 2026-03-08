using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Command
{
    public record UpdateEmployeeCommand(Guid employeeId, EmployeeEntity employee): IRequest<EmployeeEntity>;

    public class UpdateEmployeeCommandHandler(IEmployeeRepositery employeeRepositery)
    : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepositery.UpdateEmployeeAsync(request.employeeId, request.employee);
        }
    }
}
