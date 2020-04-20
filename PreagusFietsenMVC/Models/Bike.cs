using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PreagusFietsenMVC.Models
{
    public class Bike
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "In Store")]
        public Store InStore { get; set; }
        [Display(Name = "Bike type")]
        public BikeType Type { get; set; }
        public BikeGender Gender { get; set; }
        public BikeSize Size { get; set; }
        public string Brand { get; set; }
        [Display(Name = "Hour rate")]
        public double HourRate { get; set; }
        [Display(Name = "Daily rate")]
        public double DailyRate { get; set; }

        public enum BikeType
        {
            Mimikyu, Tailow, Starly, Mewtoo, Pikachu, Fattypatty, Jumpluff, Flaafy, Applin
        }
        public enum BikeGender
        {
            Male, Female, Grandma, Grandpa
        }

        public enum BikeSize
        {
            Small, Medium, Large
        }
    }
}