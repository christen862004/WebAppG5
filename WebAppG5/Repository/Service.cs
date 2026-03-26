namespace WebAppG5.Repository
{
    public class Service:IService
    {
        public Service()
        {
            Id = Guid.NewGuid().ToString(); ;//jgjasgjasgfj
        }
        public string Id { get; set; }

    }
}
