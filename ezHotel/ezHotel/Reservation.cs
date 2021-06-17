using System;

namespace ezHotel
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int ClientId { get; set; }
        public string ClientFullName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CurrentStatus { get; set; }
        public int Amount { get; set; }

        public Reservation(int reservationId, int roomId, string roomType, int clientId, string clientFullName,
            DateTime startDate, DateTime endDate, string currentStatus, int amount)
        {
            ReservationId = reservationId;
            RoomId = roomId;
            RoomType = roomType;
            ClientId = clientId;
            ClientFullName = clientFullName;
            StartDate = startDate;
            EndDate = endDate;
            CurrentStatus = currentStatus;
            Amount = amount;
        }
    }
}
