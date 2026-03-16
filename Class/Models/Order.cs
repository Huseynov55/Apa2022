using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Models
{
    internal class Order
    {
        public int Id;
        public string Name;
        public int Count;
        public double Price;
        public double diff;

        public Order(int Id, string mehsulAdi, int mehsulunSayi, double mehsulunQiymeti)
        {
            this.Id = Id;
            Name = mehsulAdi;
            Count = mehsulunSayi;
            Price = mehsulunQiymeti;
        }

        public Order(int Id, string mehsulAdi, double mehsulunQiymeti)
        {
            this.Id = Id;
            Name = mehsulAdi;
            Count += 1;
            Price = mehsulunQiymeti;
        }


        public double TotalAmount()
        {
            double Total=Count * Price;
            return Total;
        }
        public void TotalCount(int n)
        {
            Count+= n;
            Console.WriteLine($"Mehsulun sayi: {Count}");
        }
        public void GetInfo()
        {
            Console.WriteLine($"Sifaris id: {Id}  Mehsul: {Name}  Sayi: {Count}  Qiymet: {Price}  Umumi qiymet: {TotalAmount()}");
        }

        public void ChangePrice(double yeniqiymet, out double diff)
        {
            diff = yeniqiymet - Price;
            Price = yeniqiymet;
        }







    }
}
