using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class ParentEntity
    {
        [Key]
        [Required]
        public long ID { get; set; }

    }
}
