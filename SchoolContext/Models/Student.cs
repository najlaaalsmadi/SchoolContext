using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Student
{
    [Key]
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // علاقة مع الدورات
    public virtual ICollection<Course> Courses { get; set; }
}
