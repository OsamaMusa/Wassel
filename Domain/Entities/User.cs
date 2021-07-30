using Domain.Entities.Base;
using Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : EntityBase
    {

        [Required]
        public  String userName { get; set; }
        [Required]
        public String password { get; set; }
        
        public int role { get; set; }

    }
}
