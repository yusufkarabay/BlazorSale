using Business.Interfaces;
using Entities.Entities;

namespace Business.Managers
{
    public class EmployeeManager : IEmployeeService
    {
        public Task<Employee> Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
