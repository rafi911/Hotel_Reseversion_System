using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class DoubleRoom : Room
    {
        public static int[] doubleRooms = new int[2];
        private string MiniBar { get; set; }
        private string TV { get; set; }

        public DoubleRoom()
        {
            List<int> integers = new List<int>() { 1, 2};

            Random rnd = new Random();


            int roomNo = rnd.Next(integers.Count());
            this.RoomNo = roomNo;
            this.Location = "Second floor";
            this.BasicFacilities = "Basic facilities";
            this.TV = "Big screen TV";
            this.MiniBar = "Suitable mini-bar";
        }

        // displaying details of double rooms
        public void DisplayDoubleRoom()
        {
            Console.WriteLine("Facilities : ");
            Console.WriteLine("     " + BasicFacilities + "\n     " + TV + "\n     " + MiniBar);
        }
        public string StoreDoubleRoom()
        {
            string stringFormat = string.Format("     " + "\n     " + Location + "\n     " + BasicFacilities + "\n     " + TV + "\n     " + MiniBar + "\n");
            return stringFormat;
        }
        public int getRoomNo()
        {
            return 200 + RoomNo++;
        }
    }
}
