using Repository.Model;
using Repository.Service;

namespace Repository.Servcie
{
    public class StudentService : ServiceBase<Student>
    {
        public bool AddManyStudent(List<Student> students)
        {
            try
            {
                
                return AddMany(students);
            }
            catch
            {
                return false;
            }
        }
    }
}
