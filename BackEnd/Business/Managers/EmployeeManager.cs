using Business.Interfaces;
using DataAccess.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal=employeeDal;
        }

        public Employee Add(Employee employee)
        {
            return _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetList();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(x => x.Id==id);
        }


        public Employee Update(Employee employee)
        {
            return _employeeDal.Update(employee);
        }
    }
}
