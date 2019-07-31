using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageProject.Models
{
    public class CarService
    {
        public int Id { get; set; }

        [Required]
        public int Miles { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public string ServiceType { get; set; }

        public int CarId { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime DateAdded { get; set; }
    }
}