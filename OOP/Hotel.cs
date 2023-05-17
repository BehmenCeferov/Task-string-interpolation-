using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
Hotel hotel = new Hotel("Hilton Hotel", "1B Azadlig Avenue, Baku 1000");
hotel.GetPriceRoomAndCount(120, 2);
namespace OOP
{
    public class Hotel
    {
        public Guid Id { get; private set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public Hotel(string hotelName, string address)
        {
            HotelName = hotelName;
            Address = address;
            Id = Guid.NewGuid();
        }

        public void GetPriceRoomAndCount(int roomPrice, int roomCount)
        {
            if ((roomCount < 1 || roomCount > 200) || (roomPrice < 60 || roomPrice > 150))
            {
                Console.WriteLine("Invalid room count or price!");
            }
            else
            {
                roomPrice *= roomCount;
                Console.WriteLine($"Hotel Name: {HotelName} " +
                    $"Hotel adress: {Address} " +
                    $"Room Id: {Id} " +
                    $"RoomCount: {roomCount} " +
                    $"RoomPrice: {roomPrice}");
            }
        }
    }
}
