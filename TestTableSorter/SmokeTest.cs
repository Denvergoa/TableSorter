using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TableSorter;

namespace TestTableSorter
{
    [TestClass]
    public class SmokeTest
    {
        [TestMethod]
        public void CanSortAscending()
        {
            Sorter sorter = new Sorter();
            sorter.TableSorter(TableFinder.AscendingSortedList);
        }

        [TestMethod]
        public void CanSortDescending()
        {
            Sorter sorter = new Sorter();
            sorter.TableSorter(TableFinder.DescendingSortedList);
        }

        [TestMethod]
        public void CanAssertThatTableIsNotSorted()
        {
            Sorter sorter = new Sorter();
            sorter.TableSorter(TableFinder.NotSortedList);
        }
    }

   
}
