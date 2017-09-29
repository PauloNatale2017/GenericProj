using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities.BaseEntity
{
    public class BaseEntity
    {

        public BaseEntity()
        {
        }

        public int Id { get; set; }
        public DateTime DataCreate { get; set; }
        public DateTime DataUpdate { get; set; }     
    }
}
