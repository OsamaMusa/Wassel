using Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class PackageItems : EntityBase
    {
        [ForeignKey("Item")]
        public long IID { get; set; }

        [ForeignKey("Package")]
        public long PID { get; set; }
        public Item Item { get; set; }
        public Package Package { get; set; }

    }
}