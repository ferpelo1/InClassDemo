<Query Kind="Expression">
  <Connection>
    <ID>400860ec-a335-4bec-864f-e5aa73ebd926</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

//orderby

//default is ascending
from food in Items
orderby food.Description
select food

//also by descending
from food in Items
orderby food.CurrentPrice descending
select food

//can use both ascending and descending
from food in Items
orderby food.CurrentPrice descending, food.Calories ascending
select food

//you can use where and orderby together
from food in Items
where food.MenuCategory.Description.Equals("Entree")
orderby food.CurrentPrice descending, food.Calories ascending
select food
