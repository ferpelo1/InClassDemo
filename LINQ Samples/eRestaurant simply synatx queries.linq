<Query Kind="Statements">
  <Connection>
    <ID>400860ec-a335-4bec-864f-e5aa73ebd926</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//simpliest form of dumoing an entity
Waiters

//simple query syntax
from person in Waiters
select person

//simple method syntax
Waiters.Select(person => person)

//inside our project we will be writing C# statement
var results = from person in Waiters
				select person;
//to display the contents of a variable in LinqPad
//use the .Dump method
results.Dump();

//implemented inside a VS project's class library MLL method
//[DataObjectMethod(DataObjectMethodTYpe.Select,false)]
//public List<Waiters> SomeMethodName ()
//{
	//you will need to connect to your DAL object
	//this will be done using a new xxxxx() constructor
	//assume your connection variable is called context variable
	
	//do your query
	//var results = from person in contextvariable.Waiters
				//select person;
	//return your results
	//return results.ToList();
//}