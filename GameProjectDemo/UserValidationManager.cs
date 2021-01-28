using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class UserValidationManager:IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if ((gamer.BirthYear==1998&&gamer.FirstNmae=="İLHAN")&&(gamer.LastName=="CÜVELEK"&&gamer.IdentityNumber==123456))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
