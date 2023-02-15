using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Management.CSAT.NPS.Application.Controllers.v1
{
    [Route("api/user/v1")]
    [ApiController]
    public class UserController : ApiControllerBase
    {
        public UserController(ISender mediator, ILogger<ApiControllerBase> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> PostUserAsync([FromBody] PostUserCommand user)
        {
            return await GenerateHttpResponseAsync(async () => await user, (int)HttpStatusCode.Created);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PutUserAsync([FromBody] PutUserCommand user)
        {
            return await GenerateHttpResponseAsync(async () => await user, (int)HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteUserAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new DeleteUserCommand(id), (int)HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserQuery), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetUserAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new GetUserQuery(id), (int)HttpStatusCode.OK);
        }
    }
}
