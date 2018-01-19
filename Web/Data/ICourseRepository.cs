using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public interface ICourseRepository : IRepository<Course>
    {
        List<Course> GetTopSellingCourses();

        List<Course> GetCoursesWithAuthors();
    }
}
