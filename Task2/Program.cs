// See https://aka.ms/new-console-template for more information
using Task2;

Customer c = new Customer() { Id = 1, Address = "Dhaka", Name = "Shobuj" };
Customer c1 = new Customer() { Id = 2, Address = "Dhaka", Name = "Rhobuj" };
Purchase purchase = new Purchase() { Amount=300.0, CustomerId=1, PurchasedOn= new System.DateTime(2011, 6, 9) };
Purchase purchase1 = new Purchase() {Amount=20.0,CustomerId=2,PurchasedOn= new System.DateTime(2011, 6, 9) };
List<Customer> customers = new List<Customer>();
customers.Add(c);
customers.Add(c1);
List<Purchase> purchases = new List<Purchase>();
purchases.Add(purchase);
purchases.Add(purchase1);
DataOperation operation = new DataOperation();
var list = operation.MergeData(customers, purchases);
foreach (var item in list)
{
    Console.WriteLine(item.cutomerName);
    Console.WriteLine(item.purchaseAmount);
    Console.WriteLine(item.purchaseDate);
}
