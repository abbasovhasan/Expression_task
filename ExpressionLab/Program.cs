// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

Expression<Func<string, string>> toUpperExp = s => s.ToUpper();
Expression<Func<Employee, string>> toLowerExp = e => e.Name.Substring(0, 1).ToUpper() + e.Name.Substring(1).ToLower();

/*Employee emp = new()
{
    Name = "namE1"

};
string name = toLowerExp.Compile()(emp);
Console.WriteLine(name);*/

/*
string surname = toUpperExp.Compile()("tEstOv");
Console.WriteLine(surname);*/

List<Employee> employees = new()
{

    new Employee()
    {
        Name = "Name1"
    },
    new Employee()
    {
        Name = "Name2"
    },
};

string name = toLowerExp.Compile()(employees[0]);
Console.WriteLine(name);

class Employee
{
    public string Name { get; set; }
}
