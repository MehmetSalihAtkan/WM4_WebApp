using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.Models.Payment
{
    public class InstallmentPriceModel
    {
        public string Price { get; set; }
        public string TotalPrice { get; set; }
        public string InstallmentNumber { get; set; }
    }
}
