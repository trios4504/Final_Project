using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Final_UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddDishesInTheDirtyStack_IfItsADirtyDish_ReturnsString()
        {
            //Arrange
            Restaurant restaurant = new Restaurant();
            string sendVariable = "Dish 1";


            //Act

            string result = restaurant.AddDishesInTheDirtyStack(sendVariable);

            //Assert
            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void AddDishesInTheCleanStack_IfItsACleanDish_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Dish 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.AddDishesInTheCleanStack(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void DinerHasBeenSeated_IfDinerHasBeenSeated_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Diner 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.DinerHasBeenSeated(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void DinerHasEatenPaidAndLeft_IfDinerHasEatenPaidAndLeft_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Diner 1";

            restaurant.AddPeopleIntoTheQueue("Diner 1");
            string result = restaurant.DinerHasEatenPaidAndLeft(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }

        [TestMethod]
        public void WaiterHasCleanedTheTable_IfTableIsCleaned_ReturnsString()
        {

            Restaurant restaurant = new Restaurant();
            string sendVariable = "Table 1";

            restaurant.AddPeopleIntoTheQueue("Table 1");
            string result = restaurant.WaiterHasCleanedTheTable(sendVariable);


            Assert.IsTrue(sendVariable == result);
        }
    }
    public class Restaurant
    {
        private Queue<string> waitingQueue = new Queue<string>();

        public void AddPeopleIntoTheQueue(string parameter)
        {
            waitingQueue.Enqueue(parameter);

        }


        public void DinerHasBeenSeated(string sendVariable)
        {
            waitingQueue.Dequeue();
        }

        public void DinerHasEatenPaidAndLeft(string sendVariable)
        {
            waitingQueue.Dequeue();
        }


        public void WaiterHasCleanedTheTable()
        {
            waitingQueue.Dequeue();
        }


        private Queue<string> seatedQueue = new Queue<string>();

        public void PeopleSitting(string parameter)
        {
            waitingQueue.Enqueue(parameter);

        }


        public void ShowMeHowManyDinersIHave()
        {
            Console.WriteLine("I have " + waitingQueue.Count + " diners");

        }

        public void ShowMeTheActualDiners()
        {
            foreach (var item in waitingQueue)
            {
                Console.WriteLine("Diner " + item);
            }

        }


        private Stack<string> dirtyDish = new Stack<string>();

        public void AddDishesInTheDirtyStack(string newDish)
        {
            dirtyDish.Push(newDish);
        }

        private Stack<string> cleanDish = new Stack<string>();

        public void AddDishesInTheCleanStack(string newDish)
        {
            cleanDish.Push(newDish);
        }

        public bool CanUserBeAttack(User enemy)
        {
            if (enemy.IsGamer)
                return true;

            //if (enemy.ClanInfo.ClanName != CurrentUser.ClanInfo.ClanName)
            //    return true;

            return false;
        }
    }


}
}

public class User
{
    public string UserName { get; set; }
    public bool IsGamer { get; set; }
    public Clan ClanInfo { get; set; }
}

public class Clan
{
    public string ClanName { get; set; }
}