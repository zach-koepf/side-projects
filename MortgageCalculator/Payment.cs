using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class Payment
    {
        int PaymentNumber { get; set; }
        DateTime MonthYear { get; set; }
        decimal InterestPayment { get; set; }
        decimal PrinciplePayment { get; set; }

        decimal TotalMonthlyPayment
        {
            get
            {
                return InterestPayment + PrinciplePayment;
            }
        }
    }
}
