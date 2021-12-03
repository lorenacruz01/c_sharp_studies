namespace InterfaceApp1.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount) // tem que implementar o método Tax
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
