using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Purchase
    {
        public int PurchaseId {set; get;}
        public string Person { set; get; }
        public string Address { set; get; }
        public int BookId { set; get; }
        public DateTime Date { set; get; }
    }
}
