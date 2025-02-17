
using ShopStar.Order.Application.Features.CQRS.Commands.OrderDetailCommnads;
using ShopStar.Order.Application.Interfaces;
using ShopStar.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateOrderDetailCommand Command)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                OrderingId = Command.OrderingId,
                ProductAmount = Command.ProductAmount,
                ProductId = Command.ProductId,
                ProductName = Command.ProductName,
                ProductPrice = Command.ProductPrice,
                ProductTotalPrice = Command.ProductTotalPrice
            });
        }
    }
}
