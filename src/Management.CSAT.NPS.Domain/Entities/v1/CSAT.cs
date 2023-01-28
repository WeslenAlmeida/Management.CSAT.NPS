using Management.CSAT.NPS.Domain.Interfaces.v1;

namespace Management.CSAT.NPS.Domain.Entities.v1
{
    public class CSAT : IEntity
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public Int16 AssessmentOne { get; set; }
        public string? CommentAssessmentOne { get; set; }
        public Int16 AssessmentTwo { get; set; }
        public string? CommentAssessmentTwo { get; set; }
        public Int16 AssessmentThree { get; set; }
        public string? CommentAssessmentThree { get; set; }
        public Int16 AssessmentFour { get; set; }
        public string? CommentAssessmentFour { get; set; }
        public Int16 AssessmentFive { get; set; }
        public string? CommentAssessmentFive { get; set; }
    }
}
