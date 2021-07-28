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
        
        [ForeignKey("Customer")]
        public long CID { get; set; }
        
        [ForeignKey("Location")]
        public long LID { get; set; }
        [Required]
        public String Stutus { get; set; }
        public Customer Customer { get; set; }
        public Location Location { get; set; }

        public ICollection<Package> Package { get; set; }


    }
}
