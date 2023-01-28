using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.CSAT.NPS.Domain.Interfaces.v1
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
