using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_2._5Garage.Models
{
    public class VehiclesParked
    {

        public int ID { get; set; }

        public int VehicleId { get; set; }
        public int MemberId { get; set; }


        [ForeignKey("VehicleId")]
        [DisplayName("Vehicle type :")]
        public virtual VehicleTypes Vehicle { get; set; }


        [ForeignKey("MemberId")]
        [DisplayName("Member Name :")]
        public virtual Members Member { get; set; }


        [DisplayName("Registration No. :")]
        [Required(ErrorMessage = "An Registration No. is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        public string RegNo { get; set; }

        [Required(ErrorMessage = "An Model is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("Model :")]
        public string Model { get; set; }

        [Required(ErrorMessage = "An Brand is required")]
        [RegularExpression(@"^[a-zA-Z0-9'' ']+$", ErrorMessage = "Special character should not be entered")]
        [DisplayName("Brand :")]
        public string Brand { get; set; }

        [Range(0, Int32.MaxValue, ErrorMessage = "Value should be greater than or equal to 0")]
        [DisplayName("No. Of Wheels :")]
        public int NoOfWheels { get; set; }

        [DisplayName("Parked in at :")]
        [Column(TypeName = "DateTime2")]
        public DateTime CheckInTime { get; set; }

        [DisplayName("Parked out at :")]
        [Column(TypeName = "DateTime2")]
        public DateTime CheckOutTime { get; set; }

        //[DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        ////[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        //[DisplayName("Total time in garage:")]
        //public TimeSpan TotalTime { get; set; }

        //[DisplayName("Amount payable:")]
        //public int Price { get; set; }

        //public VehiclesParked()
        //{

        //}

        //public VehiclesParked(VehiclesParked VehicleRec)
        //{
        //    //ID = VehicleRec.ID;
        //    //CheckInTime = VehicleRec.CheckInTime;
        //    //CheckOutTime = DateTime.Now;
        //    //VehiclesParked = VehicleRec.VehicleId.ToString();
        //    //RegNo = VehicleRec.RegNo;
        //    TotalTime = DateTime.Now - VehicleRec.CheckInTime;
        //    double TTforPricing = TotalTime.Hours;
        //    if (TTforPricing <= 1)
        //    {
        //        Price = 40;

        //    }
        //    else
        //    {
        //        Price = 20 * Convert.ToInt32(TTforPricing) + 20;


        //    }


        }
    }
