using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    class DeskQuote
    {
        Desk desk { get; set; }
        string customerFullName { get; set; }
        int rushOrderDays { get; set; }
        DateTime quoteDate = DateTime.Now;


    }
}
