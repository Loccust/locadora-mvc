using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace VideoStore.Model
{
    [Table("Rents")]
    public class Rent
    {
        public int RentId { get; set; }
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public DateTime RentDate { get; set; }
        [Required]
        public double TotalCost { get; set; }
   }
}
