using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Display();
        }

        // display welcome design
        public static void Display()
        {
            // welcome
            
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("     *");
                for (int k = 0; k < 10; k++)
                {
                    Console.Write("");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("     *");
                    Console.Write("     +");
                }

            }
            Console.WriteLine("                                                  Welcome to  Ahungalla");
            Console.WriteLine();
            // Payment.SetCardDetails();

            // Displaying room types
            Room.DisplayRoomType();

            // select room type
            Room.DisplayRoomDetails();
        }
    }
}
