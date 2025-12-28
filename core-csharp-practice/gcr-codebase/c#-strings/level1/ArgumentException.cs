using System; 

class ArgumentException{
	static void Main(string[] args){
		//method calling
		ArgumentOutOfRangeException();
	}
	public static void ArgumentOutOfRangeException();{
		try{
			string s = "Hello";
			string res = s.Substring(5, 11);
		}
		catch(ArgumentOutOfRangeException ex){
			Console.WriteLine("ArgumentOutOfRangeException caught: " + ex.Message):
		}
	}
}