using Repository.Model;
using Repository.Service;

namespace Repository.Servcie
{
    public class SubjectService : ServiceBase<Subject>
    {
        public bool AddManySubjects(List<string> subjectName)
        {
            try
            {
                // Convert province names to Province entities
                var subject = subjectName.ConvertAll(name => new Subject { SubjectName = name });

                // Call the AddMany method from the base class
                return AddMany(subject);
            }
            catch
            {
                // Handle exception or log it
                return false;
            }
        }
    }
}
