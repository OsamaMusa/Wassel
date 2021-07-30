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
    public class Package : EntityBase
    {



        [ForeignKey("Car")]
        public long CarId { get; set; }
        [ForeignKey("Order")]
        public long OrderId { get; set; }
        public Car Car { get; set; }
        public Order Order { get; set; }
        public ICollection<PackageItems> PackageItems { get; set; }

    }
}
