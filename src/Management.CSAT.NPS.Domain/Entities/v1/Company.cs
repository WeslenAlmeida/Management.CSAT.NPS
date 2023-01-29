using Management.CSAT.NPS.Domain.Interfaces.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.CSAT.NPS.Domain.Entities.v1
{
    public class Company : IEntity
    {
        public Guid Id { get; set; }
        public string BussinesName { get; set; }
        public string Email { get; set; }
        public string? Region { get; set; }    
        public string? Channel { get; set; }    
    }
}
