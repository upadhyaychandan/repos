using System;
using System.Collections.Generic;
using System.Text;
using EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation;

namespace EmpSalaryCalucationWith_SimpleFactory.EmpMangerFactoryCreation
{
    /// <summary>
    /// Simple Factory Logic to create Object
    /// </summary>
    public class EmpMangerFactoryCreationforemp : IEmpMangerFactoryCreation
    {
        IEmpMangerCalcuation obj = null;
        public IEmpMangerCalcuation CreateFactoryForEmp(int Emp)
        {
           if(Emp==1)
            {
                return new PermentantEmp();
            }
           else
            {
                return new ContractEmp();
            }
        }
    }
}
