using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class CampainManager:ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("kampanya eklandi");
        }

        public void Update()
        {
            Console.WriteLine("kampanya güncellendi");
        }
    }
}
