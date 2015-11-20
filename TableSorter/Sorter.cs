using System;
using System.Collections.Generic;
using System.Linq;

namespace TableSorter
{
    public class Sorter
    {
        public void TableSorter(List<String> lst)
        {
            int result = 0;
            Boolean b = false;
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            for (int i = 1; i < lst.Count; i++)
            {
                d1 = Convert.ToDateTime(lst.ElementAt(i - 1));
                d2 = Convert.ToDateTime(lst.ElementAt(i));
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                result = d1.CompareTo(d2);
                Console.WriteLine(result);
                if (result < 0)
                {
                    b = true;
                }
                else
                {
                    b = false;
                    break;
                }
            }
            if (b == true)
            {
                Console.WriteLine("Sorted ascending");
            }
            else
            {
                for (int i = 1; i < lst.Count; i++)
                {
                    d1 = Convert.ToDateTime(lst.ElementAt(i - 1));
                    d2 = Convert.ToDateTime(lst.ElementAt(i));
                    Console.WriteLine(d1);
                    Console.WriteLine(d2);
                    result = d1.CompareTo(d2);
                    Console.WriteLine(result);
                    if (result > 0)
                    {
                        b = true;
                    }
                    else
                    {
                        b = false;
                        Console.WriteLine("Not sorted");
                        break;
                    }
                }
                if (b == true)
                {
                    Console.WriteLine("Sorted descending");
                }

            }
        }
    }
}
