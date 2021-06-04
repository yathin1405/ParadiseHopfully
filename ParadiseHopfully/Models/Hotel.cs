using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseHopfully.Models
{
    public class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Hotel ID")]
        public int HotelID { get; set; }

        [Display(Name = "Hotel Name")]
        public string Hotel_Name { get; set; }

        //[Display(Name = "Cruise Duration")]
        //public string Cruise_Duration { get; set; }

        [Display(Name = "Name of guests")]
        public string Name_Guests { get; set; }

        //[Display(Name = "Email adddress")]
        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        [Display(Name = "Number of guests")]
        public string Num_Guests { get; set; }
        [Display(Name = "Guest Type")]
        public string Guest_Type { get; set; }

        

        [Display(Name = "Check in ")]
        [DataType(DataType.Date)]
        public DateTime CheckIn{ get; set; }


        [Display(Name = "Check out ")]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }



        [Display(Name = "Room Type")]
        [Required(ErrorMessage = " required")]
        [MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public string Room_Type { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }
        //work out days between 2 date pickers
        // booking()- (Price*NumGuests)+RoomType()+Breakfast()
        //RoomType- if single then x=500
        //enum for room type, guest type
        //Boolean for breakfast
        //Breakfast()
        //bool Meal
        //MealType()-veg,meat 
        
    }
}