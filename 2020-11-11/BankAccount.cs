using System;
using System.Collections.Generic;

namespace anotherclass
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        // 添加包含可选 minimumBalance 参数的构造函数,设置最小余额属性。
        private readonly decimal minimumBalance;//minimumBalance 字段被标记为 readonly，之后不能更改值
        
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }//: this() 表达式调用另一个构造函数

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            this.minimumBalance = minimumBalance;
            if (initialBalance > 0)//保留存款必须为正的规则，同时允许信用帐户以 0 余额开户。
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        // 重构MakeWithdrawal
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {//当帐户透支时，该重写将返回费用交易。 如果取款未超出限额，则该方法将返回 null 交易。 这表明不收取任何费用
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            var overdraftTransaction = CheckWithdrawalLimit(Balance - amount < minimumBalance);//规定最小余额的只读字段
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
            if (overdraftTransaction != null)
                allTransactions.Add(overdraftTransaction);
        }

        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)//用protected方法，只能从派生类中调用它。? 批注指示该方法可能返回 null
        {
            if (isOverdrawn)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else
            {
                return default;
            }
        }

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
        public virtual void PerformMonthEndTransactions() { }//用virtual 方法，任何派生类都可以选择重新实现
    }
}
