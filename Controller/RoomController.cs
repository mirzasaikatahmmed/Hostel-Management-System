using Hostel_Management_System.Model;
using System.Collections.Generic;

namespace Hostel_Management_System.Controller
{
    public class RoomController
    {
        public List<RoomModel> GetAllRooms()
        {
            return RoomModel.GetAllRooms();
        }

        public RoomModel GetRoomById(int id)
        {
            return RoomModel.GetRoomById(id);
        }

        public bool AddRoom(RoomModel room)
        {
            return RoomModel.AddRoom(room);
        }

        public bool UpdateRoom(RoomModel room)
        {
            return RoomModel.UpdateRoom(room);
        }
    }
}