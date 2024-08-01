using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_ProjectFallout
{
    public abstract class InventoryItem
    {
        internal string? Name  { get; set; }
        internal double Weight { get; set; }
        public abstract void ParseCsv(string line);
    }
}
