using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public class OrderManager:IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanyaya satış eklendi. " + campaign.CampaignName);
        }
    }
}
