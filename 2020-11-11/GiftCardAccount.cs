using System;

namespace anotherclass
{
    public class GiftCardAccount : BankAccount//从BankAccount 类继承方法和数据
    {
        private decimal _monthlyDeposit = 0m;//声明每月存款，为monthlyDeposit值提供默认值

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;//每个月要充值的可选金额

        public override void PerformMonthEndTransactions()//添加每月存款
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
