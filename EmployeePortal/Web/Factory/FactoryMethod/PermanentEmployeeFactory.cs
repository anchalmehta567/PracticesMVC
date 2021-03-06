using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;
using Web.Factory;
using Web.Factory.FactoryMethod;

namespace Web.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeefactory
    {
        public PermanentEmployeeFactory(Employee emp) :base(emp)
            {
            }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
        
    
}