using System;

class OTPGenerator{
    static void Main(string[] args){
        int[] otps = new int[10];

        // Generate 10 OTPs
        for(int i = 0; i < otps.Length; i++){
            otps[i] = GenerateOTP();
        }

        Console.WriteLine("Generated OTPs:");
        for(int i = 0; i < otps.Length; i++){
            Console.WriteLine(otps[i]);
        }

        //validate unique
        bool isUnique = AreOTPsUnique(otps);
        if (isUnique)
            Console.WriteLine("All OTPs are unique.");
        else
            Console.WriteLine("Duplicate OTPs found.");
    }

    //method to generate a 6-digit OTP
    public static int GenerateOTP(){
        Random random = new Random();
        return random.Next(100000, 1000000); 
    }

    //method to check if all OTPs are unique
    public static bool AreOTPsUnique(int[] otps){
        for(int i = 0; i < otps.Length; i++){
            for (int j = i + 1; j < otps.Length; j++){
                if(otps[i] == otps[j]){
                    return false;
                }
            }
        }
        return true;
    }
}
