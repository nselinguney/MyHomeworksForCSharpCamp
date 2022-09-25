using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework5.Entities
{
    class Game
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitInStock { get; set; }
    }
}
