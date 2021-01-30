using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GamerProject.Adapters;

namespace GamerProject.Abstract
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Register(Gamer gamer)
        {
            if (_gamerCheckService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " adındaki oyuncu kaydedildi.");

            }
            else
            {
                Console.WriteLine("Kimlik bilgileri hatalı. Kayıt başarısız.");
            }
        }
        public void Update(Gamer gamer)
        {
            //update logic
            Console.WriteLine(gamer.FirstName + " adındaki oyuncu update edildi..");

        }
        public void Delete(Gamer gamer)
        {
            //Delete logic
            Console.WriteLine(gamer.FirstName + " adındaki oyuncu silindi.");
        }
    }
}
