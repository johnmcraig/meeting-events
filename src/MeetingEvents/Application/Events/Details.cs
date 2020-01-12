using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Events
{
    public class Details
    {
        public class Query : IRequest<Event>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Event>
        {
            private readonly DataDbContext _dbContext;

            public Handler(DataDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<Event> Handle(Query request, 
                CancellationToken cancellationToken)
            {
                var singleEvent = await _dbContext.Events.FindAsync(request.Id);

                return singleEvent;
            }
        }
    }
}