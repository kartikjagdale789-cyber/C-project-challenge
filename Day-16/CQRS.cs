// Command
public class CreateStudent
{
    public string Name { get; set; }
}

// Query
public class GetStudents
{
}

// Handler
public class Handler
{
    static List<string> db = new List<string>();

    public void Handle(CreateStudent cmd)
    {
        db.Add(cmd.Name);
    }

    public List<string> Handle(GetStudents query)
    {
        return db;
    }
}