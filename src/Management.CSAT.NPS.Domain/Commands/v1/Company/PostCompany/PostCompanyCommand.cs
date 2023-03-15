using Management.CSAT.NPS.Domain.Commands.v1.Company.PostCompany;
using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Commands.v1.Company.CreateCompany
{
    public class PostCompanyCommand : ICommand<PostCompanyCommandResponse>
    {
        public string BussinesName { get; set; }
        public string Email { get; set; }
        public string? Region { get; set; }
        public string? Channel { get; set; }
    }
}
