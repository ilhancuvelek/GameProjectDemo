using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(new UserValidationManager());
            gameManager.Add(new Gamer {FirstNmae="İLHAN",LastName="CÜVELEK",BirthYear=1998,IdentityNumber=123456 });

            SellingManager sellingManager = new SellingManager(new CampainManager());
            sellingManager.Sale(new Gamer {FirstNmae="İLHAN" });
            Console.Read();
        }
    }
}
