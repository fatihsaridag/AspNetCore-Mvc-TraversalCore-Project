using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Mvc.CQRS.Queries.GuideQueries;
using TraversalCore.Mvc.CQRS.Results.GuideResults;

namespace TraversalCore.Mvc.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler : IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;

        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuideId = x.GuideId,
                Name= x.Name,
                Description= x.Description,
                Image = x.Image
            }).AsNoTracking().ToListAsync();
        }
    }
}
