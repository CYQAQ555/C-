using System;

namespace anotherclass
{
    class LineOfCreditAccount : BankAccount
    {
        
        public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit) : base(name, initialBalance, -creditLimit)
        {//调用基构造函数，声明信用额度
        }
        

        public override void PerformMonthEndTransactions()//取余额的相反数，计算从该帐户提取的正利息
        {
            if (Balance < 0)
            {
                // Negate the balance to get a positive interest charge:
                var interest = -Balance * 0.07m;
                MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
            }
        }

        // 对超过限额的取款进行收费。
        protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>
            isOverdrawn
            ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
            : default;
    }
}
