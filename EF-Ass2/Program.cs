using EF_Ass2.Model;
using EF_Demo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EF_Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseDBContext dbContext = new EnterpriseDBContext();
            dbContext.Database.Migrate();

            #region Create

            #region Add New Topics
            ////Topic top1=new Topic() { Name="Topic1"};
            ////Topic top2=new Topic() { Name="Topic2"};
            ////Topic top3=new Topic() { Name="Topic3"};
            ////Console.WriteLine(dbContext.Entry(top1).State);
            ////Console.WriteLine(dbContext.Entry(top2).State);
            ////Console.WriteLine(dbContext.Entry(top3).State);
            ////dbContext.Topics.Add(top1);
            ////dbContext.Topics.Add(top2);
            ////dbContext.Topics.Add(top3);
            ////Console.WriteLine(dbContext.Entry(top1).State);
            ////Console.WriteLine(dbContext.Entry(top2).State);
            ////Console.WriteLine(dbContext.Entry(top3).State);
            ////dbContext.SaveChanges();
            ////Console.WriteLine("=======================================");
            ////Console.WriteLine($"Top1 = {top1.ID}");
            ////Console.WriteLine($"Top2 = {top2.ID}");
            ////Console.WriteLine($"Top3 = {top3.ID}");
            #endregion

            #region Add New Courses
            //Course cr1 = new Course() { Name = "Course1" , Duration=34 ,Topic_Id=1 };
            //Course cr2 = new Course() { Name = "Course2", Duration=56 , Topic_Id = 2 };
            //Course cr3 = new Course() { Name = "Course3", Duration=40 , Topic_Id = 3 };
            //Console.WriteLine(dbContext.Entry(cr1).State);
            //Console.WriteLine(dbContext.Entry(cr2).State);
            //Console.WriteLine(dbContext.Entry(cr3).State);
            //dbContext.Courses.Add(cr1);
            //dbContext.Courses.Add(cr2);
            //dbContext.Courses.Add(cr3);
            //Console.WriteLine(dbContext.Entry(cr1).State);
            //Console.WriteLine(dbContext.Entry(cr2).State);
            //Console.WriteLine(dbContext.Entry(cr3).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"Course1 = {cr1.ID}");
            //Console.WriteLine($"Course2 = {cr2.ID}");
            //Console.WriteLine($"Course3 = {cr3.ID}");
            #endregion

            #region Add New Instructors
            //Instructor inst1 = new Instructor() { Name = "Instructor1" ,Salary=3500};
            //Instructor inst2 = new Instructor() { Name = "Instructor2",Salary = 7000 };
            //Instructor inst3 = new Instructor() { Name = "Instructor3" ,Salary=1700};
            //Console.WriteLine(dbContext.Entry(inst1).State);
            //Console.WriteLine(dbContext.Entry(inst2).State);
            //Console.WriteLine(dbContext.Entry(inst3).State);
            //dbContext.Instructors.Add(inst1);
            //dbContext.Instructors.Add(inst2);
            //dbContext.Instructors.Add(inst3);
            //Console.WriteLine(dbContext.Entry(inst1).State);
            //Console.WriteLine(dbContext.Entry(inst2).State);
            //Console.WriteLine(dbContext.Entry(inst3).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"inst1 = {inst1.ID}");
            //Console.WriteLine($"inst2 = {inst2.ID}");
            //Console.WriteLine($"inst3 = {inst3.ID}");
            #endregion

            #region Add New Departments
            //Department dept1 = new Department() { Name = "Dept1" ,HiringDate=DateTime.Now,Manager_ID=1};
            //Department dept2 = new Department() { Name = "Dept2", HiringDate = DateTime.Now, Manager_ID = 2 };
            //Console.WriteLine(dbContext.Entry(dept1).State);
            //Console.WriteLine(dbContext.Entry(dept2).State);
            //dbContext.Departments.Add(dept1);
            //dbContext.Departments.Add(dept2);
            //Console.WriteLine(dbContext.Entry(dept1).State);
            //Console.WriteLine(dbContext.Entry(dept2).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"Dept1 = {dept1.ID}");
            //Console.WriteLine($"Dept2 = {dept2.ID}");
            #endregion

            #region Add New Students
            //Student stud1 = new Student() { FName = "Stud1" , Dep_Id=7};
            //Student stud2 = new Student() { FName = "Stud2", Dep_Id = 7};
            //Student stud3 = new Student() { FName = "Stud3", Dep_Id = 7};
            //Console.WriteLine(dbContext.Entry(stud1).State);
            //Console.WriteLine(dbContext.Entry(stud2).State);
            //Console.WriteLine(dbContext.Entry(stud3).State);
            //dbContext.Students.Add(stud1);
            //dbContext.Students.Add(stud2);
            //dbContext.Students.Add(stud3);
            //Console.WriteLine(dbContext.Entry(stud1).State);
            //Console.WriteLine(dbContext.Entry(stud2).State);
            //Console.WriteLine(dbContext.Entry(stud3).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"stud1 = {stud1.ID}");
            //Console.WriteLine($"stud2 = {stud2.ID}");
            //Console.WriteLine($"stud3 = {stud3.ID}");
            #endregion

            #region Add New Stud-Courses
            //Stud_Course stc1 = new Stud_Course() { Stud_ID=2,Course_ID=1,Grade=45 };
            //Stud_Course stc2 = new Stud_Course() { Stud_ID = 4, Course_ID = 1, Grade = 90 };
            //Stud_Course stc3 = new Stud_Course() { Stud_ID = 3, Course_ID = 1, Grade = 77 };
            //Console.WriteLine(dbContext.Entry(stc1).State);
            //Console.WriteLine(dbContext.Entry(stc2).State);
            //Console.WriteLine(dbContext.Entry(stc3).State);
            //dbContext.Stud_Courses.Add(stc1);
            //dbContext.Stud_Courses.Add(stc2);
            //dbContext.Stud_Courses.Add(stc3);
            //Console.WriteLine(dbContext.Entry(stc1).State);
            //Console.WriteLine(dbContext.Entry(stc2).State);
            //Console.WriteLine(dbContext.Entry(stc3).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"StudCourse1 = {stc1.Grade}");
            //Console.WriteLine($"StudCourse2 = {stc2.Grade}");
            //Console.WriteLine($"StudCourse3 = {stc3.Grade}");
            #endregion

            #region Add New Course-Instructor
            //Course_Inst cins1 = new Course_Inst() { Inst_ID = 1, Course_ID = 1 };
            //Course_Inst cins2 = new Course_Inst() { Inst_ID = 2, Course_ID = 2 };
            //Course_Inst cins3 = new Course_Inst() { Inst_ID = 3, Course_ID = 2 };
            //Console.WriteLine(dbContext.Entry(cins1).State);
            //Console.WriteLine(dbContext.Entry(cins2).State);
            //Console.WriteLine(dbContext.Entry(cins3).State);
            //dbContext.Course_Insts.Add(cins1);
            //dbContext.Course_Insts.Add(cins2);
            //dbContext.Course_Insts.Add(cins3);
            //Console.WriteLine(dbContext.Entry(cins1).State);
            //Console.WriteLine(dbContext.Entry(cins2).State);
            //Console.WriteLine(dbContext.Entry(cins3).State);
            //dbContext.SaveChanges();
            //Console.WriteLine("=======================================");
            //Console.WriteLine($"Course_Inst1 = {cins1.Inst_ID}");
            //Console.WriteLine($"Course_Inst2 = {cins2.Inst_ID}");
            //Console.WriteLine($"Course_Inst3 = {cins3.Inst_ID}");
            #endregion

            #endregion
            #region Read

            #region Read Students
            //var student=dbContext.Students.Where(s=>s.ID==3).Select(s=>s.FName).FirstOrDefault();
            //Console.WriteLine($"Student FName= {student}");
            #endregion

            #region Read Instructors
            //var instructor = dbContext.Instructors.Where(i => i.ID == 3).Select(i => i.Name).FirstOrDefault();
            //Console.WriteLine($"Instructor Name= {instructor}");
            #endregion

            #region Read Departments
            //var dept = dbContext.Departments.Where(d => d.ID == 7).Select(s => s.Name)?.FirstOrDefault();
            //Console.WriteLine($"Department Name= {dept}");
            #endregion

            #region Read Courses
            //var course = dbContext.Courses.Where(c => c.ID == 2).Select(c => c.Name)?.FirstOrDefault();
            //Console.WriteLine($"Courses Name= {course}");
            #endregion

            #region Read Topics
            //var Topic = dbContext.Topics.Where(t => t.ID == 2).Select(t => t.Name)?.FirstOrDefault();
            //Console.WriteLine($"Topics Name= {Topic}");
            #endregion

            #endregion

            #region Update

            #region Update Students
            //var student = dbContext.Students.Where(s => s.ID == 3).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(student).State);
            //student.FName = "Updated-stud-name";
            //Console.WriteLine(dbContext.Entry(student).State);
            //dbContext.SaveChanges();
            #endregion

            #region Update Instructors
            //var instructor = dbContext.Instructors.Where(i => i.ID == 3).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(instructor).State);
            //instructor.Name = "Updated-Inst-name";
            //Console.WriteLine(dbContext.Entry(instructor).State);
            //dbContext.SaveChanges();
            #endregion

            #region Update Departments
            //var dept = dbContext.Departments.Where(d => d.ID == 7).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(dept).State);
            //dept.Name = "Updated-Dept-name";
            //Console.WriteLine(dbContext.Entry(dept).State);
            //dbContext.SaveChanges();
            #endregion

            #region Update Courses
            //var course = dbContext.Courses.Where(c => c.ID == 2).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(course).State);
            //course.Name = "Updated-course-name";
            //Console.WriteLine(dbContext.Entry(course).State);
            //dbContext.SaveChanges();
            #endregion

            #region Update Topics
            //var Topic = dbContext.Topics.Where(t => t.ID == 2).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Topic).State);
            //Topic.Name = "Updated-Topic-name";
            //Console.WriteLine(dbContext.Entry(Topic).State);
            //dbContext.SaveChanges();
            #endregion

            #endregion

            #region Delete

            #region Delete Students
            //var student = dbContext.Students.Where(s => s.ID == 4).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(student).State);
            //dbContext.Students.Remove(student);
            //Console.WriteLine(dbContext.Entry(student).State);
            //dbContext.SaveChanges();
            #endregion

            #region Delete Instructors
            //var instructor = dbContext.Instructors.Where(i => i.ID == 3).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(instructor).State);
            //dbContext.Instructors.Remove(instructor);
            //Console.WriteLine(dbContext.Entry(instructor).State);
            //dbContext.SaveChanges();
            #endregion

            #region Delete Departments
            //var dept = dbContext.Departments.Where(d => d.ID == 7).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(dept).State);
            //dbContext.Departments.Remove(dept);
            //Console.WriteLine(dbContext.Entry(dept).State);
            //dbContext.SaveChanges();
            #endregion

            #region Delete Courses
            //var course = dbContext.Courses.Where(c => c.ID == 2).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(course).State);
            //dbContext.Courses.Remove(course);
            //Console.WriteLine(dbContext.Entry(course).State);
            //dbContext.SaveChanges();
            #endregion

            #region Delete Topics
            //var Topic = dbContext.Topics.Where(t => t.ID == 2).FirstOrDefault();
            //Console.WriteLine(dbContext.Entry(Topic).State);
            //dbContext.Topics.Remove(Topic);
            //Console.WriteLine(dbContext.Entry(Topic).State);
            //dbContext.SaveChanges();
            #endregion

            #endregion
        }
    }
}
