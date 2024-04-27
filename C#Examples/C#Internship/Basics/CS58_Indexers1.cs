using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExample.CSharpExample
{
    class MonthlySales
    {
        //int[] product1 = new int[12]; int[] product2 = new int[12];
        int[] product1 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] product2 = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        public int this[int i]
        {   //set method omitted => read-only
            get { return product1[i-1] + product2[i-1]; }
        }
        public int this[string month]
        {
            get
            {
                switch (month)
                {
                    case "Jan": return product1[0] + product2[0];
                    case "Feb":
                        return product1[1] + product2[1];
                    default: return product1[0] + product2[0];

                }
            }
        }
         void Main(string[] args)
        {
            MonthlySales sales = new MonthlySales();
            Console.WriteLine(sales[1] + sales["Feb"]);
        }
    }

    }