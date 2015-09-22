<Query Kind="Program" />

void Main()
{
	//simple concatenation C# Expressions
	//"hello world"
	//5+7
	
	//simple C# statements
	//string name = "Francis";
	//string message = "hello " + name;
	//message.Dump();
	
	//simple C# program
	//subroutine
	SayHello("Francis");
}

// Define other methods and classes here
public void SayHello(string name)
{
	string message = "hello " + name;
	message.Dump();
}