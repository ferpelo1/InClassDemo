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
    public class Table
    {
        [Key]
        public int TableID { get; set; }
        public byte TableNumber { get; set; } //tiny int in sql
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        //Navigation Properties
        //the Reservations table (sql) ias many to many relationship to the Tables table (sql)

        //SQL solves this problem by having an associate table
        //that has a compound primary key created from Reservations and Tables.

        //We will NOT be creating an entity for this associate table.
        //Instead we will create an overload map in our DBContext class

        //However, we can stil create the virtual navigation property to accomodate this relatiosndhip.

        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}
