using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostMachine
{
    class VkCommunity
    {
        // commit
        private static List<VkCommunity> Communities = new List<VkCommunity>();
        private static Int32 CurrentAvailableID = 0;

        public string Link { get; private set; }
        public Int32 Id { get; private set; }

        public VkCommunity(string link)
        {
            this.Link = link;
            this.Id = CurrentAvailableID++;
        }
    }
}
