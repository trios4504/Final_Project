using System;
using System.Collections.Generic;

namespace Final_Project
{
    class Program
    {
        public User CurrentUser { get; set; }


        static void Main()
        {


            Restaurant myRestaurant = new Restaurant();

            myRestaurant.AddPeopleIntoTheQueue("First Customer waiting");
            myRestaurant.AddPeopleIntoTheQueue("Second Customer waiting");
            myRestaurant.AddPeopleIntoTheQueue("Third Customer waiting");
            myRestaurant.AddPeopleIntoTheQueue("Fourth Customer waiting");
            myRestaurant.AddPeopleIntoTheQueue("Fifth Customer waiting");


            myRestaurant.DinerHasBeenSeated();


            myRestaurant.AddPeopleIntoTheQueue("First Customer seated");
            myRestaurant.AddPeopleIntoTheQueue("Second Customer seated");
            myRestaurant.AddPeopleIntoTheQueue("Third Customer seated");
            myRestaurant.AddPeopleIntoTheQueue("Fourth Customer seated");
            myRestaurant.AddPeopleIntoTheQueue("Fifth Customer seated");


            myRestaurant.AddDishesInTheDirtyStack("dirtyDishes1");
            myRestaurant.AddDishesInTheDirtyStack("dirtyDishes2");
            myRestaurant.AddDishesInTheDirtyStack("dirtyDishes3");
            myRestaurant.AddDishesInTheDirtyStack("dirtyDishes4");
            myRestaurant.AddDishesInTheDirtyStack("dirtyDishes5");


            myRestaurant.AddDishesInTheCleanStack("cleanDishes1");
            myRestaurant.AddDishesInTheCleanStack("cleanDishes2");
            myRestaurant.AddDishesInTheCleanStack("cleanDishes3");
            myRestaurant.AddDishesInTheCleanStack("cleanDishes4");
            myRestaurant.AddDishesInTheCleanStack("cleanDishes5");


            myRestaurant.DinerHasEatenPaidAndLeft();

            myRestaurant.WaiterHasCleanedTheTable();

            myRestaurant.ShowMeHowManyDinersIHave();

            myRestaurant.ShowMeTheActualDiners();
        }


        public class Restaurant
        {
            private Queue<string> waitingQueue = new Queue<string>();

            public void AddPeopleIntoTheQueue(string parameter)
            {
                waitingQueue.Enqueue(parameter);

            }


            public void DinerHasBeenSeated()
            {
                waitingQueue.Dequeue();
            }

            public void DinerHasEatenPaidAndLeft()
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