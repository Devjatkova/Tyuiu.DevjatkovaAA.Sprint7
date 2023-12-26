using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Project.V2.Lib;

namespace Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 2] {{"Магазин1", "2001"},
                                                   {"Магазин2", "1998"}};
            string[] dataWait = new string[2] { "Магазин2", "1998"};

            CollectionAssert.AreEqual(dataWait, ds.Search(dataTest, "Магазин2"));
        }


        [TestMethod]
        public void ValidDataStatSum()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Магазин1", "1663"},
                                                   {"Магазин2", "1323"},
                                                   {"Магазин3", "123"}};

            double dataWait = 1446;

            string command = "sum";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStat(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatMin()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Магазин1", "1342"},
                                                   {"Магазин2", "1334"},
                                                   {"Магазин3", "543"}};

            double dataWait = 543;

            string command = "min";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStat(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatMax()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Магазин1", "1323"},
                                                   {"Магазин2", "123"},
                                                   {"Магазин3", "3211"}};

            double dataWait = 3211;

            string command = "max";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStat(dataTest, command, column));
        }
    }
}
