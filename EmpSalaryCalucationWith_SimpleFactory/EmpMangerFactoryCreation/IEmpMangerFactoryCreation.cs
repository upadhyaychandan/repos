using EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryCalucationWith_SimpleFactory.EmpMangerFactoryCreation
{
    interface IEmpMangerFactoryCreation
    {
        IEmpMangerCalcuation CreateFactoryForEmp(int Emp);
    }
}
