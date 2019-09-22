using System;
using System.Collections.Generic;
using System.Text;

namespace EmpSalaryCalucationWith_SimpleFactory.EmpMangerCalucation
{
    /// <summary>
    /// Emp Manager Interface for Sal Caluation  this Interface use In Emp Type{Permenat, Contract}
    /// </summary>
    public interface IEmpMangerCalcuation
    {
        decimal Salary();
        decimal Bouns();
    }
}
