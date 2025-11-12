using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSaveFileEditor.Models
{
    public class ItemFlagEntry
    {
        public int Hash { get; set; }

        // To clarify this, identified is actually 0. Seems like this represents
        // "can be identified" rather than "is this identified." It's the reverse
        // of what I initially thought was logical; 1 = true = identified, but
        // that's not the case.
        public bool IdentifiedBit { get; set; }
    }
}
