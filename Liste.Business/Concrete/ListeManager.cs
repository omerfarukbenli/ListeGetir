using Liste.Business.Abstract;
using Liste.DataAccess.Abstract;
using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.Business.Concrete
{
    public class ListeManager : IListeService
    {
        private IListeRepository _listeRepository;

        public ListeManager(IListeRepository listeRepository)
        {
            _listeRepository = listeRepository;
        }
        public SinifListesi CreateHotel(SinifListesi sinifListesi)
        {
            return _listeRepository.CreateHotel(sinifListesi);
        }

        public void DeleteHotel(int id)
        {
             _listeRepository.DeleteHotel(id);
        }

        public List<SinifListesi> GetAllHotels()
        {
            return _listeRepository.GetAllHotels();
        }

        public SinifListesi GetHotelById(int id)
        {
            if (id > 0)
            {
                return _listeRepository.GetHotelById(id);
            }
            throw new Exception("id i den küçük olamaz");

        }

        public SinifListesi UpdateHotel(SinifListesi sinifListesi)
        {
           return _listeRepository.UpdateHotel(sinifListesi);
        }
    }
}
