using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Invoice")]
   public class Invoice : Entity
   {
      public string? InvoiceNumber { get; set; }
      public DateTime Date { get; set; }
      public Payment? Payment { get; set; }
      public Client? Client { get; set; }
      public Entrepreneur? Entrepreneur { get; set; }
      public Activity? Activity { get; set; }
      public List<InvoiceItem>? InvoiceItems { get; set; }
   }
}
