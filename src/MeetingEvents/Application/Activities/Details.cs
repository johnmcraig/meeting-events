using System;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class Details
    {
        public class Query : IRequest<Activity>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Activity>
        {
            private readonly DataDbContext _dbContext;

            public Handler(DataDbContext dbContext)
            {
                _dbContext = dbContext;
            }

            public async Task<Activity> Handle(Query request,
            CancellationToken cancellationToken)
            {
                var singleActivity = await _dbContext.Activities.FindAsync(request.Id);

                return singleActivity;
            }
        }
    }
}