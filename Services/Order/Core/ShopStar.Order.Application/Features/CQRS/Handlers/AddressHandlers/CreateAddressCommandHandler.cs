using ShopStar.Order.Application.Features.CQRS.Commands.AddressCommands;
using ShopStar.Order.Application.Interfaces;
using ShopStar.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAddressCommand createaddressCommand)
        {
            await _repository.CreateAsync(new Address
            {
                City = createaddressCommand.City,
                Detail = createaddressCommand.Detail,
                District = createaddressCommand.District,
                UserId = createaddressCommand.UserId
            });
        }
    }
}
