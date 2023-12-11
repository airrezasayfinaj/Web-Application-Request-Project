using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Request.MVC.Model.RequsetPerson
{
    public class AddNewRequsetPersonViewModel
    {
        [StringLength(10,MinimumLength =2)]
        public string Name { get; set; }
        [StringLength(10, MinimumLength = 2)]
        public string Family { get; set; }
        [StringLength(10, MinimumLength = 2)]
        public string Datetime { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string City { get; set; }
        public string RequsetType { get; set; }
        public string Details { get; set; }
    }
}
