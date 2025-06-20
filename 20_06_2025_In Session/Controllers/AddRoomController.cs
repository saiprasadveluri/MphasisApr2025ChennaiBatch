using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomManagerMVCApp.Data;
using RoomManagerMVCApp.DTO;
using System.Reflection.Metadata.Ecma335;

namespace RoomManagerMVCApp.Controllers
{  
    public class AddRoomController : Controller
    {
        RoomManagerDbContext context;
        ILogger<AddRoomController> _logger;
        public AddRoomController(RoomManagerDbContext ctx,ILogger<AddRoomController> logger)
        {
            context = ctx;
            _logger= logger;
        }
        [HttpGet]
        public IActionResult ReserveRoom(Guid RID)
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewRooms()
        {
            MeetingRoomViewDTO model = new MeetingRoomViewDTO();
            List<MeetingRoom> Mrooms = context.MeetingRooms.ToList();
            _logger.LogInformation("Data Fetched");
            foreach (MeetingRoom room in Mrooms)
            {
                RoomEntry roomEntry = new RoomEntry()
                {
                    RoomId = room.RoomId,
                    Name = room.RoomName,
                    Location = room.Location,
                    Capacity = room.Capacity,
                };
                model.rooms.Add(roomEntry);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            MeetingRoomDTO meetingRoomDTO = new MeetingRoomDTO();
            return View(meetingRoomDTO);
        }
        [HttpPost]
        public IActionResult Add(MeetingRoomDTO model)
        {            
            MeetingRoom rrom = new MeetingRoom()
            {
                RoomId = Guid.NewGuid(),
                RoomName = model.RoomName,
                Capacity = model.Capacity,
                Location = model.Location,
            };
            context.MeetingRooms.Add(rrom);
            context.SaveChanges();
           
            return View(model);
        }
    }
}
