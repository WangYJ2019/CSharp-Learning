using System;
using System.Collections.Generic;
using System.Text;

namespace AccountsClass
{
    public class Account
    {
        private List<AccountItem> accountItemList = new List<AccountItem>();
        
        public void AddAccountItem(AccountItem accountItem)
        {
            accountItemList.Add(accountItem);
        }

        public Money TotalExpenditure(DateTime time)
        {
            double faceValue = 0;
            foreach (var accountItem in accountItemList)
            {
                if (accountItem.myCategory == Category.Spending && accountItem.OccurTime.ToString("y")==time.ToString("y"))
                {
                    faceValue += accountItem.Amount.FaceValue;
                }
            }
            return new Money(faceValue);
        }

        public Money TotalIncome(DateTime time)
        {
            double faceValue = 0;
            foreach (var accountItem in accountItemList)
            {
                if (accountItem.myCategory == Category.Income && accountItem.OccurTime.ToString("y") == time.ToString("y"))
                {
                    faceValue += accountItem.Amount.FaceValue;
                }
            }
            return new Money(faceValue);
        }

        public Money TotalRevenue(DateTime time)
        {
            return TotalIncome(time)-TotalExpenditure(time);
        }

        public IEnumerable<AccountItem> Display(DateTime time)
        {
            foreach (var accountItem in accountItemList)
            {
                if (accountItem.OccurTime.ToString("y") == time.ToString("y"))
                {
                    yield return accountItem;
                }
            }
        }
    }
}
