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
        public BikeType Type { get; set; }
        public BikeGender Gender { get; set; }
        public BikeSize Size { get; set; }
        public string Brand { get; set; }
        public double HourRate { get; set; }
        public double DailyRate { get; set; }

        public enum BikeType
        {
            Mimikyu, Tailow, Starly, Mewtoo
        }
        public enum BikeGender
        {
            Male, Female, Grandma
        }

        public enum BikeSize
        {
            Small, Medium, Large
        }
    }
}