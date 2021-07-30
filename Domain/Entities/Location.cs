using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Location : EntityBase
    {
        

        [Required]
        public String LName { get; set; }
      

        public ICollection<Order> Orders { get; set; }

    }
}
