using WebAppG5.Models;

namespace WebAppG5.Repository
{
    public class DepartmentRespository : IDepartmentRepository
    {
        //Crud: Create - Readd - Update- Delete
        StepsContext context;
        public DepartmentRespository(StepsContext ctx)
        {
            context = ctx; //new StepsContext();//call on configure
        }
        public void Add(Department entity)
        {
            context.Departments.Add(entity);

        }

        public void Delete(int id)
        {
            Department dept=GetById(id);
            context.Departments.Remove(dept);
        }

        public List<Department> GetAll()
        {
            return context.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return context.Departments.FirstOrDefault(d => d.Id == id);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Department entity)
        {
            //old ref from db
            Department deptFromDb=GetById(entity.Id);
            //map
            deptFromDb.Name = entity.Name;
            deptFromDb.ManagerName = entity.ManagerName;

        }
    }
}
