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
        public Tours TourType { get; set; }
        public enum Tours
        {
            Kruger_National_Park,
            Ushaka,
            Robben_Island,
            Table_Mountain,
            Cape_Of_Good_Hope,
            Maclears_Beacon,
            Kirstenboch_National_Botanical_Garden,
            V_and_A_Waterfront,
            Izilo_Bo_Kaap_Museum,
            Lions_Head,
            Apartheid_Museum,
            Gold_Reef_City_Theme_Park,
            Johannesburg_Zoo,
            Lion_and_Safari_Park,
            Minitown,
            Durban_Natural_Science_Museum,
            KWA_Muhle_Museum,

        }

       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Display(Name = "Tour ID")]
        public int TourID { get; set; }

        [Display(Name = "Tour Name")]
        public string Tour_Name { get; set; }

        [Display(Name = "Tour Duration")]
        public string Tour_Duration { get; set; }

        [Display(Name = "Number of Adults")]
        public int Num_Adults { get; set; }
        [Display(Name = "Number of Kids")]
        public int Num_Kids { get; set; }

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



        //[Display(Name = "Tour Type")]
        //[Required(ErrorMessage = " required")]
        //[MaxLength(30, ErrorMessage = "Maxinum 30 charecters allowed"), MinLength(3, ErrorMessage = "Minimun 3 charecters allowed")]
        //public string TourName { get; set; }

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
        public double Guest_Cost()
        {
            double x = 0;
            x = (Price * Num_Adults)+((Price*Num_Kids)/0.50);
            return x;
        }

        public double TotalCost()
        {
            double x = 0;
            if(TourType==Tours.Apartheid_Museum)
            {
                x = Price + Guest_Cost() + deposit();
                   
            } 
            if (TourType == Tours.Cape_Of_Good_Hope)
            {
                x = Price + Guest_Cost() + deposit();

            }
           
            if (TourType == Tours.Durban_Natural_Science_Museum)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Gold_Reef_City_Theme_Park)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Izilo_Bo_Kaap_Museum)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Johannesburg_Zoo)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Kirstenboch_National_Botanical_Garden)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Kruger_National_Park)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.KWA_Muhle_Museum)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Lions_Head)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Lion_and_Safari_Park)
            {
                x = Price + Guest_Cost() + deposit();

            }
           
            if (TourType == Tours.Maclears_Beacon)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Minitown)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Robben_Island)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Ushaka)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.Table_Mountain)
            {
                x = Price + Guest_Cost() + deposit();

            }
            
            if (TourType == Tours.V_and_A_Waterfront)
            {
                x = Price + Guest_Cost() + deposit();

            }
            return x;

        }

          
    }
}