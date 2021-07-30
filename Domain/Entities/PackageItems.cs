using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PackageItems : EntityBase
    {

        [ForeignKey("Item")]
        public long ItemId { get; set; }
        [ForeignKey("Package")]
        public long PackageId { get; set; }
        public Item Item { get; set; }
        public Package Package { get; set; }

    }
}