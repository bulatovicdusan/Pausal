using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class ActivityModel : EntityModel
    {
        public int Code { get; set; }
        public string? Name { get; set; }
    }
}
