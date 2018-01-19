using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public sealed class CourseRepository : Repository<Course>, ICourseRepository
    {
        public List<Course> GetCoursesWithAuthors()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetTopSellingCourses()
        {
            throw new NotImplementedException();
        }
    }
}
