using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.OOP
{
    public class NewBankAccount
    {
        public class InterestEarningAccount : BankAccount
        {
            public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
            {
            }
            public override void PerformanceMonthEndTransaction()
            {
                if (Balance > 500m)
                {
                    decimal interest = Balance * 0.5m;
                    MakeDeposit(interest, DateTime.Now, "apply mpnthly interest");
                }
            }
        }

        public class LineOfCreditAccount : BankAccount
        {
            public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
            {
            }
            public override void PerformanceMonthEndTransaction()
            {

                if (Balance < 0)
                {
                    //Negate the balance to get a positive interest change
                    decimal interest = -Balance * 0.7m;
                    MakeWithdrawal(interest, DateTime.Now, "Change monthly interest");
                }
            }

            protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) => isOverdrawn
                ? new Transaction(-20, DateTime.Now, "Apply overdraft fee") : default;
        }

        public class GiftCardAccount : BankAccount
        {
            private readonly decimal _monthlyDeposit = 0m;
            public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
                => _monthlyDeposit = monthlyDeposit;

            public override void PerformanceMonthEndTransaction()
            {
                if (_monthlyDeposit != 0)
                {
                    MakeDeposit(_monthlyDeposit, DateTime.Now, "Add Monthly Deposit");
                }
            }
        }

        public NewBankAccount(string name, decimal initialBalance)
        {

        }
       
        

        



    }
}
