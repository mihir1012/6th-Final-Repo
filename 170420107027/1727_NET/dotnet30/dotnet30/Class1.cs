using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet30
{
    class Employee
    {
        string name;
        int age;
        string joining_date;
        double basic, da, hra, pf, gross, net;

        void show()
        {
            da = 1.1 * basic;
            hra = 0.2 * basic;
            pf = 0.12 * basic;
            gross = basic + da + hra;
            net = gross - pf;
            Console.Write("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",name, age, joining_date,basic,gross,net);
        }

        void get()
        {
            Console.WriteLine("Enter anem, age, joining date and basic pay: ");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            joining_date = Console.ReadLine();
            basic = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.get();
            e1.show();
        }
    }
}
