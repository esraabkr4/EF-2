using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass2.Model
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal? Bonus { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public int? HourRate { get; set; }

        #region Course_InstRelation
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        #endregion

        #region WorkatRelation
        [ForeignKey(nameof(Department))]
        public int? Dep_Id { get; set; }
        [InverseProperty(nameof(Model.Department.Instructors))]
        public Department? Department { get; set; }
        #endregion

        #region ManageRelation
        //[ForeignKey(nameof(ManagerDept))]
        //public int ManagerDep_ID { get; set; }
        [InverseProperty(nameof(Model.Department.Manager))]
        public Department ManagerDept { get; set; }
        #endregion

        


    }
}
