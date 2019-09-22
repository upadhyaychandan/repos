using System;
using EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation;
using EmpSalaryCalucationWith_SimpleFactory.EmpMangerFactoryCreation;
namespace EmpSalaryCalucationWith_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmpMangerFactoryCreation obj = new EmpMangerFactoryCreationforemp();
            IEmpMangerCalcuation empmanger= obj.CreateFactoryForEmp(1);
            empmanger.Salary();
            empmanger.Bouns();
            Console.ReadLine();
        }
    }
}
