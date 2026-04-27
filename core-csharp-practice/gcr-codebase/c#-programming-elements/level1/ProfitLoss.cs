using System;

class ProfitLoss{
	static void Main(String[] args){
		int costPrice = 129;
		int sellPrice = 191;
		
		int profit = sellPrice - costPrice;
		int profitPercentage = profit/costPrice * 100;
		
		Console.WriteLine("The Profit is INR: "+ profit);
		Console.WriteLine("The Profit Percenatge is: " + profitPercentage);
	}
}