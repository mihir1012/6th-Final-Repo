using System;
using System.Collections.Generic;
using System.Text;

namespace Net
{
    public class Employee
    {
         public String Name, Age, JoiningDate;
         public Double Basic, Da, Hra, Pf;
         public Double GrossPay, NetPay;

        public Employee()
        {
            Console.WriteLine("Enter Name, Age, JoiningDate, Basic");
            Name = Console.ReadLine();
            Age = Console.ReadLine();
            JoiningDate = Console.ReadLine();
            Basic = Convert.ToDouble(Console.ReadLine());


            Da = 1.1 * Basic;
            Hra = 0.2 * Basic;
            Pf = 0.12 * Basic;
            GrossPay = Basic + Da + Hra;
            NetPay = GrossPay - Pf;
        }
        public void display()
        {
            Console.WriteLine("Name: " + Name + "\nAge: " + Age +"\nJoining Date: " + JoiningDate
                + "\nBasic:" + Basic + "\nDa:" + Da + "\nHra:" + Hra + "\nPf:" + Pf + "\nGrossPay:" +
                +GrossPay + "\nNetPay:" + NetPay);
        }
         
    }
}
