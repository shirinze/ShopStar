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
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.UserId=command.UserId;
            values.District = command.District;
            values.Detail = command.Detail;
            values.City = command.City;
            await _repository.UpdateAsync(values);
        }
    }
}
