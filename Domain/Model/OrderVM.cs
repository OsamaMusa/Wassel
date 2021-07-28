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

        public DateTime? ODate { get; set; }

        public long CID { get; set; }


        public long LID { get; set; }
        public String Stutus { get; set; }


        public ICollection<PackageVM> Package { get; set; }



    }
}
