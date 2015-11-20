using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFGeneric.Base.Entity;

namespace EFAnotatedPOC.Domain
{
    [Table("T_STUDENT")]
    public class Student : BaseEntity<long>
    {

        [Key]
        [Column("ID")]
        public override long Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("COURSE_ID")]
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        public Student() { }

        public Student(string name, Course course)
        {
            Name = name;
            Course = course;
        }

    }

}
