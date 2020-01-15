using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Activitys
{
    public class List
    {
        /* Query using MediatR */
        public class Query : IRequest<List<Activity>> {}

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataDbContext _dbContext;
            private readonly ILogger<List> _logger;
            
            public Handler(DataDbContext dbContext, ILogger<List> logger)
            {
                _logger = logger;
                _dbContext = dbContext;
            }

            public async Task<List<Activity>> Handle(Query request, 
            CancellationToken cancellationToken)
            {
                // try
                // {
                //     for(var i=0; i<10; i++)
                //     {
                //         cancellationToken.ThrowIfCancellationRequested();
                //         await Task.Delay(100, cancellationToken);
                //         _logger.LogInformation($"Task {i} has completed");
                //     }
                // }
                // catch (System.Exception ex) when (ex is TaskCanceledException) 
                // {
                //     _logger.LogInformation("Task was cancelled");
                // }

                var Activitys = await _dbContext.Activities.ToListAsync();

                return Activitys;
            }
        }
    }
}