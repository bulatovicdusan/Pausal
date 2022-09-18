using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class EntrepreneurModel : EntityModel
    {
        public string? Name { get; set; }
        public int PIB { get; set; }
        public int IdentificationNumber { get; set; }
        public string? City { get; set; }
        public string? Postcode { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public ActivityModel? PrimaryActivity { get; set; }
        public ActivityModel? SecondaryActivity { get; set; }
        public List<ClientModel>? Clievnts { get; set; }
        public List<AccountModel>? Accounts { get; set; }
    }
}