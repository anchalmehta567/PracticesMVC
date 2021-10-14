using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeefactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {

            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();
          //  _emp.HouseAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }
}