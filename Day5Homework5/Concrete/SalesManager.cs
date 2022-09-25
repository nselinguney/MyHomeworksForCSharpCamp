using Day5Homework5.Abstract;
using Day5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Concrete
{
    class SalesManager : ISalesService
    {
        public void SellTo(Gamer gamer, Game game)
        {
            Console.WriteLine("The game named " + game.Name + " was bought by " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
