using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class SingleRoom : Room
    {
        public static int[] rooms = new int[4];
        private string Internet { get; set; }
        private string MiniBar { get; set; }
      
        public SingleRoom()
        {
            List<int> integers = new List<int>() { 1, 2, 3, 4};

            Random rnd = new Random();

           
            int roomNo = rnd.Next(integers.Count());
            this.RoomNo = roomNo;
            this.Location = "First floor";
            this.BasicFacilities = "Basic facilities";
            this.Internet = "Internet service";
            this.MiniBar = "Suitable mini-bar";
        }

        // displaying details of single rooms
        public void DisplaySingleRoom()
        {
            Console.WriteLine("Facilities : ");
            Console.WriteLine("     " + Location +"\n     " + BasicFacilities + "\n     " + Internet + "\n     " + MiniBar);
        }

        // after confirm of single room booking, display details of single room
        public string StoreSingleRoom()
        {
            string stringFormat = string.Format("     "+"\n     " + Location + "\n     " + BasicFacilities + "\n     " + Internet + "\n     " + MiniBar + "\n");
            return stringFormat;
        }

        // return room number as integer , room number is initiated from 100
        public int getRoomNo()
        {
            return  (RoomNo++) + 100;
        }
    }
}
