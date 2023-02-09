using Microsoft.AspNetCore.Mvc;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Mvc.CQRS.Commands.DestinationCommands;

namespace TraversalCore.Mvc.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context= context;
        }

        [HttpGet]
        public void Handle(UpdateDestinationCommand command)
        {
             var values = _context.Destinations.Find(command.DestinationId);
             values.City = command.City;
             values.DayNight = command.DayNight;
             values.Price = command.Price;
             _context.Update(values);
             _context.SaveChanges();

        }



    }
}
