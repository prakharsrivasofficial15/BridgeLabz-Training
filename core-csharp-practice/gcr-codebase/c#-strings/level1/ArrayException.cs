using System;

class ArrayException{
    static void Main(string[] args){
        // Call the method
        ShowArrayIndexOutOfRange();
    }

    static void ShowArrayIndexOutOfRange(){
        try{
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // Invalid index
        }
        catch (IndexOutOfRangeException ex){
            Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
        }
    }
}
