using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount)
        {

            
        }
        public override decimal CalculateTotal()
        {

            decimal total = base.CalculateTotal();
            return total * 0.90m;
        }
        
        
}

}

