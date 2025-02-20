﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {

        public static IRepo<Employee, int, Employee> EmployeeData() {
            return new EmployeeRepo();
        }
        public static IRepo<Course, int, bool> CourseData() {
            return new CourseRepo();
        }
    }
}
