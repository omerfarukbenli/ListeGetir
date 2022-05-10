using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.DataAccess.Abstract
{
    public interface IListeRepository
    {
        List<SinifListesi> GetAllHotels();

        SinifListesi GetHotelById(int id);

        SinifListesi CreateHotel(SinifListesi sinifListesi);

        SinifListesi UpdateHotel(SinifListesi sinifListesi);

        void DeleteHotel(int id);
    }
}
