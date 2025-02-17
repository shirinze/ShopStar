using MediatR;
using ShopStar.Order.Application.Features.Meditor.Results.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStar.Order.Application.Features.Meditor.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery:IRequest<GetOrderingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
