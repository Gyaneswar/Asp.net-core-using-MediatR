﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatoR_EX.Commands
{
    //Command class to be used in the handler
    public class AddOrderCommand : IRequest<bool>
    {
        public string Item { get; }
        public AddOrderCommand(string item)
        {
            Item = item;
        }

        
    }
}
