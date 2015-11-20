using System;
using System.Collections.Generic;
using EFAnotatedPOC.Context;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Service;


namespace EFAnotatedPOC
{
    public class Program
    {
        private static readonly CurrentStateCallInfoService currentStateCallInfoService = new CurrentStateCallInfoService();
        private static readonly StudentService studentService = new StudentService();
        private static readonly CourseService courseService = new CourseService();

        public static void Main(string[] args)
        {
            try
            {
                PopulateTestData();
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                //Course course = courseService.FindById(11l);
                //studentService.Save(new Student("student12" , course));
                List<Student> students = studentService.GetStudents();
                
                foreach (Student student in students)
                {
                    Course co = student.Course;

                    Console.WriteLine(student.Course.Name);
                }

                //Console.ReadLine();
                //CurrentStateCallInfo currentStateCallInfo = new CurrentStateCallInfo("1", "1" ,"");
                //currentStateCallInfoService.Save(currentStateCallInfo);

                //CurrentStateCallInfo currentStateCallInfo2 = new CurrentStateCallInfo("1", "1" ,"");
                //currentStateCallInfoService.Save(currentStateCallInfo);
            }
            catch (Exception)
            {
                throw;
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
