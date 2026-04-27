using System; 

class Exception2{
	static void Main(string[] args){
		//method calling
		ShowStringIndexOutOfRange();
	}
	public static void ShowStringIndexOutOfRange(){
		try{
			string s = "Hello";
			Console.WriteLine(s[9]);
		}
		catch(IndexOutOfRangeException ex){
			Console.WriteLine("IndexOutOfRange Exception: " + ex.Message):
		}
	}
}