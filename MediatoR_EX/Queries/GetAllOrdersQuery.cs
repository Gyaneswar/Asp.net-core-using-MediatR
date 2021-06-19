using MediatoR_EX.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatoR_EX.Queries
{
    public class GetAllOrdersQuery : IRequest<List<Order>>
    {

    }
}
