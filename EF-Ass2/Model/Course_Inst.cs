using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass2.Model
{
    public class Course_Inst
    {
        public int evaluate { get; set; }

        #region InstructorRelation
        [ForeignKey(nameof(Instructor))]
        public int Inst_ID { get; set; }
        public Instructor Instructor { get; set; } 
        #endregion

        #region CourseRelation
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; } 
        #endregion
    }
}
