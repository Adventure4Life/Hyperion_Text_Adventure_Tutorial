using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion
{
    static class Player
    {
        private static int posX { get; set; }
        private static int posY { get; set; }

        private static List<Items> inventoryItems { get; set; }
        private static int moves { get; set; } = 0;
        private static int weightCapacity { get; set; } = 6;

        #region Setters & Getters (properties)
        public static int InventoryWeight
        {
            get
            {
                //TODO: Finish Inventory weight calculation
                return 0;
            }
        }


        #endregion Setters & Getters (properties)
    }
}
