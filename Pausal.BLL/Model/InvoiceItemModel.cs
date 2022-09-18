using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class InvoiceItemModel : EntityModel
    {
        public string? Name { get; set; }
        public string? UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Rebate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
