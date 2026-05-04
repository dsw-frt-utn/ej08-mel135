using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiarValor = originalValue;
            copiarValor++;

          Product copiaValor = product;
            copiaValor.Description = "Modificado";

            return $"{originalValue}-{copiarValor}-{product.Description}";
          
        }
    }
}
