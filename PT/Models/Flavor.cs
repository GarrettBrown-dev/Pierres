using System.Collections.Generic;
using System.ComponentModel;

namespace PT.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.JoinEntries = new HashSet<TreatFlavor>();
        }
        public int FlavorId { get; set; }
        public string FlavorName { get; set; }
        public virtual ICollection<TreatFlavor> JoinEntries { get; set; }
    }
}