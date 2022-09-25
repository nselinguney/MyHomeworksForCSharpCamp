using Day5Homework5.Abstract;
using Day5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
