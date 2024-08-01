using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_AccesMods
{
    public class Human
    {
        public int Public { get; set; }
        private int Private { get; set; }
        protected int Protected { get; set; }
        internal int Internal { get; set; }
        protected internal int ProtectedInternal { get; set; }
        private protected int PrivateProtected { get; set; }

        public Human()
        {
            Public = 1;
            Private = 2;
            Protected = 3;
            Internal = 4;
            ProtectedInternal = 5;
            PrivateProtected = 6;
        }
    }
}
