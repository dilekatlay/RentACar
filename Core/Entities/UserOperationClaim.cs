using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserOperationClaim : Entity<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public UserOperationClaim(int ıd, int userId, int operationClaimId)
        {
            Id = ıd;
            UserId = userId;
            OperationClaimId = operationClaimId;
        }

        public UserOperationClaim()
        {
        }
    }
}
