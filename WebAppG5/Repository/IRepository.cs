namespace WebAppG5.Repository
{
    public interface IRepository<T>
    {
        //Common Method(CRUD)
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();

    }
}
