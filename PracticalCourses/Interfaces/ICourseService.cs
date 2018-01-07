using PCDatabase.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Interfaces
{
    public interface ICourseService
    {
        List<Course> GetThreeNews();

        List<Course> GetThreeBestsellers();
    }
}
