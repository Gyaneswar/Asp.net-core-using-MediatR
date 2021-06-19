using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatoR_EX.Commands;
using MediatoR_EX.Models;
using MediatoR_EX.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatoR_EX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAllOrdersAsync()
        {        
            //create a new query to be sent to the handler
            var query =new GetAllOrdersQuery();

            //using mediatr to decouple things here.
            var result=await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AddOrdersAsync([FromBody] string item)
        {            
            //create a new command to be sent to the handler. It is a command as it is a insert statement.
            var command = new AddOrderCommand(item);
            var result = await _mediator.Send(command);

            return result!=false ? (IActionResult) Ok(result) : NotFound();
        }
    }
}
