using WebAppG5.Models;

namespace WebAppG5.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        StepsContext context;
        public EmployeeRepository(StepsContext ctx)
        {
            context = ctx;// new StepsContext();
        }
        public void Add(Employee entity)
        {
            context.Employees.Add(entity);
        }

        public void Delete(int id)
        {
            Employee employee=GetById(id);
            context.Employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return context.Employees.FirstOrDefault(e => e.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Employee entity)
        {
            //old ref
            Employee empFromDb=GetById(entity.Id);
            //map
            empFromDb.Name=entity.Name;
            empFromDb.Salary = entity.Salary;
            empFromDb.ImageURL = entity.ImageURL;
            empFromDb.DepartmentId = entity.DepartmentId;
        }
    }
}
