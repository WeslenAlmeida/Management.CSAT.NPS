using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Management.CSAT.NPS.Application.Controllers.v1
{
    [Route("api/csat/v1")]
    [ApiController]
    public class CSATController : ApiControllerBase
    {
        public CSATController(ISender mediator, ILogger<ApiControllerBase> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> PostCsatAsync([FromBody] PostCsatCommand csat)
        {
            return await GenerateHttpResponseAsync(async () => await csat, (int)HttpStatusCode.Created);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PutCsatAsync([FromBody] PutCsatCommand csat)
        {
            return await GenerateHttpResponseAsync(async () => await csat, (int)HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteCsatAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new DeleteCsatCommand(id), (int)HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetCsatQuery), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCsatAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new GetCsatQuery(id), (int)HttpStatusCode.OK);
        }
    }
}

