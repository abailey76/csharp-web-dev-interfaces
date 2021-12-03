using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone X, Cone Y)
        {
            return (X.Cost < Y.Cost) ? -1 : 1;
        }
    }
}
