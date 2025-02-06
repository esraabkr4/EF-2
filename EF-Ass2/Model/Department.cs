using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass2.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        public DateOnly HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #region InstructorRelation
        [ForeignKey("Instructor")]
        public int Ins_ID { get; set; }
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion

    }
}
