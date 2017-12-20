using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace MVC_2._5Garage.Models.ViewModel
{
    public class Receipt
    {
        public int ID { get; set; }

        [DisplayName("Owner Name:")]
        public string MemberName { get; set; }

        [DisplayName("Parked in at:")]
        public DateTime CheckIn { get; set; }

        [DisplayName("Parked out at:")]
        public DateTime Checkout { get; set; }

        [DisplayName("Vehicle type:")]
        public string VehicleType { get; set; }

        [DisplayName("Registration No.:")]
        public string RegNo { get; set; }

        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        [DisplayName("Total time in garage:")]
        public TimeSpan TotalTime { get; set; }

        [DisplayName("Amount payable:")]
        public int Price { get; set; }

        public Receipt()
        {

        }

        public Receipt(VehiclesParked VehicleRec)
        {
            ID = VehicleRec.ID;
            MemberName = VehicleRec.Member.MemberName;
            CheckIn = VehicleRec.CheckInTime;
            Checkout = DateTime.Now;
           VehicleType = VehicleRec.VehicleId.ToString();
            RegNo = VehicleRec.RegNo;
            TotalTime = DateTime.Now - VehicleRec.CheckInTime;
            double TTforPricing = TotalTime.Hours;
            if (TTforPricing <= 1)
            {
                Price = 40;

            }
            else
            {
                Price = 20 * Convert.ToInt32(TTforPricing) + 20;


            }

        }
    }
}