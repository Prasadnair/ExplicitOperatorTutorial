// See https://aka.ms/new-console-template for more information
using ExplicitOperator;

Console.WriteLine("Demo for Explicit Operator");
Console.WriteLine("==========================");
Console.WriteLine();
var manager=new Manager { Name = "John", Age = 35 };
Employee employee = (Employee)manager;

Console.WriteLine($"Employee Name: {employee.Name}");
Console.WriteLine($"Employee Age: {employee.Age}");
Console.ReadLine();

