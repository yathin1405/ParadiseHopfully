﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParadiseHopfully.Models
{
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Tour ID")]
        public int TourID { get; set; }

        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }

        [Display(Name = "Tour Duration")]
        public string Tour_Duration { get; set; }

        [Display(Name = "Number of guests")]
        public string Num_Guests { get; set; }

        [Display(Name = "From")]
        public string LocationFrom { get; set; }
        //[Display(Name = "TO")]
        //public string LocationTO { get; set; }

        [Display(Name = "Tour Date")]
        [DataType(DataType.Date)]
        public DateTime TourDate { get; set; }


        [Display(Name = "Tour Start Time")]
        [DataType(DataType.Time)]
        public DateTime TourStartTime { get; set; }



        [Display(Name = "Tour Type")]
        [Required(ErrorMessage = " required")]
        [MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        public string TourName { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price Required")]
        public float Price { get; set; }

        //[Display(Name = "Deposit")]
        //[Required(ErrorMessage = "Deposit Required")]
        public double Deposit { get; set; }

        public double deposit()
        {

            double deposit = 0;
            if (Price <= 150)
            {
                deposit = Price * 0.15;
            }
            else
                if (Price > 150 && Price <= 300)
            {
                deposit = Price * 0.20;
            }
            else
                if (Price > 300 && Price <= 500)
            {
                deposit = Price * 0.25;
            }
            else
                if (Price > 500 && Price <= 800)
            {
                deposit = Price * 0.30;
            }
            else
                if (Price > 800)
            {
                deposit = Price * 0.40;
            }
            return deposit;
        }
    }
}