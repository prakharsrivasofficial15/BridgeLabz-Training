using System;

class Table{
    static void Main(string[] args){
        int[] num = new int[10];
        int a = 5;

        for (int i = 0; i < num.Length; i++){
            num[i] = i * a;
        }

        for (int i = 0; i < num.Length; i++){
            Console.WriteLine(a + " * " + i + " = " + num[i]);
        }
    }
}
