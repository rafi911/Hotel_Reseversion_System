using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reseversion_System
{
    class Customer
    {
        private string Name { get; set; }
        private string Email { get; set; }

        
        // Read input details of customer
        public void SetCustomerDetails()
        {
            Console.WriteLine("Enter your full name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your mail address : ");
            Email = Console.ReadLine();
           
        }

        // Displaying user details
        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Details : \n     Full name : {0}\n     Email address : {1}",Name,Email);
        }
    }
}
