using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Events;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EventsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        // GET api/events
        [HttpGet("")]
        public async Task<ActionResult<List<Event>>> GetAllToList()
        {
            return await _mediator.Send(new List.Query());
        }

    }
}