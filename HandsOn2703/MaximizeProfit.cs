using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn2703
{
    internal class MaximizeProfit
    {

        public static int FindMaxProfitEfficient(int days, List<int> stockPrices)
        {
            //O(days)
            int maxProit = 0, smallestBuySoFar = stockPrices[0];

            for(int i = 0; i < days; i++)
            {
            
                maxProit = (stockPrices[i] - smallestBuySoFar > maxProit)? stockPrices[i]-smallestBuySoFar:maxProit;
                

                smallestBuySoFar = (stockPrices[i] < smallestBuySoFar)? stockPrices[i]:smallestBuySoFar;
            }

            return maxProit;
        }
     
    public static int FindMaxProfit(int days, List<int> stockPrices)
        {
            //O(days^2)
            int maxProfit = 0;


            for(int buyDayIter= 0; buyDayIter < days;buyDayIter++)
            {
                int buyDayPrice = stockPrices[buyDayIter];

                for(int sellDayIter=buyDayIter+1;sellDayIter < days; sellDayIter++)
                {
                    int profitPossible = stockPrices[sellDayIter]-buyDayPrice;
                    maxProfit=(profitPossible>maxProfit)?profitPossible:maxProfit;
                }
            }


            return maxProfit;

        }
    //public static void Main(string[] args)
    //{

    //        int days = Convert.ToInt32(Console.ReadLine());
    //        List<int>stockPrices= new List<int>();

    //        for(int i = 0; i < days; i++)
    //        {
    //            stockPrices.Add(Convert.ToInt32(Console.ReadLine()));   
    //        }

    //        Console.WriteLine("maximum profit you can achieve is "+FindMaxProfitEfficient(days, stockPrices));
    //}


    }

}
