using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Management.CSAT.NPS.Application.Controllers.v1
{
    [Route("api/company/v1")]
    [ApiController]
    public class CompanyController : ApiControllerBase
    {
        public CompanyController(ISender mediator, ILogger<ApiControllerBase> logger) : base(mediator, logger)
        {
        }

        [HttpPost]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> PostCompanyAsync([FromBody] PostCompanyCommand company)
        {
            return await GenerateHttpResponseAsync(async () => await company, (int)HttpStatusCode.Created);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> PutCompanyAsync([FromBody] PutCompanyCommand company)
        {
            return await GenerateHttpResponseAsync(async () => await company, (int)HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(Unit), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteCompanyAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new DeleteCompanyCommand(id), (int)HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetCompanyQuery), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCompanyAsync(Guid id)
        {
            return await GenerateHttpResponseAsync(async () => await new GetCompanyQuery(id), (int)HttpStatusCode.OK);
        }
    }
}
