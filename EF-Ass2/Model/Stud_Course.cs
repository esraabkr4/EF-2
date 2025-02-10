using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass2.Model
{
    public class Stud_Course
    {
        
        
        public int Grade { get; set; }

        #region StudentRelation
        [ForeignKey(nameof(Student))]
        public int Stud_ID { get; set; }
        public Student Student { get; set; }
        #endregion

        #region CourseRelation
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        public Course Course { get; set; }
        #endregion


    }
}
