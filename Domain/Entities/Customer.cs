using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Customer : EntityBase
    {
   
        [Required]
        public String CName { get; set; }
        [Required]
        public String CPhone { get; set; }

   
        public ICollection<Order> Orders { get; set; }


    }
}
