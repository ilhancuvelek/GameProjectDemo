using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class SellingManager:ISellingService
    {
        ICampaignService _campaignService;
        public SellingManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void Sale(Gamer gamer)
        {
            _campaignService.Add();
            Console.WriteLine(gamer.FirstNmae+" tarafından satın alındı");
        }
    }
}
