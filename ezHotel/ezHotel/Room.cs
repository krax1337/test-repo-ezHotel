using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezHotel
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Floor { get; set; }
        public bool Occupied { get; set; }
        public string RoomType { get; set; }
        public int NumberOfBeds { get; set; }
        public int Price { get; set; }

        public Room(int roomId, int floor, bool occupied, string roomType, int numberOfBeds, int price)
        {
            RoomId = roomId;
            Floor = floor;
            Occupied = occupied;
            RoomType = roomType;
            NumberOfBeds = numberOfBeds;
            Price = price;
        }
    }
}
