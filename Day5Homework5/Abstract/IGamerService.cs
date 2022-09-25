using Day5Homework5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Abstract
{
    interface IGamerService
    {
        public void Add(Gamer gamer);
        public void Delete(Gamer gamer);
        public void Update(Gamer gamer);
    }
}
