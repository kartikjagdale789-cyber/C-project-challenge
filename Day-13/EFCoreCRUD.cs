using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("your_connection_string");
}

class EFCoreCRUD
{
    static void Main()
    {
        using var db = new AppDbContext();

        // CREATE
        db.Students.Add(new Student { Name = "Ajay" });
        db.SaveChanges();

        // READ
        var students = db.Students.ToList();
        students.ForEach(s => Console.WriteLine(s.Name));

        // UPDATE
        var student = db.Students.First();
        student.Name = "Raj";
        db.SaveChanges();

        // DELETE
        db.Students.Remove(student);
        db.SaveChanges();
    }
}