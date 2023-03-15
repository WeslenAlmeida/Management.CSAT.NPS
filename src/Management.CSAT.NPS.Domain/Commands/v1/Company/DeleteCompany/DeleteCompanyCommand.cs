using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Commands.v1.Company.DeleteCompany
{
    public class DeleteCompanyCommand : ICommand<DeleteCompanyCommandResponse>
    {
        public Guid IdCompany { get; set; }    
        public DeleteCompanyCommand(Guid id)
        {
            IdCompany = id;
        }
    }
}
