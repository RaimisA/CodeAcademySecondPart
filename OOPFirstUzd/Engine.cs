using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirstUzd
{
    internal class Engine
    {
        public bool IsOn { get; private set; }

        public void Start()
        {
            IsOn = true;
        }

        public void Stop()
        {
            IsOn = false;
        }
    }
}
