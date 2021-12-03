using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class AllergenComparer : IComparer<Flavor>
    {
        public int Compare(Flavor X, Flavor Y)
        {
            return X.Allergens.Count > Y.Allergens.Count ? 1 : -1;

        }
    }
}
