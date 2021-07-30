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
    public class PackageVM : ParentEntityVM
    {

        public CarVM Car { get; set; }
        public long CarId { get; set; }

        public long OrderId { get; set; }
   
        public ICollection<PackageItemsVM>  PackageItems { get; set; }



    }
}
