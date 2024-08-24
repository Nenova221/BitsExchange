using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    public class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 3;
            int Bit3 = (v & mask) != 0 ? 1 : 0;
            v = (Bit3 == 0) ? v = v & (~(1 << 24)) : v = v | (1 << 24);
            mask = 1 << 4;
            int Bit4 = (v & mask) != 0 ? 1 : 0;
            v = (Bit4 == 0) ? v = v & (~(1 << 25)) : v = v | (1 << 25);
            mask = 1 << 5;
            int Bit5 = (v & mask) != 0 ? 1 : 0;
            v = (Bit5 == 0) ? v = v & (~(1 << 26)) : v = v | (1 << 26);
            mask = 1 << 24;
            int Bit24 = (v & mask) != 0 ? 1 : 0;
            v = (Bit24 == 0) ? v = v & (~(1 << 3)) : v = v | (1 << 3);
            mask = 1 << 25;
            int Bit25 = (v & mask) != 0 ? 1 : 0;
            v = (Bit25 == 0) ? v = v & (~(1 << 4)) : v = v | (1 << 4);
            mask = 1 << 26;
            int Bit26 = (v & mask) != 0 ? 1 : 0;
            v = (Bit25 == 0) ? v = v & (~(1 << 5)) : v = v | (1 << 5);
            Console.WriteLine(v);
        }
    }
}
