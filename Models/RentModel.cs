using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoStore.Model
{
    [Table("Rents")]
    public class Rent
    {
        public int RentId { get; set; }
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public DateTime RentDate { get; set; }
   }
}
