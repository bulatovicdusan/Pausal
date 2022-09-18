using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("InvoiceItem")]
   public class InvoiceItem : Entity
    {
        public string? Name { get; set; }
        public string? UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Rebate { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
