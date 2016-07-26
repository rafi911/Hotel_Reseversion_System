using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class Payment 
    {
        private int cardNumber { get; set; }
        private string issueDate { get; set; }
        private string expiryDate { get; set; }


        // set total amount of each reservation
        public  static void DiplayAmount(int numberOfRooms, int numberOfNight, double amount)
        {
            string Total = string.Format("Total amount    : {0}", (numberOfRooms * amount) * numberOfNight);
            Console.WriteLine("     "+Total);   
        }

        // Read input of card details, valid card details and confirm transactions
        public static void SetCardDetails()
        {
            Console.WriteLine("Please enter card number.");
            double cardNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter issue date");
            string issueDateString = Console.ReadLine();
            Console.WriteLine("Please enter expiry date");
            string expiryDateString = Console.ReadLine();



            var issueDate = DateTime.Parse(issueDateString); // string convert to Date.
            var expiryDate = DateTime.Parse(expiryDateString);

            var issueDateYear = DateTime.Parse(issueDateString).Year; 
            var expiryDateYear = DateTime.Parse(expiryDateString).Year;

            var different = (expiryDateYear - issueDateYear); 
            if (different < 4 || issueDate.Date > expiryDate.Date || issueDate > DateTime.Now || different > 4)
            {
                Console.WriteLine("Please enter issue date and expiry date correctly");
                Console.WriteLine();
                SetCardDetails();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Transaction is confirmed");
                Console.WriteLine();
            }



        }
    }
}
