using System;

class Pens{
	static void Main(string[] args){
		int totalPens = 14;
		int totalStudents = 3;
		
		int penPerStudent = (totalPens / totalStudents);
		int pensRemaining = (totalPens % totalStudents);
		
		Console.WriteLine("The pen per Student: " + penPerStudent);
		Console.WriteLine("The remaining pen not distributed: " + pensRemaining);
	}
	
}