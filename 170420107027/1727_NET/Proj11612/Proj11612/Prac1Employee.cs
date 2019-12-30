using System;
using System.Collections.Generic;
using System.Text;

namespace Proj11612
{
    class Prac1Employee
    {
        string name, DOJ;
        int age, BASIC, DA, HRA, PF, GPAY, NPAY;

        public void EnterData()
        {
            Console.Write("Enter name :");
            name = Console.ReadLine();
            Console.Write("Enter Date of Joining :");
            DOJ = Console.ReadLine();
            age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("age is "+ age +" {0} and {1}", age,DOJ);
        }
        static void Main(string[] ar)
        {
            Console.WriteLine("HEllllllooo");
            if (ar.Length!=0 && ar[0].Equals("QUIT"))
            {
                return;
            }
            Prac1Employee emp1 = new Prac1Employee();
            Console.WriteLine("Hiiiiiii");
            Prac1Employee.Main(new string[]{"QUIT"});
            emp1.EnterData();
                     
        }
    }
}
