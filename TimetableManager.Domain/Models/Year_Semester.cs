﻿using System.ComponentModel.DataAnnotations;

namespace TimetableManager.Domain.Models
{
    public class Year_Semester
    {
        [Key]
        public int YsId { get; set; }
        public string YsYear { get; set; }
        public string YsSemester { get; set; }
        public string YsShortName { get; set; }
    }
}
