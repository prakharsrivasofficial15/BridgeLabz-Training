using System;

class Exception{
	static void Main(string[] args){
		//method calling
		ShowStringIndexOutOfRange();
	}
	static void ShowStringIndexOutOfRange(){
		try{
			string s = "Hello";
			Console.WriteLine(text[10]);
		}
		catch(IndexOutOfRangeException ex){
			Console.WriteLine("IndexOutOfRangeException caught: "+ ex.Message);
		}
	}
}