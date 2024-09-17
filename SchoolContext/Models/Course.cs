using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Course
{
    [Key]
    public int CourseId { get; set; }
    public string CourseName { get; set; }

    // علاقة مع الطلاب
    public virtual ICollection<Student> Students { get; set; }
}
