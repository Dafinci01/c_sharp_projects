/*
Project 2

A small e-commerce client needs a basic product catalog. 
The system should store 5 products (using a Product struct),
 let the user search for a product by name, display matching product details, and show the total inventory value across all products.

Requirements — must use:

An enum Category with at least 4 types
A struct Product with name, category, price, stock quantity, and a method GetValue() returning price * stock
Product[] array of 5 products
Console.ReadLine() for search input
for loop for searching
if/else for found/not found
Running total calculated with a loop


*/


using Internal;

enum Category { Shoes, GadgetsandTech, HouseHold, Fashion}
struct Product {
	public string Name;
	public string ProductCategory;
	public double Price;
	public double StockQuantity;
	
	
	public Product(string name ,string productcategory,  double price ,  double stock)
	{
		Name = name;
		ProductCategory = productcategory;
		Price = price;
		StockQuantity = stock;
		
	}
	public void GetValue()
	{
		return Price * StockQuantity;
	}
	public void PrintProduct()
	{
		Console.WriteLine();
	}
	
}
//fil the array 
inventory[0]  = new Product{"AirForce 1", Category.Shoes, 4500, 10};
//then search 
Console.WriteLine("input Product to search : ");
string searchTerm = Console.ReadLine();

bool found = false;
for(int i = 0; i < invntory.Length; i++)
{
	if(inventory[i].Name == searchTerm)
    {
        inventory[i].PrintProduct();
        found =true;
    }
}
if(!found)
{
    Console.WriteLine("Product not found");
}
	