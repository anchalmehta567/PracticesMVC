using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public abstract class BaseEmployeefactory
    {
        protected Employee _emp;
        public BaseEmployeefactory(Employee emp)
        {
            _emp = emp;
        }
        public Employee ApplySalary() 
        {
            IEmployeeManager manager = this.Create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetPay();
        }
        public abstract IEmployeeManager Create();
    }
}