using CleanArchitectureWithDDD.Domain.Interfaces;
using CleanArchitectureWithDDD.Domain.Models;
using CleanArchitectureWithDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDDD.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
