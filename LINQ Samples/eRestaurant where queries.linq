<Query Kind="Expression">
  <Connection>
    <ID>400860ec-a335-4bec-864f-e5aa73ebd926</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//where clause

//list all tables that hold more that 3 people

//query syntax
from row in Tables
where row.Capacity > 3
select row

//method syntax
Tables.Where(row => row.Capacity > 3)


//list all items with more than 500 calories
//query syntax
from food in Items
where food.Calories > 500
select food

//method syntax
Items.Where(food => food.Calories > 500)


//list all items with more than 500 calories and selling for
//more than $10.00
//query syntax
from food in Items
where food.Calories > 500 &&
	  food.CurrentPrice > 10m
select food

//method syntax
Items.Where(food => food.Calories > 500) &&
			(food => CurrentPrice > 10m)
			

//list all items with more than 500 calories and are Entrees on the menu
//HINT: navigational properties of the database are known by LinqPad.
//query syntax
from food in Items
where food.Calories > 500 &&
	  food.MenuCategory.Description.Equals("Entree")
select food