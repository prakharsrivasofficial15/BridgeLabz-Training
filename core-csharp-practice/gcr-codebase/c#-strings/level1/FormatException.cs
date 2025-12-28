using System;

class FormatException{
    static void Main(string[] args){
        ShowFormatException();
    }

    static void ShowFormatException(){
        try{
            string value = "ABC123";
            int number = int.Parse(value); // Invalid format
        }
        catch (FormatException ex){
            Console.WriteLine("FormatException caught: " + ex.Message);
        }
    }
}
