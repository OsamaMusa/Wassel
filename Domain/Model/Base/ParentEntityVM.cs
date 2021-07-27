using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Base
{
    public class ParentEntityVM
    {
        [Required]
        public long ID { get; set; }
    }
}
