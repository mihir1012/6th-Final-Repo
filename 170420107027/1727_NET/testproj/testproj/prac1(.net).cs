using System;
using System.Collections.Generic;
using System.Text;

namespace testproj
{
   class employee
    {
        string emp_name, DOJ;
        int age, basic_pay; 
        double DA, HRA, PF, gross_net, net_pay;

       public employee()
        {
            Console.WriteLine("\nEnter the name of Employee:");
            emp_name=Console.ReadLine();

            Console.WriteLine("\nEnter the age of Employee:");
            age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Date of Joining of Employee:");
            DOJ=Console.ReadLine();

            Console.WriteLine("\nEnter the salary of Employee:");
            basic_pay=Convert.ToInt32(Console.ReadLine());

        }

        public void calculate()
        {
            DA = (basic_pay * 1.10);
            HRA = (basic_pay * 0.20);
            PF = (basic_pay * 0.12);
            gross_net = basic_pay + DA + HRA;
            net_pay = gross_net - PF; 
        }

        public void display()
        {
            Console.WriteLine("\nEmployee Name:"+emp_name);
            Console.WriteLine("\nEmployee Age:" + age);
            Console.WriteLine("\nEmployee Date of joining:" + DOJ);
            Console.WriteLine("\nEmployee Basic Pay:" + basic_pay);
            Console.WriteLine("\nEmployee DA:" + DA);
            Console.WriteLine("\nEmployee HRA:" + HRA);
            Console.WriteLine("\nEmployee PF:" + PF);
            Console.WriteLine("\nEmployee Gross Pay:" + gross_net);
            Console.WriteLine("\nEmployee Net Pay:" + net_pay);
        }
    }

   class prac1_
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.calculate();
            e.display();
        }
            
    }
}
