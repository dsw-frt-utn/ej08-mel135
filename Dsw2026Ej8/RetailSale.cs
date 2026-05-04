using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {


        public RetailSale(decimal amount) : base(amount)
        {
        }

         public override decimal CalculateTotal()
     {
            return base.CalculateTotal();
     }
           
    
    }
}
