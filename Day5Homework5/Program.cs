using Day5Homework5.Concrete;
using Day5Homework5.Entities;
using System;

namespace Day5Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                YearOfBirth = "1998",
                FirstName = "Selin",
                LastName = "Güney",
                NationalId = 123456789
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { Id = 1, Name = "New Season Sales"});
        }
    }
}
