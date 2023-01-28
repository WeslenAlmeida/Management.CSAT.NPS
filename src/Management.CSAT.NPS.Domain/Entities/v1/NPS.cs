using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Entities.v1
{
    public class NPS : IEntity
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Int16 AssessmentOne { get; set; }
        public string? CommentAssessmentOne { get; set; }
    }
}
