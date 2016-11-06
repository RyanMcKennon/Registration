using EfRegistration;
using RegistrationDataClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationDataClient.Mappers
{
    public class RoomMapper
    {
        public static RoomDAO MapToRoomDAO(Room room)
        {
            var r = new RoomDAO();
            r.Id = room.RoomID;
            r.RoomNumber = room.RoomNumber.Value;
            return r;
        }


        public static Room MapToRoomDAO(RoomDAO room)
        {
            var r = new Room();
            r.RoomID = room.Id;
            r.RoomNumber = room.RoomNumber;
            return r;
        }
    }
}
