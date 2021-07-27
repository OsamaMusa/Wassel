using Domain.Entities.Base;
using Domain.Model.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class LocationVM : ParentEntityVM
    {


        public String LName { get; set; }

    }
}
