﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimetableManager.Domain.Models;

namespace TimetableManager.EntityFramework.Services
{
    public class RoomDataService
    {
        private readonly TimetableManagerDbContext _context;


        public RoomDataService(TimetableManagerDbContext context)
        {
            _context = context;
        }


        public Task<int> AddRooms(Room rooms, string cName, string buildName)
        {

           var center = _context.Centers.Include(e => e.Rooms).Single(e => e.CenterName == cName);
            center.Rooms.Add(rooms);

            var building = _context.Buildings.Include(e => e.Rooms).Single(e => e.BuildingName == buildName);
            building.Rooms.Add(rooms);

            return _context.SaveChangesAsync();
        }

        
        public async Task<List<Room>> GetRoomAsync()
        {
            return await _context.Rooms.Include(e => e.Center)
                                    .Include(f => f.Building).ToListAsync();
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _context.Rooms.Include(e => e.Center).Include(e => e.Building).Where(e => e.RoomId == id).FirstAsync();
        }

        public async Task<int> deleteRooms(int id)
        {
            var rr = _context.Rooms.Where(e => e.RoomId == id).First();

            _context.Rooms.Remove(rr);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateRoom(Room room)
        {
            Room newRoom = await GetRoomById(room.RoomId);

            newRoom.RoomName = room.RoomName;
            newRoom.Capacity = room.Capacity;

            return await _context.SaveChangesAsync();
        }

    }


}
