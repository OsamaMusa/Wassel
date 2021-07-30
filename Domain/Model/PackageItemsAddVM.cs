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
    public class PackageItemsAddVM :ParentEntityVM
    {


        public long ItemId { get; set; }


        public long PackageId { get; set; }



    }
}
