using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car : EntityBase
    {

        [Required]
        public String CName { get; set; }
        [Required]
        public decimal CSize { get; set; }

        public ICollection<Package> Packages { get; set; }

    }
}
