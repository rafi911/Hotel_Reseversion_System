using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class FamilyRoom : Room
    {
        public static int[] familyRooms = new int[2];
        private string Internet { get; set; }
        private string TV { get; set; }

        public FamilyRoom()
        {
            List<int> familynumber = new List<int>() { 1, 2 };

            Random rndom = new Random();


            int roomNo = rndom.Next(familynumber.Count());
            this.RoomNo = roomNo;
            this.Location = "Third floor";
            this.BasicFacilities = "Basic facilities";
            this.TV = "Big screen TV";
            this.Internet = "Internet service";
        }

        // displaying details of family rooms
        public void DisplayFamilyRoom()
        {
            Console.WriteLine("Facilities : ");
            Console.WriteLine("     " + BasicFacilities + "\n     " + TV + "\n     " + Internet);
        }
        public string StoreFamilyRoom()
        {
            string stringFormat = string.Format("     " + "\n     " + Location + "\n     " + BasicFacilities + "\n     " + TV );
            return stringFormat;
        }
        public int getRoomNo()
        {
            return  (RoomNo++) + 300;
        }
    }
}
