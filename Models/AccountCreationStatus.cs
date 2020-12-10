using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerServices.Models
{
    public class AccountCreationStatus
    {
        public int CustomerId { get; set; }
        public bool Message { get; set; }
        public int AccountId { get; set; }
    }
}
