using ShopStar.Order.Application.Features.CQRS.Queries.AddressQueries;
using ShopStar.Order.Application.Features.CQRS.Results.AddressResults;
using ShopStar.Order.Application.Interfaces;
using ShopStar.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            { 
                AddressId = values.AddressId,
                City = values.City, 
                Detail = values.Detail, 
                District = values.District,
                UserId = values.UserId 
            };
        }
    }
}
