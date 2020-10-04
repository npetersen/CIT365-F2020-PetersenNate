using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Petersen
{
    class DeskQuote
    {
        public Desk desk { get; set; }
        public string customerFullName { get; set; }
        public int rushOrderDays { get; set; }
        public DateTime quoteDate = DateTime.Now;

    }
}
