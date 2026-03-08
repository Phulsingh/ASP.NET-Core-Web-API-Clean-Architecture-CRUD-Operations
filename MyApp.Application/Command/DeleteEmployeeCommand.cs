using MediatR;
using MyApp.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Command
{
    public record DeleteEmployeeCommand(Guid employeeId) : IRequest<bool>;
 
    internal class DeleteEmployeeCommandHandler(IEmployeeRepositery employeeRepositery) : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
           return  await employeeRepositery.DeleteEmployeeAsync(request.employeeId);
        }
    }
}
