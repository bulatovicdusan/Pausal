using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class InvoiceModel : EntityModel
    {
        public string? InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string? PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public ClientModel? Client { get; set; }
        public EntrepreneurModel? Entrepreneur { get; set; }
        public decimal AdvancePayment { get; set; }
        public decimal TotalPayment { get; set; }
        public List<InvoiceItemModel>? InvoiceItems { get; set; }
    }
}
