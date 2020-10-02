﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TimetableManager.Domain.Models;

namespace TimetableManager.EntityFramework.Services
{
    public class TimeSlotDataService
    {
        private readonly TimetableManagerDbContext _context;

        public TimeSlotDataService(TimetableManagerDbContext context)
        {
            _context = context;
        }
        public async Task<List<TimeSlot>> GetTimeSlotsAsync()
        {
            return await _context.TimeSlots
                    .Include(e => e.LecturerUnavailableTimeSlots)
                    .ThenInclude(e => e.Lecturer)
                    .Include(e => e.SessionUnavailableTimeSlots)
                    .ThenInclude(e => e.Session)
                    .Include(e => e.GroupIdUnavailableTimeSlots)
                    .ThenInclude(e => e.Group)
                    .Include(e => e.SubGroupIdUnavailableTimeSlots)
                    .ThenInclude(e => e.SubGroup)
                    .ToListAsync();
        }
    }
}