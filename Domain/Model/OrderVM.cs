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
    public class OrderVM : ParentEntityVM
    {

        public DateTime? OrderDate { get; set; }

        public long CustomerID { get; set; }

        public long LocationID { get; set; }
        public PackageVM PackageVM { get; set; }



    }
}
