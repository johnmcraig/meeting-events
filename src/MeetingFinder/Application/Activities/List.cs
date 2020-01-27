using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities
{
    public class List
    {
        /* Query using MediatR */
        public class Query : IRequest<List<Activity>> {}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataDbContext _dbContext;
            
            public Handler(DataDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<List<Activity>> Handle(Query request, 
            CancellationToken cancellationToken)
            {
                var activities = await _dbContext.Activities.ToListAsync();

                return activities;
            }
        }
    }
}