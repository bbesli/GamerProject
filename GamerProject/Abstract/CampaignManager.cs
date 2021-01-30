using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya kaydı başarılı: " + campaign.CampaignName);
        }


        public void Delete(Campaign campaign)
        {
            //Logic
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            //Logic
            throw new NotImplementedException();
        }
    }
}
