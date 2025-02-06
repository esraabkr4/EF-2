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
        public decimal Bonus { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        #region DepartmentRelation
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }
        #endregion

    }
}
