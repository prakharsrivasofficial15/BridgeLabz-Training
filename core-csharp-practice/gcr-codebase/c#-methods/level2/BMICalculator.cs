using System;

class BMICalculator{
    static void Main(string[] args){
        int members = 10;
        double[,] personData = new double[members, 3];

        //user input
        for (int i = 0; i < members; i++){

            Console.Write("Weight(kg): ");
            personData[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Height(cm): ");
            personData[i, 1] = double.Parse(Console.ReadLine());
        }

        //calculate BMI 
        CalculateBMI(personData);

        //get BMI status
        string[] status = GetBMIStatus(personData);

        for (int i = 0; i < members; i++){
            Console.WriteLine("Weight (kg): " + personData[i, 0]);
            Console.WriteLine("Height (cm): " + personData[i, 1]);
            Console.WriteLine("BMI: " + personData[i, 2]);
            Console.WriteLine("Status: " + status[i]);
        }
    }

    //method to calculate BMI
    public static void CalculateBMI(double[,] data){
        for (int i = 0; i < data.GetLength(0); i++){
			//height in meters
            double heightMeters = data[i, 1] / 100; 
            data[i, 2] = data[i, 0] / (heightMeters * heightMeters);
        }
    }

    //method to determine status
    public static string[] GetBMIStatus(double[,] data){
        int size = data.GetLength(0);
        string[] status = new string[size];

        for (int i = 0; i < size; i++){
            double bmi = data[i, 2];

            if(bmi <= 18.4){
                status[i] = "Underweight";
			}
            else if(bmi <= 24.9){
                status[i] = "Normal";
			}
            else if(bmi <= 39.9){
                status[i] = "Overweight";
			}
            else{
                status[i] = "Obese";
			}
        }

        return status;
    }
}
