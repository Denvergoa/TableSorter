using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WordpressAutomation;

namespace TableSorter
{
    // Example for a method, that will find a table, get all rows from one column, and convert data in to a String format. Instead of this, I use 3 lists(Ascending, Descending an NotSorted) 
    public class TableFinder
    {
        public static List<String> GetTable()
        {
            List<String> lst2 = new List<String>();
            IList<IWebElement> lst = Driver.Instance.FindElements(By.XPath("//table/tbody//td[3]"));
            int i = 0;

            foreach (IWebElement element in lst)
            {
                lst2.Insert(i, element.Text);
            }
            return lst2;
        }

        public static List<String> NotSortedList = new List<String>()
                {
                    "08-10-2010",
                    "26 - 03 - 2015",
                    "30 - 05 - 2008",
                    "17 - 11 - 2012",
                    "03 - 12 - 2009",
                    "11 - 06 - 2014"
                };
        public static List<String> AscendingSortedList = new List<String>()
                {
                    "08-10-2010",
                    "26 - 03 - 2011",
                    "30 - 05 - 2012",
                    "17 - 11 - 2013",
                    "03 - 12 - 2014",
                    "11 - 06 - 2015"
                };
        public static List<String> DescendingSortedList = new List<String>()
                {
                    "08-10-2015",
                    "26 - 03 - 2014",
                    "30 - 05 - 2013",
                    "17 - 11 - 2012",
                    "03 - 12 - 2011",
                    "11 - 06 - 2010"
                };
    }
}
