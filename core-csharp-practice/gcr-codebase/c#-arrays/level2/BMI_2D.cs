using System;

class BMI_2D{
        static void Main(String[] args){
            
            int n = int.Parse(Console.ReadLine());

            double[,] inputArr = new double[n, 3];
            string[] status = new string[n];

            for (int i = 0; i < n; i++){
                inputArr[i, 0] = Convert.ToDouble(Console.ReadLine()); // weight in kg
                inputArr[i, 1] = Convert.ToDouble(Console.ReadLine()); // height in cm

                // convert height from cm to meters
                double heightInMeters = inputArr[i, 1] / 100;

                // calculating BMI and storing in 2D array
                inputArr[i, 2] = inputArr[i, 0] / (heightInMeters * heightInMeters);

                if (inputArr[i, 2] <= 18.4)
                    status[i] = "Underweight";
                else if (inputArr[i, 2] <= 24.9)
                    status[i] = "Normal";
                else if (inputArr[i, 2] <= 39.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obese";
            }

            for (int i = 0; i < n; i++){
                Console.WriteLine("Weight: " + inputArr[i, 0] +" kg, Height: " + inputArr[i, 1] +" cm, BMI: " + inputArr[i, 2] +", Status: " + status[i]);
            }
        }
    }