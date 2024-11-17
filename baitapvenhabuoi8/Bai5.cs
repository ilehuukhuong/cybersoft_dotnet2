using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitapvenhabuoi8
{
    public class Bai5
    {
        public static int BestDay(List<int> prices)
        {
            var bestDays = new List<(int BuyDay, int SellDay)>();
            int maxProfit = 0;
            for (int buyDay = 0; buyDay < prices.Count; buyDay++)
            {
                for (int sellDay = buyDay + 1; sellDay < prices.Count; sellDay++)
                {
                    int profit = prices[sellDay] - prices[buyDay];
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                        bestDays.Clear();
                        bestDays.Add((buyDay, sellDay));
                    }
                    else if (profit == maxProfit)
                    {
                        bestDays.Add((buyDay, sellDay));
                    }
                }
            }
            return maxProfit;
        }
    }
}