using System;

class Zara{
	static void Main(String[] args){
	
        //input the salary and experience
        double[] yearOfServices = new double[10];
        double[] salary = new double[10];
        double[] bonusAmount = new double[10];
		
        for(int i = 0; i < 10; i++){
            yearOfServices[i] = Convert.ToDouble(Console.ReadLine());
        }
		
        for (int i = 0; i < 10; i++){
			salary[i] = Convert.ToDouble(Console.ReadLine());
        }
		
        //if thay have worked more then 5 year then they will get 5% bonus or 2% if less than 5 years
        for(int i = 0; i < 10; i++){
            if (yearOfServices[i] > 5){
                bonusAmount[i] = salary[i] + (salary[i] * 0.05);
            }else{
				bonusAmount[i] = salary[i] + (salary[i] * 0.03);
			}
		}

        // add the bonus to the current salary and print the new salary
        for(int i = 0; i < 10; i++){
            Console.WriteLine("New Salary with Bonus: " + bonusAmount[i]);
        }
    }
}