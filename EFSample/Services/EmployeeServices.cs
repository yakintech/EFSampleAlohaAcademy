using EFSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Services
{
    public class EmployeeServices
    {
        public static bool Add(Employee employee)
        {
			try
			{
                AlohaECommerceContext db = new AlohaECommerceContext();

                db.Employees.Add(employee);
                db.SaveChanges();

                return true;
            }
			catch (Exception)
			{
                return false;
			}
        }


        public static List<Employee> GetAll()
        {
            AlohaECommerceContext db = new AlohaECommerceContext();
            List<Employee> employees = db.Employees.ToList();
            return employees;
        }
    }
}
