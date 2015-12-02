﻿using System;
using System.Collections.Generic;
using System.Linq;
using EFAnotatedPOC.Domain;
using EFAnotatedPOC.Repository;

namespace EFAnotatedPOC.Service
{
    public class CourseService
    {
        private CourseRepository courseRepository;

        public CourseService()
        {
            courseRepository = new CourseRepository();
        }

        public void Save(Course course)
        {
            courseRepository.Add(course);
        }

        public Course Merge(Course course)
        {
            return courseRepository.Merge(course);
        }

        public void Delete(Course course)
        {
            try
            {
                courseRepository.SoftDelete(course);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public Course FindById(long courseId)
        {
            return courseRepository.FindById(courseId);
        }

        public Course FindFirstOne()
        {
            return courseRepository.First();
        }

        public List<Course> GetAllCourses()
        {
            return courseRepository.CurrentSession.ToList();
        } 

    }
}
