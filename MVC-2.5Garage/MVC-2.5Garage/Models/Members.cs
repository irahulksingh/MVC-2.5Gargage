using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC_2._5Garage.Models
{
    public class Members
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "Name field can have maximum 15 characters.")]
        [DisplayName("Member Name : ")]
        public string MemberName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email-Id : ")]
        [EmailAddress]
        public string MemberEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone No. : ")]
        [Phone]
        public string MemberPhone { get; set; }

        [DisplayName("Address : ")]
        public string Address { get; set; }

        public virtual ICollection<VehiclesParked> VehicleType { get; set; }
    }
}