using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Ass2.Model
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        

        #region StudCourseRelation
        public ICollection<Stud_Course> Stud_Course { get; set; } = new HashSet<Stud_Course>();
        #endregion

        #region Course_InstRelation
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        #endregion

        #region TopicRelation
        [ForeignKey("Topic")]
        public int Topic_Id { get; set; }
        public Topic Topic { get; set; }
        #endregion
    }
}
