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
    public class Order : EntityBase
    {
   
        [Required]
        public DateTime ODate { get; set; }
        
      
        [Required]
        public String Stutus { get; set; }
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }

        [ForeignKey("Location")]
        public long LocationId { get; set; }
        public Customer Customer { get; set; }
        public Location Location { get; set; }

        public ICollection<Package> Package { get; set; }


    }
}
