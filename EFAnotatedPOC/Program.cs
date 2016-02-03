using System;
using System.Collections.Generic;
using System.Data;
using Domain.Domain;
using EFService.Service;


namespace EFAnotatedPOC
{
    public class Program
    {
        private static readonly CurrentStateCallInfoService currentStateCallInfoService = new CurrentStateCallInfoService();
        private static readonly StudentService studentService = new StudentService();
        private static readonly CourseService courseService = new CourseService();
        
        public static void Main(string[] args)
        {

            //try
            //{
            //    PopulateTestData();
            //}
            //catch (Exception)
            //{
            //    throw;
            //}


            try
            {

                currentStateCallInfoService.Save(new CurrentStateCallInfo("a","a","sss",0));

                Console.Out.WriteLine(SqlDbType.DateTime);

                Course firstCourse = courseService.FindFirstOne();

                Console.WriteLine("First Course ID : " + firstCourse.Id);

                Course foundCourse = courseService.FindById(firstCourse.Id);

                Console.WriteLine("Found Course : " + foundCourse.Id + " " + foundCourse.Name + " " + foundCourse.CreateDate + " " + foundCourse.IsDeleted);

                foundCourse.Name = "Turgay CAN222";
                foundCourse.IsDeleted = true;
                Course mergedCourse = courseService.Merge(firstCourse);

                courseService.Delete(firstCourse);

                Console.WriteLine("Merged Course : " + mergedCourse.Id + " " + mergedCourse.Name + " " + firstCourse.CreateDate + " " + mergedCourse.IsDeleted);

                Course newCourse = new Course("course new ");
                courseService.Save(newCourse);

                //courseService.Save(new Course("course22"));
                //Course course = courseService.FindById(11l);
                //studentService.Save(new Student("student12" , course));
                List<Student> students = studentService.GetStudents();
                
                foreach (Student student in students)
                {
                    Course co = student.Course;

                    List<Student> courseStudents = co.Students;
                    int courseStudentCount = courseStudents.Count;
                    foreach (Student eachStudent in courseStudents)
                    {
                        //
                    }

                    Console.WriteLine(student.Course.Name);
                }

                foreach (Course course in courseService.GetAllCourses())
                {
                    Console.WriteLine("Not Soft Deleted Found Course : " + course.Id + " " + course.Name + " " + course.CreateDate + " " + course.IsDeleted);
                }

                Console.ReadLine();
                //CurrentStateCallInfo currentStateCallInfo = new CurrentStateCallInfo("1", "1" ,"");
                //currentStateCallInfoService.Save(currentStateCallInfo);

                //CurrentStateCallInfo currentStateCallInfo2 = new CurrentStateCallInfo("1", "1" ,"");
                //currentStateCallInfoService.Save(currentStateCallInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }

        }


        private static void PopulateTestData()
        {
            courseService.Save(new Course("course1"));
            Course course = courseService.FindById(1);

            for (var index = 1; index <= 10; index++)
            {
                studentService.Save(new Student("student" + index, course));
            }
        }
    }
}
