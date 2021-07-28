﻿using Domain.Entities.Base;
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
        public long CID { get; set; }

        public long OID { get; set; }

        public ICollection<PackageItemsVM>  PackageItems { get; set; }



    }
}
