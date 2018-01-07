using AutoMapper;
using PCDatabase.DAL;
using PracticalCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticalCourses.Mapping
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CourseRequest, Course>();
            CreateMap<Course, CourseResponse>();
        }
    }
}
