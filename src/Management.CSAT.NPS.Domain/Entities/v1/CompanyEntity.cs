using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Entities.v1
{
    public class CompanyEntity : IEntity
    {
        public Guid Id { get; set; }
        public string BussinesName { get; set; }
        public string Email { get; set; }
        public string? Region { get; set; }    
        public string? Channel { get; set; }    
    }
}
