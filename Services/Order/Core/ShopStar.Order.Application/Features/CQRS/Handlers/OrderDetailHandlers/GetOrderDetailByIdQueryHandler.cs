using ShopStar.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using ShopStar.Order.Application.Features.CQRS.Results.OrderDetailResults;
using ShopStar.Order.Application.Interfaces;
using ShopStar.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
                OrderDetailId = value.OrderDetailId,
                OrderingId = value.OrderingId,
                ProductAmount = value.ProductAmount,
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                ProductPrice = value.ProductPrice,
                ProductTotalPrice = value.ProductTotalPrice
            };
        }
    }
}
