using System;

class PrimeChecker{
    static bool IsPrime(int n){
        if(n <= 1){
			return false;
		}
        for(int i=2; i<=Math.Sqrt(n); i++){
            if (n % i == 0){
                return false;
			}
		}
        return true;
    }

    static void Main(){
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");
    }
}
