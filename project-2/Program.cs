
Console.WriteLine("Project 2");
List<Item> items = new List<Item>();
Console.WriteLine("Press q to show list");

while (true)
{

while (true)
{
Console.Write("Input Category: ");
string categoryInput = Console.ReadLine();
if (categoryInput.ToLower().Trim() == "q")
{
break;
}

Console.Write("Input Product: ");
string productInput = Console.ReadLine();
if (productInput.ToLower().Trim() == "q")
{
break;
}

string priceInput;
int value = 0;
while (true)
{
Console.Write("Input Price: ");
priceInput = Console.ReadLine();

if (priceInput.ToLower().Trim() == "q")
{
break;
}

bool isValue = int.TryParse(priceInput, out value);
if (!isValue)
{
Console.WriteLine("Incorrect price!");
}
else
{
break;
}
}

if (priceInput.ToLower().Trim() == "q")
{
break;
}

Item item = new Item(categoryInput, productInput, value);
items.Add(item);
}

List<Item> sortedItems = items.OrderBy(item => item.Price).ToList();

Console.WriteLine("Category".PadRight(20) + "Product".PadRight(20) + "Price");
foreach (Item item in sortedItems)
{
Console.WriteLine(item.Category.CategoryName.PadRight(20) + item.Product.PadRight(20) + item.Price);
}

int sum = items.Sum(item => item.Price);
Console.WriteLine("Sum: ".PadRight(40) + sum);

Console.WriteLine("");
Console.WriteLine("Press q + Enter to exit or  press Enter to add more items");
string decision = Console.ReadLine();
if (decision.ToLower().Trim() == "q")
{
break;
}

}
Console.ReadLine();
    class Item
{
    public Item(string category, string product, int price)
    {
        
        Category = new Category(category);
        Product = product;
        Price = price;
    }
    public Category Category { get; set; }
    public string Product { get; set; }
    public int Price { get; set; }
}
class Category
{
    public Category(string categoryName)
    {
        CategoryName = categoryName;
    }
    public string CategoryName { get; set; }
}


