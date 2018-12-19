using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion
{
    class Rooms
    {
        private string title { get; set; }
        private string description { get; set; }
        private List<string> exists { get; set; }
        private List<Items> items {get; set;}

    // Private Methods
        private string GetItemList()
        { return " "; }

        private string GetExitList()
        { return " "; }

        private string GetCords()
        { return " "; }

    }
}
