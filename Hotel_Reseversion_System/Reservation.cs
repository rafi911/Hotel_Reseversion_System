using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class Reservation
    {
        // static properties
        private  static string StartDate { get; set; }
        private static int NumberOfNight { get; set; }
        private static int NumberOfRooms { get; set; }

       // public static int[] days = new int[30];

        // reservation properties which is started from 100
        private static int resNumber { get; set; } = 100;

        DoubleRoom d = new DoubleRoom();
        SingleRoom s = new SingleRoom();
        FamilyRoom f = new FamilyRoom();
       
        // book single room 
        public  void BookingSingleRoom()
        {
            
            SetDetails();
            if (NumberOfRooms <= 4)
            {
                
                if (DateValidity() == true)
                {
                    CheckSingleRooms();
                    string details = (DisplayingBookingDetails());
                    Console.WriteLine(details);
                    Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 6000);
                    Console.WriteLine("Do you want to book rooms ? ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer.Equals("yes"))
                    {
                        Customer c = new Customer();
                        c.SetCustomerDetails();
                        MakeResNumber();
                        Payment.SetCardDetails();
                        c.DisplayCustomerDetails();
                        StoreSingleRoomBookingDetails();
                        string d = (s.StoreSingleRoom()+"\n" + DisplayingBookingDetails());
                        Console.WriteLine(d);
                        Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 6000);
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                        Room.DisplayRoomType();
                        Room.DisplayRoomDetails();
                        BookingSingleRoom();

                    }
                    else
                    {
                        Console.WriteLine("See you.");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry , Rooms are not available");
                    BookingSingleRoom();
                }
            }
            else
            {
                Console.WriteLine("Sorry, Rooms are not available");
                Console.WriteLine();
                Room.DisplayRoomType();
                Room.DisplayRoomDetails();
            }
        }
        // booking double room
        public  void BookingDoubleRoom()
        {
            
            SetDetails();
            if (NumberOfRooms <= 2)
            {

                if (DateValidity() == true)
                {
                    CheckDoubleRooms();
                    string details = (DisplayingBookingDetails());
                    Console.WriteLine(details);
                    Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 8000);
                    Console.WriteLine("Do you want to book rooms ? ");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer.Equals("yes"))
                    {
                        Customer c = new Customer();
                        c.SetCustomerDetails();
                        MakeResNumber();
                        Payment.SetCardDetails();
                        c.DisplayCustomerDetails();
                        StoreDoubleRoomBookingDetails();
                        string ds = (d.StoreDoubleRoom() + "\n" + DisplayingBookingDetails());
                        Console.WriteLine(ds);
                        Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 8000);
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                        Room.DisplayRoomType();
                        Room.DisplayRoomDetails();
                        BookingDoubleRoom();

                    }
                    else
                    {
                        Console.WriteLine("See you.");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry , Rooms are not available");
                    BookingDoubleRoom();
                }
            }
            else
            {
                Console.WriteLine("Sorry, Rooms are not available");
                Console.WriteLine();
                Room.DisplayRoomType();
                Room.DisplayRoomDetails();
            }

        }
        //booking family room
        public void BookingFamilyRoom()
        {
            SetDetails();
            if (NumberOfRooms <= 2)
            {

                if (DateValidity() == true)
                {
                    CheckFamilyRooms();
                    string details = (DisplayingBookingDetails());
                    Console.WriteLine(details);
                    Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 8000);
                    Console.WriteLine("Do you want to book rooms ? (yes or no)");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (userAnswer.Equals("yes"))
                    {
                        Customer c = new Customer();
                        c.SetCustomerDetails();
                        MakeResNumber();
                        Payment.SetCardDetails();
                        c.DisplayCustomerDetails();
                        StoreFamilyRoomBookingDetails();
                        string ds = (f.StoreFamilyRoom() + "\n" + DisplayingBookingDetails());
                        Console.WriteLine(ds);
                        Payment.DiplayAmount(NumberOfRooms, NumberOfNight, 10000);
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                        Room.DisplayRoomType();
                        Room.DisplayRoomDetails();
                        BookingFamilyRoom();

                    }
                    else
                    {
                        Console.WriteLine("See you.");
                    }

                }
                else
                {
                    Console.WriteLine("Sorry , Rooms are not available");
                    BookingFamilyRoom();
                }
            }
            else
            {
                Console.WriteLine("Sorry, Rooms are not available");
                Console.WriteLine();
                Room.DisplayRoomType();
                Room.DisplayRoomDetails();
            }


        }

        // check date validity
        private  bool DateValidity()
        {
            var beforeApril = DateTime.Parse("2016-04-01");
            var endDate = DateTime.Parse("2016-04-30");
            var startDate = DateTime.Parse(StartDate);
            var finalDate = startDate.AddDays(NumberOfNight);

            var Compare = DateTime.Compare(endDate, finalDate);
            if (startDate < beforeApril || finalDate < beforeApril)
            {
                return false;
            }
            if (endDate.Date > finalDate.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        // Read enter details of reservation
        private  void SetDetails()
        {
            Console.WriteLine("Please enter Start date of reservation rooms, (format YYYY-MM-DD) : ");
            StartDate = Console.ReadLine();
            Console.WriteLine("Please enter number of nights of staying : ");
            NumberOfNight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number of rooms :");
            NumberOfRooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }
        // displaying booking details
        private  string DisplayingBookingDetails()
        {
            string sbd = string.Format("Booking details : \n"+"     "+"Start date : {0}\n     Number of night : {1}\n     Number of rooms : {2}",StartDate,NumberOfNight,NumberOfRooms);
            return sbd;
        }
        // check available single rooms 
        private void CheckSingleRooms()
        { 
            int count = 0;
            for (int i = 0; i < SingleRoom.rooms.Length; i++)
            {
                if (SingleRoom.rooms[i] == 0)
                {
                     count++;
                }
            }
            Console.WriteLine("Available rooms : {0} ", count);
            if (count == 0)
            {
                Program.Display();
                Console.WriteLine();
            }
        }
        // store single room booking information into the array
        private void StoreSingleRoomBookingDetails()
        {
           
            for (int i = 0; i < NumberOfRooms; i++)
            {
                int value = SingleRoom.rooms[i];
                if (SingleRoom.rooms.Contains(s.getRoomNo()))
                {

                    continue;
                }
                else
                {
                    SingleRoom.rooms[i] = s.getRoomNo();
                    Console.WriteLine("     " + "Room no : " + SingleRoom.rooms[i]);                  
                }
            }

        }
   
        // Make reservation number and confirm reservation of rooms
        private  void MakeResNumber()
        {
            Console.WriteLine();
            Console.WriteLine("   "+"Rooms are booked successfully" + "\n   " + "Reservation number : " + resNumber++);
            
        }



        //public static void CheckingDay()
        //{
        //    string str = "";
        //    for (int i = 0; i < days.Length; i++)
        //    {
        //        if (days.Contains(0))
        //        {
        //            StoreDate();
        //        }
        //        else
        //        {
        //            str = "Rooms are booked with this date";

        //        }
        //    }
        //    Console.WriteLine(str);
        //}
        //private static void StoreDate()
        //{
        //    string str = "";
        //    var startDate = DateTime.Parse(StartDate);
        //    var finalDate = startDate.AddDays(NumberOfNight);

        //    var sDay = startDate.Day;
        //    var endDay = finalDate.Day;

        //    for (int i = sDay; i <= endDay; i++)
        //    {
        //        if (days[i] == 1)
        //        {
        //            continue;
        //        }
        //        else
        //        {
        //            days[i] = 1;
        //            str = "succeeded";
        //        }

        //    }
        //    Console.WriteLine(str);
        //}

         // Check available double rooms
        private void CheckDoubleRooms()
        {
            
            int count = 0; 
            // find room numbers in the array and count available rooms
            for (int i = 0; i < DoubleRoom.doubleRooms.Length; i++)
            {
                if (DoubleRoom.doubleRooms[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Available rooms : {0} ", count); // Displaying room numbers which is booked 

            // if rooms are not available , user goes to home page
            if (count == 0)
            {
                Program.Display();
                Console.WriteLine();
            }
        }
        // store double room booking information into the array
        private void StoreDoubleRoomBookingDetails()
        {

            for (int i = 0; i < NumberOfRooms; i++)
            {
                int value = DoubleRoom.doubleRooms[i];
                if (DoubleRoom.doubleRooms.Contains(d.getRoomNo()))
                {

                    continue;
                }
                else
                {
                    DoubleRoom.doubleRooms[i] = d.getRoomNo();
                    Console.WriteLine("     " + "Room no : " + DoubleRoom.doubleRooms[i]);
                }
            }

        }
        // Check available family room
        private void CheckFamilyRooms()
        {

            int count = 0;
            for (int i = 0; i < FamilyRoom.familyRooms.Length; i++)
            {
                if (FamilyRoom.familyRooms[i] == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Available rooms : {0} ", count);
            if (count == 0)
            {
                Program.Display();
                Console.WriteLine();
            }
        }
        // store family room booking information into the array
        private void StoreFamilyRoomBookingDetails()
        {

            for (int i = 0; i < NumberOfRooms; i++)
            {
                int value = FamilyRoom.familyRooms[i];
                if (FamilyRoom.familyRooms.Contains(f.getRoomNo()))
                {

                    continue;
                }
                else
                {
                    FamilyRoom.familyRooms[i] = f.getRoomNo();
                    Console.WriteLine("     " + "Room no : " + FamilyRoom.familyRooms[i]);
                }
            }

        }
    }
}
