using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor X, Flavor Y)
        {
            return string.Compare(X.Name, Y.Name);
        }

    }
}
