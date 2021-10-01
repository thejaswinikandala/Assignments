/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class BankAccount
    {
         double balance;

         public BankAccount()
        {
            balance = 500;
        }
        public BankAccount(double balance )
        {
           
            
                this.balance = balance;
        }
       

       
        public  double getBalance()
        {
            return balance;
        }
        
       
    }
    class BankTest
    {
        public static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount( );
            Console.WriteLine("default balance="+b1.getBalance());
            BankAccount b2 = new BankAccount(1000);
            Console.WriteLine("main balance="+b2.getBalance());

        }
    }
    
   class Customer
    {
        public string Name { get; set; }
        public double balance { get; set; }
         public int i { get; set; } 
    }
    class CusomerTest
    {
        public static void Main()
        {
            Customer c1 = new Customer { Name = "theja", balance = 500 ,i=1};
            
            for (c1.i = 1; c1.i <= 10;c1.i++)
            {
                if (c1.balance != 500)
                    Console.WriteLine(c1.balance);
                else
                    Console.WriteLine(c1.balance + c1.i);

                
            }
        }
    }
}
*/