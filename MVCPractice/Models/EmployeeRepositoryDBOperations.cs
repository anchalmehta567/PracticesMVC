using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCPractice.Models;

namespace MVCPractice.Models
{
    public class EmployeeRepositoryDBOperations
    {
        public int AddEmployee(EmployeeModel model) 
        {
            using (var context = new BookDBEntities()) 
            {
                Employee_tbl emp = new Employee_tbl()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email= model.Email,
                    
                    Code=model.Code,
                };
                if (model.Address!= null) {
                    emp.Address_tbl = new Address_tbl()
                    {
                        Details = model.Address.Details,
                        Country = model.Address.Country,
                        State = model.Address.State

                    };
                }
                context.Employee_tbl.Add(emp);
                context.SaveChanges();
                 return emp.id;
            }
        
        }
        public List<EmployeeModel> GetAllEmployees() 
        {
            using (var context = new BookDBEntities())
            {
                var result = context.Employee_tbl
                    .Select(x=>new EmployeeModel() 
                    { 
                        id=x.id,
                        AddressId=x.AddressId,
                        Code=x.Code,
                        Email=x.Email,
                        FirstName=x.FirstName,
                        LastName=x.LastName,
                        Address = new AddressModel() 
                        { 
                            id=x.Address_tbl.id,
                            Details=x.Address_tbl.Details,
                            Country=x.Address_tbl.Country,
                            State=x.Address_tbl.State
                        }
                    }).ToList();


             return result;
            }
        }
        public EmployeeModel GetEmployees(int id)
        {
            using (var context = new BookDBEntities())
            {
                var result = context.Employee_tbl
                    .Where(x => x.id==id)
                    .Select(x => new EmployeeModel()
                    {
                        id = x.id,
                        AddressId = x.AddressId,
                        Code = x.Code,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Address = new AddressModel()
                        {
                            id = x.Address_tbl.id,
                            Details = x.Address_tbl.Details,
                            Country = x.Address_tbl.Country,
                            State = x.Address_tbl.State
                        }
                    }).FirstOrDefault();


                return result;
            }
        }
        public bool UpdateEmployee(int id ,EmployeeModel model) 
        {
            using (var context = new BookDBEntities()) 
            {
                var employee = context.Employee_tbl.FirstOrDefault(x => x.id == id);
                if (employee!=null) 
                {
                    employee.FirstName = model.FirstName;
                    employee.LastName = model.LastName;
                    employee.Email = model.Email;
                    employee.Code = model.Code;                      
                }
            
            context.SaveChanges();
            return true;

            }
        }

        public bool DeleteEmployee(int id)
        {
            using (var context = new BookDBEntities())
            {
                var emp = new Employee_tbl()
                {
                    id = id
                };
                context.Entry(emp).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                /*
                var employee = context.Employee_tbl.FirstOrDefault(x => x.id == id);
                if (employee != null) 
                {
                    context.Employee_tbl.Remove(employee);
                    context.SaveChanges();
                    return true;

                }*/
                return false;
            }
        }
    }

}