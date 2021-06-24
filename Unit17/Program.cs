using System;

namespace Unit17
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            var CalculateBase = new Calculator();

            account.Type = "Обычный";
            account.Balance = 150;


            if (account.Type == "Зарплатный") 
                {
                CalculateBase.CalculateInterest(new CalculateZarplata(), account);
                }
            if (account.Type == "Обычный")
            {
                CalculateBase.CalculateInterest(new CalculateNormal(), account);
            }

        }

        
    }
}
