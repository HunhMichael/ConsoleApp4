using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class sp
    {

        public string tensp {  get; set; }
        public int masp { get; set; }
        public double donsp { get; set; }
        public int giasp { get; set; }

        public sp()
        {
            
        }

        public sp(string tensp, int masp, double donsp, int giasp)
        {
            this.tensp = tensp;
            this.masp = masp;
            this.donsp = donsp;
            this.giasp = giasp;
        }

        public double thanhTien()
        {
            return donsp * giasp;
        }

        public void In()
        {
            Console.WriteLine("ten san pham"+this.tensp);
            Console.WriteLine("ma san pham"+this.masp);
            Console.WriteLine("so luong"+this.donsp);
            Console.WriteLine("gia san pham"+this.giasp);


        }


    }
}
