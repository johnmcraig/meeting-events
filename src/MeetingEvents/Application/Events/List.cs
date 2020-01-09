using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Events
{
    public class List
    {
        /* Query using MediatR */
        public class Query : IRequest<List<Event>> {}

        public class Handler : IRequestHandler<Query, List<Event>>
        {
            private readonly DataDbContext _dbContext;
            
            public Handler(DataDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<Event>> Handle(Query request, 
            CancellationToken cancellationToken)
            {
                var events = await _dbContext.Events.ToListAsync();

                return events;
            }
        }
    }
}