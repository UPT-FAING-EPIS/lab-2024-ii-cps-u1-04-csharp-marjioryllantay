namespace Bank.WebApi.Models
{
    public class BankAccount
    {
        public string CustomerName { get; private set; } // Cambiado a propiedad pública
        private double m_balance;

        // Constructor privado para uso interno
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            CustomerName = customerName; // Asegúrate de inicializarlo aquí
            m_balance = balance;
        }

        public double Balance => m_balance;

        public void Debit(double amount)
        {
            if (amount > m_balance)
                throw new ArgumentOutOfRangeException("amount");
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");
            m_balance += amount;
        }
    }
}
