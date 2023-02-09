using System;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Mvc.CQRS.Queries.DestinationQueries;
using TraversalCore.Mvc.CQRS.Results.DestinationResults;

namespace TraversalCore.Mvc.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;
        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryHandler(int id)
        {
            İd = id;
        }

        public int İd { get; }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIdQueryResult
            {
                DestinationId = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
