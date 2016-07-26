using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
   public class Room
    {
     
        private int roomNo;
        private string location;
        private string basicFacilites;

        // displaying room types
        public int RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string BasicFacilities
        {
            get { return basicFacilites; }
            set { basicFacilites = value; }
        }
        public static void DisplayRoomType()
        {
            Console.WriteLine(" A - Single rooms\n B - Double rooms\n C - Family rooms");
        }

        // display details of room type which is selected by user
        public static void DisplayRoomDetails()
        {
            Console.WriteLine("Please select room type : ");
            string setRoomType = Console.ReadLine().ToLower();
            if (setRoomType.Equals("a"))
            {
                SingleRoom SR = new SingleRoom();

                // displaying details of single room
                SR.DisplaySingleRoom();

                // make reservation for user 
                Reservation R = new Reservation();
                R.BookingSingleRoom();
            
            }
            else if (setRoomType.Equals("b"))
            {
                DoubleRoom DR = new DoubleRoom();
                DR.DisplayDoubleRoom();
                Reservation R = new Reservation();
                R.BookingDoubleRoom();
            }
            else if (setRoomType.Equals("c"))
            {
                FamilyRoom FR = new FamilyRoom();
                FR.DisplayFamilyRoom();
                Reservation R = new Reservation();
                R.BookingFamilyRoom();
            }

        }
    }
}
