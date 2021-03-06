﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LendCar.Models
{
    public class Vehicle 
    {
        //vehicleIdentificationNumber 
        [Key]
        [Required]
        [MaxLength(17)]
        public string VIN { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }           
        public string PlateNumber { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        //NameOfBrand
        public string Brand { get; set; }
        public List<string> Photos { get; set; }
        public int TripsNumber { get; set; }
        public double PricePerDay { get; set; }
	public string StartDate {get; set;}
	public string EndDate {get; set;}        
        [Range(1,5)]
        public double rate { get; set; }
        public ApplicationUser Owner { get; set; }
        public ApplicationUser Renter { get; set; }
        public VehicleType VehicleType { get; set; }
        public OdoMeter OdoMeter { get; set; }

    }
}
