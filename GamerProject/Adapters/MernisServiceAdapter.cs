using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MersisServiceReference;

namespace GamerProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth.Year == 1994 && gamer.FirstName == "Burak" 
                && gamer.LastName == "Beşli")
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
