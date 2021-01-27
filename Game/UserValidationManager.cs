using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName=="Kübra" && gamer.LastName=="UÇARSU"&& gamer.IdentityNumber==1111) 
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
