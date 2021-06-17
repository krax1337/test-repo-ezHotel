using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ezHotel.Tests
{
    [TestClass]
    public class Main
    {
        [TestMethod]
        public void TestRoom()
        {
            var room = new Room(1, 1, false, "Some", 3, 3200);
        }

        [TestMethod]
        public void TestReservation()
        {
            var reservation = new Reservation(1, 1, "Some", 1, "Some", DateTime.Now, DateTime.Now, "Some", 1000);
        }

        [TestMethod]
        public void TestClient()
        {
            var client = new Client(1, "Some", "Some", "Some", "Some", "Some", "Some");
        }
    }
}
