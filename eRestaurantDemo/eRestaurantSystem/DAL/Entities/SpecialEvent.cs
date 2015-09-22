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
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage="An Event Code is required (only one character)")]
        [StringLength(1,ErrorMessage="Event Code is only one character in length")]
        public string EventCode { get; set; }
        [Required(ErrorMessage="Description is a required field")]
        [StringLength(30, ErrorMessage="Descrption has a maximum length of 30 character")]
        public string Description { get; set; }
        public bool Active { get; set; }

        //Navigational vitual properties
        //this is a parent to the Reservation entity
        public virtual ICollection<Reservation> Reseravtions { get; set; }


        //default values can be set 
        public SpecialEvent()
        {
            Active = true;
        }
    }
}
