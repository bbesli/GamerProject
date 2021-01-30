using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Entities;


namespace GamerProject.Abstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
