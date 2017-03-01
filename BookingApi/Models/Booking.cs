using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingApi.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:r}")]
        public DateTime StartTime { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime EndTime { get; set; }

        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}