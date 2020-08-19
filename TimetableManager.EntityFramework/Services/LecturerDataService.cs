﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableManager.Domain.Models;

namespace TimetableManager.EntityFramework.Services
{
    public class LecturerDataService
    {
        private readonly TimetableManagerDbContext _context;

        public LecturerDataService(TimetableManagerDbContext context)
        {
            _context = context;
        }

        public Task<int> AddLecturer(Lecturer lecturer, string fName, string dName, string cName, string bName, string lName)
        {
            var faculty = _context.Faculties.Include(e => e.Lecturers).Single(e => e.FacultyName == fName);
            faculty.Lecturers.Add(lecturer);

            var department = _context.Departments.Include(e => e.Lecturers).Single(e => e.DepartmentName == dName);
            department .Lecturers.Add(lecturer);

            var center = _context.Centers.Include(e => e.Lecturers).Single(e => e.CenterName == cName);
            center.Lecturers.Add(lecturer);

            var building = _context.Buildings.Include(e => e.Lecturers).Single(e => e.BuildingName == bName);
            building.Lecturers.Add(lecturer);

            var level = _context.Levels.Include(e => e.Lecturers).Single(e => e.LevelName == lName);
            level.Lecturers.Add(lecturer);

            return _context.SaveChangesAsync();
        }
    }
}
