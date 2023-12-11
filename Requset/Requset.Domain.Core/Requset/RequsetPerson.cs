using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requset.Domain.Core.Requset
{
    public class RequsetPerson:BaseEntity
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string Datetime { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string RequsetType { get; set; }
        public string Details { get; set; }
    }
}
