﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class NewStateUserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
           return true;

        }

        
    }
}
