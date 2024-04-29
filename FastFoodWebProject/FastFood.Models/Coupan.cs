using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class Coupan
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Type { get; set; }

        public double Discount { get; set; }

        public double MinimumAmount { get; set; }

        public byte[] CouponPicture { get; set; }

        public bool IsActive { get; set; }

    }

    public enum CouponType
    {
        Percent=0,
        Currency=1
    }
}

// with this class will give discount to the USER on Purchase 
