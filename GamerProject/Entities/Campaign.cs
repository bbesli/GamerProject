using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Entities
{
    public class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
    }
}
