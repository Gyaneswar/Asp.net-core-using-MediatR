using AutoMapper;
using MediatoR_EX.Interfaces;
using MediatoR_EX.Models;
using MediatoR_EX.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatoR_EX.Handlers
{
    public class GetAllOrdersHandler : IRequestHandler<GetAllOrdersQuery, List<Order>>
    {
        private readonly IRepo _repo;
        private readonly IMapper _mapper;
        public GetAllOrdersHandler(IRepo repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        async Task<List<Order>> IRequestHandler<GetAllOrdersQuery, List<Order>>.Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = _repo.GetAllOrders();
            return orders;
        }
    }
}
