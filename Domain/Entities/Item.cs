using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Item : EntityBase
    {
      
        [Required]
        public String IName { get; set; }
        [Required]
        public int ISize { get; set; }

    }
}
