namespace WebAppG5.Models
{
    //Data in Memeory
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>() { 
                new Student(){Id=1,Name="Ahmed",Address="Alex"},
                new Student(){Id=2,Name="Hussien",Address="Alex"},
                new Student(){Id=3,Name="Marwa",Address="Alex"},
            };
        }

        public Student GetByID(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
        public List<Student> GetAll()
        {
            return students;
        }
    }
}
