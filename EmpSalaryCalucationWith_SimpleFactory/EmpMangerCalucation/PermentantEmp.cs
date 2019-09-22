using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation
{
    /// <summary>
    /// Concert Implation for IEmpMangerCalcuation
    /// </summary>
    public class PermentantEmp : IEmpMangerCalcuation
    {
        public decimal Bouns()
        {
            return 10;
        }

        public decimal Salary()
        {
            return 10;
        }
    }
}
