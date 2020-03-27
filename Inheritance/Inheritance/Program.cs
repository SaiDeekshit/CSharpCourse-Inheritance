using System;

namespace Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Programmer p1 = new Programmer();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
        }
    }
    //Parent Class
    public class Employee
    {
        public float salary = 40000;
    }
    //Child Class
    public class Programmer : Employee
    {
        public float bonus = 10000;
    }
}
