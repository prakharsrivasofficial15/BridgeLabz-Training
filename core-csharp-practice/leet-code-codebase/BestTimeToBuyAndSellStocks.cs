public class Solution{
    public int MaxProfit(int[] prices){
        if (prices == null || prices.Length < 2){
            return 0;
        }

        int min = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices){
            if (price < min){
                min = price;
            }

            int profit = price - min;

            if (profit > maxProfit){
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}
