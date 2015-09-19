<Query Kind="Expression">
  <Connection>
    <ID>400860ec-a335-4bec-864f-e5aa73ebd926</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

(from theBill in BillItems
where theBill.BillID == 104
select theBIll.SalePrice * theBill.Quantity).Sum()

(from customer in Bills
where customer.PaidStatus == true
select customer,BillItems.Sum)


//what is the average number of items per paid bill
//we need to get a list of numbers representing the items per bill
//we take an average of the list
(from customer in Bills
where customer.PaidStatus
select customer.BillItems.Count()).Average()