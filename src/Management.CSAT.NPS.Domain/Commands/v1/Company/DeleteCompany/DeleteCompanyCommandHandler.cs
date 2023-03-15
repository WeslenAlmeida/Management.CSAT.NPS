using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Management.CSAT.NPS.Domain.Commands.v1.Company.DeleteCompany
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, DeleteCompanyCommandResponse>
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteCompanyCommand> _logger;
        public DeleteCompanyCommandHandler()
        {

        }
        public Task<DeleteCompanyCommandResponse> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
