using Expression_task2.Modules;
using System.Linq.Expressions;

namespace Expression_task2
{

    public class Program
    {
        static void Main(string[] args)
        {

            List<Employees> employees = new List<Employees>
        {
        new Employees{FirstName = "David", LastName = "Beckham"},
        new Employees{FirstName = "Luis", LastName = "Nani"},
        new Employees{FirstName = "Carlos", LastName = "Henric"},
            };


            Expression<Func<Employees, string>> name = n => n.FirstName;


        }
    }
}