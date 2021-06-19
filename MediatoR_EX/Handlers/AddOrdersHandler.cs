using MediatoR_EX.Commands;
using MediatoR_EX.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatoR_EX.Handlers
{    
    public class AddOrdersHandler : IRequestHandler<AddOrderCommand, bool>
    {
        private readonly IRepo _repo;

        public AddOrdersHandler(IRepo repo)
        {
            _repo = repo;
        }

        async Task<bool> IRequestHandler<AddOrderCommand, bool>.Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var result = _repo.AddOrder(request.Item);
            return result;
        }
    }
}
