using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Entities.v1
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
    }
}
