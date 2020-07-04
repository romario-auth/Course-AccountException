using AccountExeception.Entities.Exeception;

namespace AccountExeception.Entities
{
    class Account
    {
        public int Number {get; protected set;}
        public string Holder { get; set;}
        public double Balance {get; protected set;}
        public double WithdrawLimite{get; protected set;}

        public Account ()
        {

        }

        public Account(int number, string holder, double balance, double withdrawlimite)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimite = withdrawlimite;
        }

        public void Deposit(double amount)
        {
            Balance = amount;
        }

        public void Withdraw(double amount)
        {
            if ( WithdrawLimite <= amount )
            {
                throw new DomaninExeception("Widthdrawal Limite execeeded.");
            }
            if(Balance <= amount){
               throw new DomaninExeception("Not Balance.");
            }

            Balance -= amount;
        }
    }
}