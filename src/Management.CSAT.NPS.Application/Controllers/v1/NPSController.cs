using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Management.CSAT.NPS.Application.Controllers.v1
{
    [Route("api/nps/v1")]
    [ApiController]
    public class NPSController : ApiControllerBase
    {
        public NPSController(ISender mediator, ILogger<ApiControllerBase> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> PostNpsAsync([FromBody] PostNpsCommand nps)
        {
            return await GenerateHttpResponseAsync(async () => await nps, (int)HttpStatusCode.Created);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PutNpsAsync([FromBody] PutNpsCommand nps)
        {
            return await GenerateHttpResponseAsync(async () => await nps, (int)HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteNpsAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new DeleteNpsCommand(id), (int)HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetNpsQuery), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetNpsAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new GetNpsQuery(id), (int)HttpStatusCode.OK);
        }
    }
}
