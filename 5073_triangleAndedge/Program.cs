using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5073_triangleAndedge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                String[] str = Console.ReadLine().Split();
                if (str[0].ToString() == "0" && str[1].ToString() == "0" && str[2].ToString() == "0")
                    break;
                Int32 a = Int32.Parse(str[0]);
                Int32 b = Int32.Parse(str[1]);
                Int32 c = Int32.Parse(str[2]);
                Int32 max = Int32.Parse(str[0]);
                for(Int32 i = 0; i < str.Length; i++)
                {
                    if(max < Int32.Parse(str[i]))
                        max = Int32.Parse(str[i]);
                }
                if (max < (a + b + c - max))
                {
                    if (a == b && a == c && b == c)
                        sb.AppendLine("Equilateral");
                    else if (a == b || a == c || b == c)
                        sb.AppendLine("Isosceles");
                    else if (a != b && a != c && b != c)
                        sb.AppendLine("Scalene");
                }
                else
                    sb.AppendLine("Invalid");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
