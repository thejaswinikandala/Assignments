﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class EmployeeSalary
    {
        int empno;
        string ename;
        double basic, HRA, TAX, DA, totalsal, TA;

        public EmployeeSalary(string ename, int empno, double basic)
        {
            this.empno = empno;
            this.ename = ename;
            this.basic = basic;

        }
        public void CaclNetPay()
        {
            DA = basic * 40 / 100;
            HRA = basic * 40 / 100;
            totalsal = basic + HRA + DA;
            TAX = totalsal * 8 / 100;
            TA = totalsal * 10 / 100;
            Console.WriteLine("emp no=" + empno);
            Console.WriteLine("emp name=" + ename);
            Console.WriteLine("emp basic sal=" + basic);
            Console.WriteLine("emp hra=" + HRA);
            Console.WriteLine("emp tax=" + TAX);
            Console.WriteLine("emp travel allowance=" + TA);
        }

        public static void Main(string[] args)
        {
            int empno;
            string ename;
            double basic;
            Console.WriteLine("enter emp num");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter emp name");
            ename = (Console.ReadLine());
            Console.WriteLine("enter emp basic");
            basic = Convert.ToInt32(Console.ReadLine());
            EmployeeSalary s = new EmployeeSalary(ename, empno, basic);
            s.CaclNetPay();


        }
    }
}
