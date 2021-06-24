using System;
using System.Collections.Generic;
using System.Text;

namespace Unit17
{
    public class Calculator
    {
        
        // Метод для расчета процентной ставки
        public void CalculateInterest( ICalculateInterest calculateInterest, Account account)
        {
            calculateInterest.Execute(account);
        }
    }
}
