using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EFGeneric.Base.Entity;

namespace EFAnotatedPOC.Domain
{
    [Table("T_COURSE")]
    public class Course : BaseEntity<int>
    {

        [Key]
        [Column("ID")]
        public override int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        public Course() { }

        public Course(string name)
        {
            Name = name;
        }

    }
}
