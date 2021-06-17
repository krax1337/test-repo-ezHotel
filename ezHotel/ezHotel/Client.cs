using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezHotel
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string PassportNumber { get; set; }

        public Client(int clientId, string firstName, string lastName, string phone, string email, string country, string passportNumber)
        {
            ClientId = clientId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Country = country;
            PassportNumber = passportNumber;
        }
    }
}
