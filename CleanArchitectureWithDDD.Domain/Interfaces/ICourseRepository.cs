using CleanArchitectureWithDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDDD.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
