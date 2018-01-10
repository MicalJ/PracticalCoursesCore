using PCDatabase.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetByCourseId(string nameCategory);

        List<Course> GetThreeNews();

        List<Course> GetThreeBestsellers();

        Course GetById(int courseId);
    }
}
