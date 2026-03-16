using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class OnlineOrder : Order
    {
        public double distance;

        public OnlineOrder(int Id, string mehsulAdi, int mehsulunSayi, double mehsulunQiymeti, double distance): base(Id, mehsulAdi, mehsulunSayi, mehsulunQiymeti)
        {
            this.distance = distance;
        }
        public double DeliveryCharge()
        {
            return (distance / 5) * 2;
        }


    }
}
