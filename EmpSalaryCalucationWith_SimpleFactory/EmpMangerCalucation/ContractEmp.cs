using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation
{
    /// <summary>
    /// Implementaion Of Contract Emp;
    /// </summary>
    public class ContractEmp : IEmpMangerCalcuation
    {
        public decimal Bouns()
        {
            return 5;
        }

        public decimal Salary()
        {
            return 8;
        }
    }
}
