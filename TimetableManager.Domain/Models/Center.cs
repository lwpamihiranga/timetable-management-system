﻿using System.Collections.Generic;

namespace TimetableManager.Domain.Models
{
    public class Center
    {
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public List<Building> Buildings { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
