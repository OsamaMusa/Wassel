using Domain.Entities;
using Domain.Entities.Base;
using Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
   
    public class OrderAddVM : ParentEntityVM
    {

        public DateTime? ODate { get; set; }


        public String Stutus { get; set; }
        public long CustomerId { get; set; }
        public long LocationId { get; set; }
        public List<PackageAddVM> Package { get; set; }



    }
}
