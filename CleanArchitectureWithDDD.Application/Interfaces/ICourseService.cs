using CleanArchitectureWithDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureWithDDD.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses(); 
    }
}
