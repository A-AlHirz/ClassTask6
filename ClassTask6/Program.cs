using System.Collections;
using System.Collections.Generic;

#region Create and Populate an ArrayList
ArrayList grocery = new ArrayList();
grocery.Add("apple");
grocery.Add("banana");
grocery.Add("cherry");
    
foreach (var element in grocery)
{
    Console.WriteLine(element);
}
#endregion

#region ArrayList Methods

grocery.Insert(2, "orange");

grocery.Remove("banana");

Console.WriteLine("-------------------");


foreach (var element in grocery)
{
    Console.WriteLine(element);
}

Console.WriteLine("-------------------");

Console.Write("Enter a fruit: ");
string fruit = Console.ReadLine();
if (grocery.Contains(fruit))
{
    Console.WriteLine("Yes, we have " + fruit);
}
else
{
    Console.WriteLine("No, we don't have " + fruit);
}

Console.WriteLine("-------------------");

Console.Write("Find fruit index(type fruit): ");
string fruit2 = Console.ReadLine();

Console.WriteLine("Index: "+ grocery.IndexOf(fruit2));

Console.WriteLine("Count number of elements: " + grocery.Count);
#endregion