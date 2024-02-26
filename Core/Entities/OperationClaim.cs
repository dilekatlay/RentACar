using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OperationClaim : Entity<int>
    {
        public OperationClaim()
        {
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public OperationClaim(string name, int ıd)
        {
            Name = name;
            Id = ıd;
        }
    }
}
