using System;
using GamerProject.Abstract;
using GamerProject.Adapters;
using GamerProject.Entities;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Register(new Gamer
            {
                Id = 1,
                Identity = 123123123123,
                FirstName = "Burak",
                LastName = "Beşli",
                DateOfBirth = new DateTime(1994, 5, 31)
            });

            ICampaignService campaignManager = new CampaignManager();

            campaignManager.Add(new Campaign
            {
                CampaignName = "GameSatis Year of the Games indirimleri",
                Category = "Single Player",
                Id = 1,
                Price = 50
            });

            IOrderService orderService = new OrderManager(campaignManager);
            orderService.Add(new Campaign
            {
                CampaignName = "GameSatis GTA V indirimleri",
                Category = "Single Player & Multiplayer",
                Id = 2,
                Price = 70
            });

        }
    }
}
