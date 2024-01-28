
var customers = GetCustomers();
var count = customers.Count();
Console.WriteLine($"There are {count} customers");

foreach(var customer in customers)
{
    Console.WriteLine($"{customer.FullName} is {customer.Age} years old");
}

IEnumerable<Customer> GetCustomers()
{
    var lines = File.ReadAllLines("./customers.csv");
    foreach(var line in lines)
    {
        var parts = line.Split(',');
        yield return new Customer(parts[0], int.Parse(parts[1]));
    }
}

record Customer(string FullName, int Age);
