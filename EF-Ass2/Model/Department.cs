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
        
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        #region WorkatRelation
        //[ForeignKey(nameof(Instructors))]
        //public int Ins_ID { get; set; }
        [InverseProperty(nameof(Model.Instructor.Department))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        #endregion

        #region ManageRelation
        [ForeignKey(nameof(Manager))]
        public int Manager_ID { get; set; }
        [InverseProperty(nameof(Model.Instructor.ManagerDept))]
        public Instructor Manager { get; set; } = null!;
        #endregion
    }
}
