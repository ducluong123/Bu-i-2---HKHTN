using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buổi_2___ĐHKHTN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay
            //không.Hiển thị kết quả ra màn hình.
            Console.Write("Moi ban nhap vao so nguyen: ");
            int a = int.Parse(Console.ReadLine());
            if (a%3==0)
            {
                Console.WriteLine("So nguyen {0} chia het cho 3", a);
            }    
            else
            {
                Console.WriteLine("So nguyen {0} khong chia het cho 3", a);
            }
     
            Console.ReadKey();
        }
    }
}
