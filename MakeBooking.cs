using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelEvent
{
    public class MakeBooking
    {

        private int RoomsInUse = 0;
        public int Rooms { get; set; }

        public MakeBooking(int rooms)
        {
            RoomsInUse = 0;
            Rooms = rooms;
        }

        public void Bookings()
        {
            RoomsInUse++;
            if (RoomsInUse >= Rooms)
            {
                //Evento Fechado! Sala está cheia.
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Quarto Reservado!");
            }
        }

        public event EventHandler RoomSoldOutEvent;

        protected virtual void OnRoomSoldOut(EventArgs test)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, test);
        }

        public void OnRoomSoldOut(object sender, EventArgs test)
        {
            Console.WriteLine("Hotel Lotado!");
        }





    }
}
