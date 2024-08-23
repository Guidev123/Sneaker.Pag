using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker.Pag.Transactions
{
    public enum TransactionStatus
    {
        Authorized = 1,
        Paid = 2,
        Refused = 3,
        Chargedback = 4,
        Cancelled = 5
    }
}
