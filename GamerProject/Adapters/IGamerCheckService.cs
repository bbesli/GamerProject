using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Adapters
{
    public interface IGamerCheckService
    {
        bool Validate(Gamer gamer);
    }
} 
