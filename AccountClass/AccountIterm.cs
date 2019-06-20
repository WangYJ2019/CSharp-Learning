using System;

namespace AccountsClass
{
    public class AccountItem
    {
        private string name;
        public Category myCategory;
        private Money amount;
        private DateTime occurTime;

        public Money Amount
        {
            get => amount;
            set => amount = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public DateTime OccurTime
        {
            get => occurTime;
            set => occurTime = value;
        }

        //===== constructor =====
        //public AccountItem(string name, Category myCategory, Money amount)
        //{
        //    this.name = name;
        //    this.amount = amount;
        //    this.myCategory = myCategory;
        //}
        public AccountItem():this("AccoutItem-1", Category.Income, new Money(0), "This is content...","This is note...", DateTime.Now)
        {
        }
        public AccountItem(string name, Category myCategory, Money amount) : this(name, myCategory, amount, "This is content...", "This is note...", DateTime.Now)
        {
        }
        public AccountItem(string name, Category myCategory, Money amount, string content, string note, DateTime occurTime)
        {
            this.name = name;
            this.amount = amount;
            this.myCategory = myCategory;
            this.Content = content;
            this.Note = note;
            this.occurTime = occurTime;
        }
        //=====Content and Note=====
        public string Content
        {
            get; set;
        }
        public string Note
        {
            get; set;
        }
        //---override method ToString()---
        public override string ToString()
        {
            return $"{name} || {myCategory} - {amount.ToString()} || {Content} | {Note} || {OccurTime.ToShortDateString()}";
        }
    }
}
