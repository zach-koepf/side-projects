using System;
using System.Collections.Generic;
using System.Text;

namespace MortgageCalculator
{
    public class Mortgage
    {
        public double InterestRate { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal DownPayment { get; set; }
        public int MortgagePeriod { get; set; }
        public DateTime StartMonthYear { get; set; }
        public bool MinimumPaymentUsed { get; set; }

        public Mortgage (double interestRate, decimal purchasePrice, decimal downPayment, int mortgagePeriod, DateTime startMonthYear,bool minimumPaymentUsed)
        {
            InterestRate = interestRate;
            PurchasePrice = purchasePrice;
            DownPayment = downPayment;
            MortgagePeriod = mortgagePeriod;
            StartMonthYear = startMonthYear;
            MinimumPaymentUsed = minimumPaymentUsed;
        }
    }
}
