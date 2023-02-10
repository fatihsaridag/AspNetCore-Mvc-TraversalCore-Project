using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Mvc.CQRS.Queries.GuideQueries;
using TraversalCore.Mvc.CQRS.Results.GuideResults;

namespace TraversalCore.Mvc.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdResult>
    {
        private readonly Context _context;

        public GetGuideByIdQueryHandler(Context context)
        {
            _context= context;
        }


        public async Task<GetGuideByIdResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdResult
            {
                GuideId = request.Id,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
