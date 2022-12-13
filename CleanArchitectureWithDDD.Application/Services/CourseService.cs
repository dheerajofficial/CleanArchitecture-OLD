using CleanArchitectureWithDDD.Application.Interfaces;
using CleanArchitectureWithDDD.Application.ViewModels;
using CleanArchitectureWithDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDDD.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
