using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseHopfully.Models
{
    public class Flight
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Plane ID")]
        public int PlaneID { get; set; }

        [Display(Name = "Plane Name")]
        public string Plane_Name { get; set; }

        [Display(Name = "Flight Duration")]
        public string Flight_Duration { get; set; }

        [Display(Name = "Flight Delay")]
        public bool FDelay { get; set; }
        [Display(Name = "Estimated Flight Delay")]
        public string Flight_Delay { get; set; }

        [Display(Name = "Plane Capacity")]
        public string Plane_Capacity { get; set; }
        [Display(Name = "Seating Type")]
        public string Seat_Type { get; set; }

        [Display(Name = "From")]
        public string LocationFrom { get; set; }
        [Display(Name = "TO")]
        public string LocationTO { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]
        public DateTime Departure_Date { get; set; }
        
        [Display(Name = "Departure Time")]
        [DataType(DataType.Time)]
        public DateTime DepartureTime { get; set; }
        
        [Display(Name = "Passenger Type")]
        [Required(ErrorMessage = " required")]
        public string Passenger_Type { get; set; }

        [Display(Name = "Ticket Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        [Display(Name = "Number of tickets")]
        [Required(ErrorMessage = "Required")]
        public int NumOfTickets { get; set; }

        [Display(Name = "Return Flight")]
        public bool Return_Flight { get; set; }

        
        



    }
}