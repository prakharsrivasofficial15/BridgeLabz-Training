using System;

class Zara{
    static void Main(string[] args){
        int employees = 10;

        //Generate old salary and years of service
        double[,] employeeData = GenerateEmployeeData(employees);

        //calculate bonus and new salary
        double[,] updatedData = CalculateBonusAndNewSalary(employeeData);

        //display summary and totals
        DisplaySummary(employeeData, updatedData);
    }

    //Method to determine salary and years of service
    public static double[,] GenerateEmployeeData(int size){
        double[,] data = new double[size, 2];
        Random random = new Random();

        for(int i = 0; i < size; i++){
            data[i, 0] = random.Next(10000, 100000); // 5-digit salary
            data[i, 1] = random.Next(1, 11);         
        }

        return data;
    }

    //method to calculate bonus and new salary
    public static double[,] CalculateBonusAndNewSalary(double[,] employeeData){
        int size = employeeData.GetLength(0);
        double[,] result = new double[size, 2];

        for(int i = 0; i < size; i++){
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];
            double bonusRate;

            if(years > 5){
                bonusRate = 0.05; // 5%
			}
            else{
                bonusRate = 0.02; // 2%
			}

            double bonus = salary * bonusRate;
            double newSalary = salary + bonus;

            result[i, 0] = bonus;
            result[i, 1] = newSalary;
        }

        return result;
    }

    //Method to calculate totals and display results
    public static void DisplaySummary(double[,] oldData, double[,] newData){
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for(int i = 0; i < oldData.GetLength(0); i++){
            double oldSalary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus = newData[i, 0];
            double newSalary = newData[i, 1];

            totalOldSalary += oldSalary;
            totalBonus += bonus;
            totalNewSalary += newSalary;

            Console.WriteLine((i + 1) + "\t" + oldSalary + "\t\t" + years + "\t" + bonus + "\t\t" + newSalary);
        }

        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus Paid: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}
