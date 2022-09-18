using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class ClientModel : EntityModel
    {
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? Postcode { get; set; }
        public string? Address { get; set; }
        public int PIB { get; set; }
        public int IdentificationNumber { get; set; }
        public AccountModel? Account { get; set; }
    }
}
