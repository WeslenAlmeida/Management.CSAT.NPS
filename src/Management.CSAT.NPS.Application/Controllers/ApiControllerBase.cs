using Management.CSAT.NPS.Domain.Common.v1;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Management.CSAT.NPS.Application.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        private readonly ISender _mediator;
        private readonly ILogger _logger;

        public ApiControllerBase(ISender mediator, ILogger<ApiControllerBase> logger)
        {
            _mediator = mediator;   
            _logger = logger;   
        }

        protected async Task<IActionResult> GenerateHttpResponseAsync(object obj, int statusCode)
        {
            try
            {
                _logger.LogInformation($"Start Api {DateTime.Now.ToLongTimeString}");

                var response =  await _mediator.Send(obj);

                _logger.LogInformation($"Return Api {DateTime.Now.ToLongTimeString}");

                return StatusCode(statusCode, response);

            }
            catch(CustomException ex)
            {
                _logger.LogWarning($"Warning: Status Code {ex.StatusCode} {DateTime.Now.ToLongTimeString}");

                return StatusCode(ex.StatusCode, ex.Value);
            }
            catch(Exception ex) 
            {
                _logger.LogError($"Error: Message {ex.Message} {DateTime.Now.ToLongTimeString}");

                return StatusCode(500, ex);
            }
        }
    }
}
