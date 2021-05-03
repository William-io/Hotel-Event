using System;

namespace HotelEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciando método de Teste
            //Quantos quarto vão está disponiveis no hotel?(3)

            var room = new MakeBooking(2);
            room.RoomSoldOutEvent += room.OnRoomSoldOut;

            //Número de reservas 
            room.Bookings();
            room.Bookings();
            room.Bookings();
            room.Bookings();
            room.Bookings();
            room.Bookings();


        }
    }
}
