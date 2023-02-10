using MediatR;
using TraversalCore.Mvc.CQRS.Results.GuideResults;

namespace TraversalCore.Mvc.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery : IRequest<GetGuideByIdResult>
    {
        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
