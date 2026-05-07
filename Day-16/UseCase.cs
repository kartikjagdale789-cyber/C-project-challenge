public interface IStudentRepository
{
    List<string> GetStudents();
}

public class StudentService
{
    private readonly IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public List<string> Execute()
    {
        return _repo.GetStudents();
    }
}