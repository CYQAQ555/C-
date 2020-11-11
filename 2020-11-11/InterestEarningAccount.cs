using System;

namespace anotherclass
{
    public class InterestEarningAccount : BankAccount//从BankAccount 类继承方法和数据
    {
        // 派生类构造函数
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()//派生类使用override关键字定义新的实现
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;//每月的利息计算
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}
