namespace Dsw2026Ej8
{
    public class Sale
    {
        private decimal _amount;

        public Sale(decimal amount)
        {
            _amount = amount;
        }
        public virtual decimal CalculateTotal()
        {
            return _amount;
        }

      
    }
}