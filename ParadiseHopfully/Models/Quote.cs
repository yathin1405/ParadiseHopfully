using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseHopfully.Models
{
    public class Quote
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Quote ID")]
        public int QuoteID { get; set; }

        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Display(Name = "Email Address")]
        public String Address { get; set; }
        [Display(Name = "ID Number")]
        public string IDNum { get; set; }

        [Display(Name = "Cruise Booking")]
        public bool BTCruiseBooking { get; set; }

        [Display(Name = "Tour Booking")]
        public bool BTTourBooking { get; set; }
        [Display(Name = "Flight Booking")]
        public bool BTFlightBooking { get; set; }
        [Display(Name = "Hotel Booking")]
        public bool BTHotelBooking { get; set; }      

        [Display(Name = "Number of guests")]
        public string Num_Guests { get; set; }
        [Display(Name = "Guest Type")]
        public string Guest_Type { get; set; }
        [Display(Name = "Number of days and Nights")]
        public string Num_Days_Nights { get; set; }

        [Display(Name = "From")]
        public string LocationFrom { get; set; }
        [Display(Name = "TO")]
        public string LocationTO { get; set; }

        [Display(Name = "Booking Start Date")]
        [DataType(DataType.Date)]
        public DateTime Start_Date { get; set; }


        [Display(Name = "Booking Time")]
        [DataType(DataType.Time)]
        public DateTime BookingTime { get; set; }


        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        
        public double deposit { get; set; }
        public string determineKey()
        {
            Random ran = new Random();
            string r = "";



            string firstTwo = First_Name.Substring(0, 2);
            string nextTwo = IDNum.Substring(4, 3);
            int randomOne = ran.Next(1, 101);
            int randomTwo = ran.Next(101, 201);
            int diff = (randomTwo - randomOne);
            string d = Convert.ToString(diff);
            r = firstTwo + nextTwo + d + "";
            return r + "";
        }
    }
}