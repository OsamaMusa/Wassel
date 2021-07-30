﻿using Domain.Entities.Base;
using Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class UserVM : ParentEntityVM
    {

        public String userName { get; set; }
        public String password { get; set; }

    }
}
