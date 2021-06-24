using System;
using System.Collections.Generic;
using System.Text;


namespace Unit17
{
    public class CalculateZarplata : ICalculateInterest 
    {
        public void Execute(Account account)
        {
            account.Interest = account.Balance * 0.5;
        }
    }
    
}
