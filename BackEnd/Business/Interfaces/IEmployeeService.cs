using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        Employee Add(Employee employee);
        Employee Update(Employee employee);
        void Delete(Employee employee);
    }
}
