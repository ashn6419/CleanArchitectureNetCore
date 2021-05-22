﻿using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();

        }
        public IQueryable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
