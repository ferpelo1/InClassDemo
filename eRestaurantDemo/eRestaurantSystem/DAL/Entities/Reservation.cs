using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
#endregion

namespace eRestaurantSystem.DAL.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set;}
        public string CustomerName {get; set;}
        public DateTime ReservationDate {get; set;}
        public int NumberInParty {get; set;}
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        public string EventCode { get; set; }

        //navigation properties
        public virtual SpecialEvent Event { get; set; }

        // the Reservations table (sql) ias many to many relationship to the Tables table (sql)

        //SQL solves this problem by having an associate table
        //that has a compound primary key created from Reservations and Tables.

        //We will NOT be creating an entity for this associate table.
        //Instead we will create an overload map in our DBContext class

        //However, we can stil create the virtual navigation property to accomodate this relatiosndhip.

        public virtual ICollection<Table> Tables { get; set; }
    }
}
