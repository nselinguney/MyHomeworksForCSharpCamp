using Day5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Abstract
{
    interface IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer);
    }
}
